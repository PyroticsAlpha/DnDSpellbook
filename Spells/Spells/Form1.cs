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

namespace Spells
{
    public partial class MainForm : Form
    {
		private string dbFilename = "spells.sqlite";
		private string[] dbColNames = { "id", "name", "level", "description" };
		private const string dbColNamesSQL = "(id, name, level, description)";
		private const string dbColNamesSQLVerbose = "(id int NOT NULL UNIQUE, name varchar(30) NOT NULL, level int, description text)";

		private SQLiteConnection dbConn;
		public System.Collections.Generic.List<string> spellbooks;
		private string loadedDatabase = "";



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

			//create spellbooks table if not exists
			string sql = "CREATE TABLE IF NOT EXISTS 'spellbooks' (name varchar(30) NOT NULL UNIQUE)";
			SQLiteCommand command = new SQLiteCommand(sql, dbConn);
			command.ExecuteNonQuery();

			sql = "INSERT OR IGNORE INTO spellbooks (name) VALUES ('defaults')";
			command = new SQLiteCommand(sql, dbConn);
			command.ExecuteNonQuery();

			//create defaults table if not exists
			sql = "CREATE TABLE IF NOT EXISTS 'defaults' " + dbColNamesSQLVerbose;
			command = new SQLiteCommand(sql, dbConn);
			command.ExecuteNonQuery();

			//populate comboBox1 contents
			this.spellbooks = new List<string>();
			sql = "SELECT name FROM spellbooks;";
			try
			{
				command = new SQLiteCommand(sql, dbConn);
				SQLiteDataReader rdr = command.ExecuteReader();
				Console.WriteLine(rdr.ToString());
				while (rdr.Read())
				{
					this.spellbooks.Add(rdr.GetFieldValue<string>(0));
				}
				this.sbBookNamesCoBx.DataSource = this.spellbooks;
			}
			catch (SQLiteException ex)
			{
				MessageBox.Show("Error: The database table \"spellbooks\" could not be accessed.\n\nDetails:\n" +ex.ToString());
			}
        }

		#endregion



		#region ***UTILITIES***

        private DataSet importXML(string XMLfilename)
        {
			DataSet temp = new DataSet();
			temp.ReadXml(XMLfilename);

			return temp;
        }

        private void fillDatabase(string sbName, DataSet data)
        {
			//ADD TO DATABASE

			//add new table name to spellbooks
			SQLiteCommand command = new SQLiteCommand(dbConn);
			string sql;
			sql = "INSERT OR IGNORE INTO spellbooks (name) VALUES ('" + sbName + "')";
			command = new SQLiteCommand(sql, dbConn);
			command.ExecuteNonQuery();

			//create new table if not exists
			sql = "CREATE TABLE IF NOT EXISTS '" + sbName + "' " +dbColNamesSQLVerbose;
			command = new SQLiteCommand(sql, dbConn);
			command.ExecuteNonQuery();

			//add row to database if it has a unique id
			DataTable dtable = data.Tables["spell"];

			addRowsToTable(sbName, dtable);	
        }

        private void addRowsToTable(string dbTableName, DataTable table)
        {
            using(SQLiteCommand command = new SQLiteCommand(dbConn))
            {
                //using (SQLiteTransaction dbTransaction = dbConn.BeginTransaction())
                //{
                    foreach (DataRow row in table.Rows)
                    {
						if (row.Field<string>(table.Columns["id"]) != "")
						{
							command.CommandText = "INSERT OR IGNORE INTO '" + dbTableName + "' " + dbColNamesSQL + " VALUES (@p1, @p2, @p3, @p4)";
							int i = 1;
							foreach (string colName in dbColNames)
							{
								command.Parameters.AddWithValue("@p" + i, (table.Columns.Contains(colName) ? row[colName].ToString() : ""));
								i++;
							}
							command.ExecuteNonQuery();
						}
                    }
                    //dbTransaction.Commit();
                //}
            }
        }

		private void loadSelectedDatabase()
		{
			srchGBx.Enabled = true;
			cstmGBx.Enabled = true;

			this.loadedDatabase = this.sbBookNamesCoBx.SelectedItem + "";
			string sql = "SELECT * FROM '" + this.sbBookNamesCoBx.SelectedItem + "';";
			//try
			//{
				rsltsDataSet = new DataSet();
				SQLiteDataAdapter da = new SQLiteDataAdapter(sql, dbConn);
				da.Fill(rsltsDataSet);
				rsltsSearchResultsDGV.DataSource = rsltsDataSet.Tables[0].DefaultView;
			//}
			//catch (Exception e)
			//{
			//	MessageBox.Show("Error: Could not load database.\n" +e.ToString());
			//}
			foreach (DataGridViewColumn col in rsltsSearchResultsDGV.Columns)
				if (col.Name != "id" && col.Name != "name")
					col.Visible = false;
			rsltsSearchResultsDGV.Columns["id"].Width = 20;
			this.rsltsSearchResultsDGV.Sort(this.rsltsSearchResultsDGV.Columns["name"], ListSortDirection.Ascending);
			//TODO - change DGV column fill setup
		}

		private void unloadDatabase()
		{
			srchGBx.Enabled = false;
			cstmGBx.Enabled = false;
			this.loadedDatabase = "";
			rsltsSearchResultsDGV.DataSource = null;
			rsltsDetailsTB.Text = "";
		}
		
		#endregion



		#region ***EVENT LISTENERS***

        private void sbLoadBtn_Click(object sender, EventArgs e)
        {
			loadSelectedDatabase();
        }

        private void sbCloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rsltsSearchResultsDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (rsltsSearchResultsDGV.SelectedRows.Count != 0)
				rsltsDetailsTB.Text = (string)rsltsSearchResultsDGV.SelectedRows[0].Cells["description"].Value;
		}

		private void cstmImportBtn_Click(object sender, EventArgs e)
		{
			//if (this.loadedDatabase != "")
			//{
				// Show the dialog and get result.
				DialogResult result = openFileDialog1.ShowDialog();
				string file = "";
				if (result == DialogResult.OK) // Test result.
				{
					file = openFileDialog1.FileName;
					try
					{
						//string text = File.ReadAllText(file);
						//size = text.Length;
					}
					catch (System.IO.IOException)
					{
					}
					fillDatabase(this.loadedDatabase, importXML(openFileDialog1.FileName));
				}
				loadSelectedDatabase();
			//}
		}

		private void sbCreateBtn_Click(object sender, EventArgs e)
		{
			CreateBookDialog form2 = new CreateBookDialog();
			DialogResult result = form2.ShowDialog();
			if (result == DialogResult.OK) // Test result.
			{
				//add new table name to spellbooks
				string sql = "INSERT OR IGNORE INTO spellbooks (name) VALUES ('" + form2.bookName + "')";
				SQLiteCommand command = new SQLiteCommand(sql, dbConn);
				command.ExecuteNonQuery();

				if (!spellbooks.Contains(form2.bookName))
					spellbooks.Add(form2.bookName);
				this.sbBookNamesCoBx.DataSource = null;
				this.sbBookNamesCoBx.DataSource = spellbooks;
				this.sbBookNamesCoBx.Text = form2.bookName;
				this.sbBookNamesCoBx.Refresh();

				//create new table if not exists
				sql = "CREATE TABLE IF NOT EXISTS '" + form2.bookName + "' " + dbColNamesSQLVerbose;
				command = new SQLiteCommand(sql, dbConn);
				command.ExecuteNonQuery();

				loadSelectedDatabase();
			}
		}

		private void sbDeleteBtn_Click(object sender, EventArgs e)
		{

			var result = MessageBox.Show("are you sure", "wha", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			if(result == DialogResult.Yes)
			{
				string sql = "DELETE FROM 'spellbooks' WHERE name='" + sbBookNamesCoBx.SelectedItem + "';";
				SQLiteCommand command = new SQLiteCommand(sql, dbConn);
				command.ExecuteNonQuery();

				sql = "DROP TABLE '" + sbBookNamesCoBx.SelectedItem + "';";
				command = new SQLiteCommand(sql, dbConn);
				command.ExecuteNonQuery();

				if(loadedDatabase == sbBookNamesCoBx.Text)
					unloadDatabase();

				spellbooks.Remove(sbBookNamesCoBx.SelectedItem + "");
				this.sbBookNamesCoBx.DataSource = null;
				this.sbBookNamesCoBx.DataSource = spellbooks;
				this.sbBookNamesCoBx.Text = loadedDatabase;
				this.sbBookNamesCoBx.Refresh();

			}
		}

		#endregion
	}
}

#region notes


//fillDatabase("chlamydia", importXML("C:\\Users\\Lindsay\\Desktop\\test.xml"));

//DataRow row = ((DataRowView)rsltsSearchResultsDGV.SelectedRows[0].DataBoundItem).Row;
//rsltsDetailsTB.Text = row["description"].ToString();

//resultsSpellDGV.DataSource = resultsDataSet;
//resultsSpellDGV.DataMember = "spell";

/*string sql = "create table spellbooks (name)";
            SQLiteCommand command = new SQLiteCommand(sql, dbConn);
            command.ExecuteNonQuery();
            sql = "insert into spellbooks (name) values ('defaults')";
            command = new SQLiteCommand(sql, dbConn);
            command.ExecuteNonQuery();
            sql = "insert into spellbooks (name) values ('pikachu')";
            command = new SQLiteCommand(sql, dbConn);
            command.ExecuteNonQuery();

            sql = "create table defaults (name varchar(30), id int)";
            command = new SQLiteCommand(sql, dbConn);
            command.ExecuteNonQuery();                
            sql = "insert into defaults (name,id) values ('temp1',1)";
            command = new SQLiteCommand(sql, dbConn);
            command.ExecuteNonQuery();
            sql = "insert into defaults (name,id) values ('temp2',2)";
            command = new SQLiteCommand(sql, dbConn);
            command.ExecuteNonQuery();

            sql = "create table pikachu (name varchar(30), id int)";
            command = new SQLiteCommand(sql, dbConn);
            command.ExecuteNonQuery();
            sql = "insert into pikachu (name,id) values ('1temp1',1)";
            command = new SQLiteCommand(sql, dbConn);
            command.ExecuteNonQuery();
            sql = "insert into pikachu (name,id) values ('2temp2',2)";
            command = new SQLiteCommand(sql, dbConn);
            command.ExecuteNonQuery();*/

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

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                // Only row that have not been deleted
                if (drow.RowState != DataRowState.Deleted)
                {
                    sql = "insert into " + sbName + sqlCols + " values (";
                    for(int x = 0; x < colNames.Length; x++)
                    sql += ")";
                }
            }

            //fill database with resultsDataSet*/

/*command.CommandText = "SELECT count(*) FROM spellbooks WHERE name='"+sbName+"'";
            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count == 0)
            {
                sql = "INSERT OR IGNORE INTO spellbooks (name) VALUES ('" + sbName + "')";
                command = new SQLiteCommand(sql, dbConn);
                command.ExecuteNonQuery();
            }*/
//sql = "INSERT INTO " + sbName + sqlCols + " VALUES (@p1, @p2, @p3, @p4)";
//sql = "IF NOT EXISTS (SELECT id FROM " +sbName+ " WHERE id='" +row["id"].ToString()+ "') BEGIN 

#endregion