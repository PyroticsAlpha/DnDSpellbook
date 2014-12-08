using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;

namespace Spells
{
    public partial class MainForm : Form
    {
		private string dbFilename = "spells.sqlite";
		private string[] dbColNames = { "id", "name", "level", "description" };
		private const string dbColNamesSQL = "(id, name, level, description)";
		private const string dbColNamesSQLVerbose = "(id int NOT NULL UNIQUE, name varchar(30) NOT NULL, level int, description text)";

		private SQLiteConnection dbConn;
		private SQLiteCommand command;
		private System.Collections.Generic.List<string> spellbooks;



		#region ***SETUP***

		public MainForm()
		{
			InitializeComponent();
		}

        private void MainForm_Load(object sender, EventArgs e)
        {
			//TODO - If database not found, create new and import defaults from defaults.xml
			//if defaults.xml is not found create blank defaults table

			//check if sqlite database exists
			if (!System.IO.File.Exists(dbFilename))
			{
				MessageBox.Show("Database not found. A blank database has been created but does not contain the 'defaults' spellbook.");
				SQLiteConnection.CreateFile(dbFilename);
			}

			//establish connection
			dbConn = new SQLiteConnection("Data Source=" + dbFilename + "; Version=3;");
			dbConn.Open();
			command = new SQLiteCommand(dbConn);

			//create spellbooks table if not exists
			command.CommandText = "CREATE TABLE IF NOT EXISTS 'spellbooks' (name varchar(30) NOT NULL UNIQUE)";
			command.ExecuteNonQuery();

			command.CommandText = "INSERT OR IGNORE INTO spellbooks (name) VALUES ('defaults')";
			command.ExecuteNonQuery();

			//create defaults table if not exists
			command.CommandText = "CREATE TABLE IF NOT EXISTS 'defaults' " + dbColNamesSQLVerbose;
			command.ExecuteNonQuery();

			//populate comboBox1 contents
			spellbooks = new List<string>();
			command.CommandText = "SELECT name FROM spellbooks;";
			try
			{
				SQLiteDataReader rdr = command.ExecuteReader();
				while (rdr.Read())
					spellbooks.Add(rdr.GetFieldValue<string>(0));
				sbBookNamesCoBx.DataSource = spellbooks;
			}
			catch (SQLiteException ex)
			{
				MessageBox.Show("Error: The database table \"spellbooks\" could not be accessed.\n\nDetails:\n" +ex.ToString());
			}
        }

		#endregion



		#region ***UTILITIES***

        private void addRowsToTable(string sbName, DataTable table)
        {
			//ADD TO DATABASE

			//add new table name to spellbooks
			command.CommandText = "INSERT OR IGNORE INTO spellbooks (name) VALUES ('" + sbName + "')";
			command.ExecuteNonQuery();

			//create new table if not exists
			command.CommandText = "CREATE TABLE IF NOT EXISTS '" + sbName + "' " + dbColNamesSQLVerbose;
			command.ExecuteNonQuery();

			//add row to database if it has a unique id
            foreach (DataRow row in table.Rows)
            {
				if (row.Field<string>(table.Columns["id"]) != "")
				{
					command.CommandText = "INSERT OR IGNORE INTO '" + sbName + "' " + dbColNamesSQL + " VALUES (@p1, @p2, @p3, @p4)";
					int i = 1;
					foreach (string colName in dbColNames)
					{
						command.Parameters.AddWithValue("@p" + i, (table.Columns.Contains(colName) ? row[colName].ToString() : ""));
						i++;
					}
					command.ExecuteNonQuery();
				}
            }
        }
		
		#endregion



		#region ***EVENT LISTENERS***

        private void rsltsSearchResultsDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (rsltsSearchResultsDGV.SelectedRows.Count != 0)
				rsltsDetailsTB.Text = (string)rsltsSearchResultsDGV.SelectedRows[0].Cells["description"].Value;
		}

		private void sbCreateBtn_Click(object sender, EventArgs e)
		{
			CreateBookDialog createDialog = new CreateBookDialog();
			DialogResult result = createDialog.ShowDialog();
			if (result == DialogResult.OK) // Test result.
			{
				//add new table name to spellbooks
				command.CommandText = "INSERT OR IGNORE INTO 'spellbooks' (name) VALUES ('" + createDialog.bookName + "')";
				command.ExecuteNonQuery();
				
				//create new table if not exists
				command.CommandText = "CREATE TABLE IF NOT EXISTS '" + createDialog.bookName + "' " + dbColNamesSQLVerbose;
				command.ExecuteNonQuery();

				if (!spellbooks.Contains(createDialog.bookName))
					spellbooks.Add(createDialog.bookName);
				sbBookNamesCoBx.DataSource = null;
				sbBookNamesCoBx.DataSource = spellbooks;
				sbBookNamesCoBx.Text = createDialog.bookName;
			}
		}

		private void sbDeleteBtn_Click(object sender, EventArgs e)
		{

			var result = MessageBox.Show("This will permanently delete the spell book '"+sbBookNamesCoBx.SelectedItem+ "'. Are you sure you want to continue?", "Delete Spellbook", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			if(result == DialogResult.Yes)
			{
				command.CommandText = "DELETE FROM 'spellbooks' WHERE name='" + sbBookNamesCoBx.SelectedItem + "';";
				command.ExecuteNonQuery();

				command.CommandText = "DROP TABLE '" + sbBookNamesCoBx.SelectedItem + "';";
				command.ExecuteNonQuery();

				spellbooks.Remove(sbBookNamesCoBx.SelectedItem + "");
				sbBookNamesCoBx.DataSource = null;
				sbBookNamesCoBx.DataSource = spellbooks;
				sbBookNamesCoBx.Text = "defaults";
			}
		}

		private void sbBookNamesCoBx_SelectedIndexChanged(object sender, EventArgs e)
		{
			//necessary to check for null because this event is triggered during initialization/setup
			//when the combo box has no contents
			if (sbBookNamesCoBx.DataSource != null)
			{
				Debug.WriteLine("-loading db:" + sbBookNamesCoBx.Text);

				rsltsDetailsTB.Text = "";
				rsltsDataSet = new DataSet();

				string sql = "SELECT * FROM '" + sbBookNamesCoBx.Text + "';";
				SQLiteDataAdapter da = new SQLiteDataAdapter(sql, dbConn);
				da.Fill(rsltsDataSet);

				rsltsSearchResultsDGV.DataSource = rsltsDataSet.Tables[0].DefaultView;
				foreach (DataGridViewColumn col in rsltsSearchResultsDGV.Columns)
					if (col.Name != "id" && col.Name != "name")
						col.Visible = false;
				rsltsSearchResultsDGV.Columns["id"].Width = 40;
				rsltsSearchResultsDGV.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				rsltsSearchResultsDGV.Sort(rsltsSearchResultsDGV.Columns["id"], ListSortDirection.Ascending);
			}
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Debug.WriteLine("-closing program");
			command.Dispose();
			dbConn.Close();
			dbConn.Dispose();
			try
			{
				Debug.WriteLine("dbConn:"+dbConn.ToString());
			} catch(Exception ex)
			{
				Debug.WriteLine("Caught Exception");
			}
		}

	}
	#endregion
}

#region notes


//DataRow row = ((DataRowView)rsltsSearchResultsDGV.SelectedRows[0].DataBoundItem).Row;

//resultsSpellDGV.DataSource = resultsDataSet;
//resultsSpellDGV.DataMember = "spell";

/*fill table
            using (var command = new SQLiteCommand(connection))
            {
                using (var transaction = connection.BeginTransaction())
                {
                    for (int x = 0; x < 10000000; x++)
                    {
                        command.CommandText = String.Format(
                            "INSERT INTO MyTable (MyStringField, MyIntField) VALUES ('{0}', {1})",
                            x.ToString(), x);
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
            connection.Close();

            //fill database with resultsDataSet*/

#endregion