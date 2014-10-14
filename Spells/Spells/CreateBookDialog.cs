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
    public partial class CreateBookDialog : Form
    {
		public string bookName;

        public CreateBookDialog()
        {
			InitializeComponent();
        }

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			bookName = bookNameTBx.Text;
			Close();
		}
    }
}
