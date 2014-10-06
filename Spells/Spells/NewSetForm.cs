using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spells
{
    public partial class NewSetForm : Form
    {
        private DataSet dataSet;

        public NewSetForm()
        {
            
        }

        public NewSetForm(DataSet ds)
        {
            InitializeComponent();
            dataSet = ds;

            DataTable dtable = dataSet.Tables[0];

            // Clear the ListView control
            listView1.Items.Clear();

            listView1.Columns.Add("ID", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("Name", 70, HorizontalAlignment.Left);

            // Display items in the ListView control
            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                // Only row that have not been deleted
                if (drow.RowState != DataRowState.Deleted)
                {
                    // Define the list items
                    ListViewItem lvi = new ListViewItem(drow["id"].ToString());
                    lvi.SubItems.Add(drow["name"].ToString());

                    // Add the list items to the ListView
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
