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
		private string filename;
		private SQLiteConnection dbConn;
		private System.Collections.Generic.List<string> spellbooks;

		//database structure constants
		string[] dbColNames = { "id", "name", "level", "description" };
		const string sqlCols = "(id, name, level, description)";

		public MainForm()
		{
			InitializeComponent();
		}

        private void MainForm_Load(object sender, EventArgs e)
        {
			filename = "spells.sqlite";
			//SQLiteConnection.CreateFile(filename);
			dbConn = new SQLiteConnection("Data Source=" + filename + "; Version=3;");
			dbConn.Open();

			//importXML();

			//fillDatabase();

			//populate comboBox1 contents
			this.spellbooks = new List<string>();
			string sql = "SELECT name FROM spellbooks;";
			SQLiteCommand command = new SQLiteCommand(sql, dbConn);
			SQLiteDataReader rdr = command.ExecuteReader();
			while (rdr.Read())
			{
				this.spellbooks.Add(rdr.GetFieldValue<string>(0));
			}
			this.sbSpellBookList.DataSource = this.spellbooks;
			
        }

        private void importXML()
        {
			string XMLfilename = "C:\\Users\\Laura\\Desktop\\spells.xml";
			resultsDataSet = new DataSet();
			resultsDataSet.ReadXml(XMLfilename);
        }

        private void fillDatabase()
        {
			//ADD TO DATABASE
			string sbName = "chlamydia";

			//add new table name to spellbooks
			SQLiteCommand command = new SQLiteCommand(dbConn);
			string sql;
			sql = "INSERT OR IGNORE INTO spellbooks (name) VALUES ('" + sbName + "')";
			command = new SQLiteCommand(sql, dbConn);
			command.ExecuteNonQuery();

			//create new table if not exists
			sql = "CREATE TABLE IF NOT EXISTS " + sbName + " (id int NOT NULL UNIQUE, name varchar(30) NOT NULL, level int, description text)";
			command = new SQLiteCommand(sql, dbConn);
			command.ExecuteNonQuery();

			//add row to database if it has a unique id
			DataTable dtable = resultsDataSet.Tables["spell"];

			addRowsToTable(sbName, dtable);	
        }

        private void addRowsToTable(string dbTableName, DataTable table)
        {
            using(SQLiteCommand command = new SQLiteCommand(dbConn))
            {
                using (SQLiteTransaction dbTransaction = dbConn.BeginTransaction())
                {
                    foreach (DataRow row in table.Rows)
                    {
                        command.CommandText = "INSERT OR IGNORE INTO " + dbTableName + sqlCols + " VALUES (@p1, @p2, @p3, @p4)";
                        int i = 1;
                        foreach (string colName in dbColNames)
                        {
                            command.Parameters.AddWithValue("@p" + i, (table.Columns.Contains(colName) ? row[colName].ToString() : ""));
                            i++;
                        }
                        command.ExecuteNonQuery();
                    }
                    dbTransaction.Commit();
                }
            }
        }

        private void sbLoadBtn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM " +this.sbSpellBookList.SelectedItem+ ";";
            try
            {
                resultsDataSet = new DataSet();
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, dbConn);
                da.Fill(resultsDataSet);
                resultsSpellDGV.DataSource = resultsDataSet.Tables[0].DefaultView;
            }
            catch (Exception)
            {
                throw;
            }
            foreach (DataGridViewColumn col in resultsSpellDGV.Columns)
                 if(col.Name != "id" && col.Name != "name")
                     col.Visible = false;
            resultsSpellDGV.Columns["id"].Width = 20;
            DataRow row = ((DataRowView)resultsSpellDGV.SelectedRows[0].DataBoundItem).Row;
            resultsSpellDetails.Text = row["description"].ToString();
			this.resultsSpellDGV.Sort(this.resultsSpellDGV.Columns["name"], ListSortDirection.Ascending);

			//TODO - Make user sorting method persistent
        }

        private void sbCloseBtn_Click(object sender, EventArgs e)
        {
            NewSetForm form2 = new NewSetForm(resultsDataSet);
            form2.Show();

            //Close();
        }

        private void searchSchoolChecklist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resultsSpellDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (resultsSpellDGV.SelectedRows.Count != 0)
            {
                DataRow row = ((DataRowView)resultsSpellDGV.SelectedRows[0].DataBoundItem).Row;
                resultsSpellDetails.Text = row["description"].ToString();
                resultsSpellDetails.Refresh();
            }
        }
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