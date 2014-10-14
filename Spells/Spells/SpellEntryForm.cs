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
	public partial class SpellEntryForm : Form
	{
		public SpellEntryForm()
		{
			InitializeComponent();
		}

		private void spellsAddedDGV_SelectionChange(object sender, EventArgs e)
		{
			
		}

		private void saveSpellBtn_Click(object sender, EventArgs e)
		{
			splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
		}

		private void higherLevelsTBxF_KeyDown(object sender, KeyEventArgs e)
		{
			tBxF_KeyDown(sender, e);
		}

		// Code that allows aasociated Multi-Line text boxes to use Ctrl-A to select all of the text (with no ding)
		private void tBxF_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.A)
			{
				((TextBox)sender).SelectAll();

				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}

		// This code is to be executed whena PreviewKeyDown event is handled; it's meant for CheckedListBoxes and overrides normal tab
		private void chLBxTabOverride_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if(e.KeyCode == Keys.Tab)
			{
				if(!e.Shift && (((CheckedListBox)sender).SelectedIndex < ((CheckedListBox)sender).Items.Count - 1))
				{
					e.IsInputKey = true;
				}
				else if(e.Shift && ((CheckedListBox)sender).SelectedIndex > 0)
				{
					e.IsInputKey = true;
				}
				else
				{
					((CheckedListBox)sender).ClearSelected();
				}
			}
		}

		// Behavior for CheckedListBoxes that allows Tab inputs to move through their data.
		private void chLBxTabOverride_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyData == (Keys.Shift | Keys.Tab))
			{
				((CheckedListBox)sender).SelectedIndex -= 1;
			}
			else if(e.KeyCode == Keys.Tab)
			{
				((CheckedListBox)sender).SelectedIndex += 1;
			}
		}

		// Forces the CheckedListBoxes that gain focus by non click methods to default to the 0th index (instead of -1)
		private void chLBx_Enter(object sender, EventArgs e)
		{
			((CheckedListBox)sender).SelectedIndex = 0;
		}

		// Clears the selection highlight of the CheckedListBox whenever focus is left
		private void chLBx_Leave(object sender, EventArgs e)
		{
			((CheckedListBox)sender).ClearSelected();
		}

		// Code that links the enabled/disabled state of the Higher Levels Label/TextBoxField with the Scaleable Check Box
		private void scaleableChBx_CheckedChanged(object sender, EventArgs e)
		{
			higherLevelsLabel.Enabled = higherLevelsTBxF.Enabled = scaleableChBx.Checked;
		}

		// Code that links the Enabled/Disabled state of the Material Cost Label/TextBoxField with the M value of the Component Checked Box List
		private void componentChLBx_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if(e.Index == 2)
			{
				materialCostLabel.Enabled = materialCostTBxF.Enabled = (e.CurrentValue == CheckState.Unchecked);
			}
		}
	}
}
