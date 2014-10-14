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
		private const string dbFilename = "spells.sqlite";
		private string[] dbColNames = { "id", "name", "level", "description" };
		private const string dbColNamesSQL = "(id, name, level, description)";
		private const string dbColNamesSQLVerbose = "(id int NOT NULL UNIQUE, name varchar(30) NOT NULL, level int, description text)";

		private SQLiteConnection dbConn;
		private System.Collections.Generic.List<string> spellbooks;
		private string loadedDatabase = "";



		#region ***SETUP***

		public MainForm()
		{
			InitializeComponent();
		}

        private void MainForm_Load(object sender, EventArgs e)
        {
			//SQLiteConnection.CreateFile(filename);
			dbConn = new SQLiteConnection("Data Source=" + dbFilename + "; Version=3;");
			dbConn.Open();

			//fillDatabase("chlamydia", importXML("C:\\Users\\Lindsay\\Desktop\\test.xml"));

			//populate comboBox1 contents
			this.spellbooks = new List<string>();
			string sql = "SELECT name FROM spellbooks;";
			SQLiteCommand command = new SQLiteCommand(sql, dbConn);
			SQLiteDataReader rdr = command.ExecuteReader();
			while (rdr.Read())
			{
				this.spellbooks.Add(rdr.GetFieldValue<string>(0));
			}
			this.sbBookNamesCoBx.DataSource = this.spellbooks;
			
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
                        command.CommandText = "INSERT OR IGNORE INTO '" + dbTableName + "' "+ dbColNamesSQL + " VALUES (@p1, @p2, @p3, @p4)";
                        int i = 1;
                        foreach (string colName in dbColNames)
                        {
                            command.Parameters.AddWithValue("@p" + i, (table.Columns.Contains(colName) ? row[colName].ToString() : ""));
                            i++;
                        }
                        command.ExecuteNonQuery();
                    }
                    //dbTransaction.Commit();
                //}
            }
        }

		private void loadSelectedDatabase()
		{
			this.loadedDatabase = this.sbBookNamesCoBx.SelectedItem + "";
			string sql = "SELECT * FROM '" + this.sbBookNamesCoBx.SelectedItem + "';";
			try
			{
				rsltsDataSet = new DataSet();
				SQLiteDataAdapter da = new SQLiteDataAdapter(sql, dbConn);
				da.Fill(rsltsDataSet);
				rsltsSearchResultsDGV.DataSource = rsltsDataSet.Tables[0].DefaultView;
			}
			catch (Exception)
			{
				throw;
			}
			foreach (DataGridViewColumn col in rsltsSearchResultsDGV.Columns)
				if (col.Name != "id" && col.Name != "name")
					col.Visible = false;
			rsltsSearchResultsDGV.Columns["id"].Width = 20;
			this.rsltsSearchResultsDGV.Sort(this.rsltsSearchResultsDGV.Columns["name"], ListSortDirection.Ascending);
		}
		
		#endregion



		#region ***EVENT LISTENERS***

        private void sbLoadBtn_Click(object sender, EventArgs e)
        {
			loadSelectedDatabase();
			//TODO - Make user sorting method persistent
        }

        private void sbCloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rsltsSearchResultsDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (rsltsSearchResultsDGV.SelectedRows.Count != 0)
            {
                DataRow row = ((DataRowView)rsltsSearchResultsDGV.SelectedRows[0].DataBoundItem).Row;
                rsltsDetailsTB.Text = row["description"].ToString();
                rsltsDetailsTB.Refresh();
            }
		}

		private void cstmImportBtn_Click(object sender, EventArgs e)
		{
			if (this.loadedDatabase != "")
			{
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
			}
		}

		private void sbCreateBtn_Click(object sender, EventArgs e)
		{
			CreateBookDialog form2 = new CreateBookDialog();
			DialogResult result = form2.ShowDialog();
			if (result == DialogResult.OK) // Test result.
			{
				//add new table name to spellbooks
				SQLiteCommand command = new SQLiteCommand(dbConn);
				string sql;
				sql = "INSERT OR IGNORE INTO spellbooks (name) VALUES ('" + form2.bookName + "')";
				command = new SQLiteCommand(sql, dbConn);
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

		#endregion

	}
}

#region notes
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