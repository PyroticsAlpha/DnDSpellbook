﻿using System;
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
		private DataTable spellsAdded;

		// colInfo is the list of all of the columns for the dataTable/tags for the XML EXCEPT for ID. Which is assumed as a given.
		private readonly object[,] colInfo = new object[,]{
												{"name", typeof(string)},
												{"level", typeof(int)},
												{"school", typeof(string)},
												{"vsm", typeof(int)},
												{"materials", typeof(string)},
												{"range", typeof(int)},
												{"duration", typeof(int)},
												{"castTimeValue", typeof(int)},
												{"castCondition", typeof(string)},
												{"st", typeof(bool)},
												{"ar", typeof(bool)},
												{"ritual", typeof(bool)},
												{"concentration", typeof(bool)},
												{"aoe", typeof(bool)},
												{"single", typeof(bool)},
												{"multi", typeof(bool)},
												{"scaleable", typeof(bool)},
												{"swift", typeof(bool)},
												{"reaction", typeof(bool)},
												{"damType", typeof(string)},
												{"description", typeof(string)},
												{"atHigherLevels", typeof(string)},
												{"addTags", typeof(string)}
											 };

		public SpellEntryForm()
		{
			InitializeComponent();
			// Sets default values for the ComboBoxes
			spellLevelsCoBx.SelectedIndex = 0;
			spellSchoolsCoBx.SelectedIndex = 0;
			initializeSpellDatatable();
		}

		// A method that initializes the spellsAdded DataTable (properties & columns specifically)
		public void initializeSpellDatatable()
		{
			spellsAdded = new DataTable();
			spellsAdded.CaseSensitive = false;
			spellsAdded.TableName = "Spell";

			// Sets the default column of ID with a Unique and NotNull property. This is the most important value.
			DataColumn tempColumn = spellsAdded.Columns.Add("id", typeof(int));
			tempColumn.Unique = true;
			tempColumn.AllowDBNull = false;

			for (int i = 0; i < colInfo.GetLength(0); i++)
			{
				spellsAdded.Columns.Add((string)colInfo[i, 0], (Type)colInfo[i, 1]);
			}

			// Applies the data to the DGV
			spellsAddedDGV.DataSource = spellsAdded.DefaultView;
			foreach (DataGridViewColumn col in spellsAddedDGV.Columns)
				if (col.Name != "id" && col.Name != "name")
					col.Visible = false;

			int idColWidth = 30;
			spellsAddedDGV.Columns[0].Width = idColWidth;
			spellsAddedDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;	
		}

		private void spellsAddedDGV_SelectionChange(object sender, EventArgs e)
		{
			
		}

		private void saveSpellBtn_Click(object sender, EventArgs e)
		{
			DataRow addedSpell = spellsAdded.NewRow();

			// Set the id value
			try 
			{ 
				addedSpell["id"] = Convert.ToInt32(spellIDTBxF.Text); 
			}
			catch(FormatException)
			{
				Console.WriteLine("ID needs to be a number");
			}
			catch(OverflowException)
			{
				Console.WriteLine("ID entered is out of bounds");
			}

			// Set the name of the row
			addedSpell[(string)colInfo[0, 0]] = spellNameTBxF.Text;

			// Set the Level of the spell
			addedSpell[(string)colInfo[1, 0]] = Convert.ToInt32(spellLevelsCoBx.SelectedItem.ToString());

			// Set the School of the spell
			addedSpell[(string)colInfo[2, 0]] = spellSchoolsCoBx.SelectedItem.ToString();

			// Set the VSM values of the spell (VSM is stored as a "binary" value (represented in decimal) ex. 111 = 7 = V, S, and M are true)
			int vsmValue = 0;
			if(componentChLBx.GetItemChecked(0)) // V
			{
				vsmValue += 1;
			}
			if (componentChLBx.GetItemChecked(1)) // S
			{
				vsmValue += 2;
			}
			if (componentChLBx.GetItemChecked(2)) // M
			{
				vsmValue += 4;
			}

			addedSpell[(string)colInfo[3, 0]] = vsmValue;

			// Sets the materials of the spell (if there are any)
			if(materialCostTBxF.Enabled)
			{
				addedSpell[(string)colInfo[4, 0]] = materialCostTBxF.Text;
			}

			// Sets the range of the spell
			try
			{
				addedSpell[(string)colInfo[5, 0]] = Convert.ToInt32(rangeTBxF.Text);
			}
			catch (FormatException)
			{
				Console.WriteLine("Range needs to be a number");
			}
			catch (OverflowException)
			{
				Console.WriteLine("Range entered is out of bounds");
			}

			// Sets the duration of the spell
			try
			{
				addedSpell[(string)colInfo[6, 0]] = Convert.ToInt32(durationTBxF.Text);
			}
			catch (FormatException)
			{
				Console.WriteLine("Duration needs to be a number");
			}
			catch (OverflowException)
			{
				Console.WriteLine("Duration entered is out of bounds");
			}

			// Sets the castTimeValue of the spell
			try
			{
				addedSpell[(string)colInfo[7, 0]] = Convert.ToInt32(castingTimeTBxF.Text);
			}
			catch (FormatException)
			{
				Console.WriteLine("Casting Time needs to be a number");
			}
			catch (OverflowException)
			{
				Console.WriteLine("Casting Time entered is out of bounds");
			}

			// Sets the castCondition of the spell
			addedSpell[(string)colInfo[8, 0]] = castingConditionTBxF.Text;

			// Sets if the spell has an st
			addedSpell[(string)colInfo[9, 0]] = savingThrowChBx.Checked;

			// sets if the spell has an ar
			addedSpell[(string)colInfo[10, 0]] = attackRollChBx.Checked;
			
			// Sets the if the spell has a ritual
			addedSpell[(string)colInfo[11, 0]] = ritualChBx.Checked;

			// Sets if the spell requires concentration
			addedSpell[(string)colInfo[12, 0]] = concentrationChBx.Checked;

			// Sets if the spell has an AoE
			addedSpell[(string)colInfo[13, 0]] = targetabilityChLBx.GetItemChecked(0);

			// Sets if the spell has a single target
			addedSpell[(string)colInfo[14, 0]] = targetabilityChLBx.GetItemChecked(1);

			// Sets if the spell can have multiple targets
			addedSpell[(string)colInfo[15, 0]] = targetabilityChLBx.GetItemChecked(2);

			// Sets if the spell is scaleable
			addedSpell[(string)colInfo[16, 0]] = scaleableChBx.Checked;

			// Sets if the spell is swift
			addedSpell[(string)colInfo[17, 0]] = swiftChBx.Checked;

			// Sets if the spell is a reaction
			addedSpell[(string)colInfo[18, 0]] = reactionChBx.Checked;

			// Sets the damtypes of the spell (if any)
			if (damageTypesChLBx.CheckedItems.Count > 0)
			{
				string damTypes = "";

				for (int i = 0; i < damageTypesChLBx.CheckedItems.Count - 1; i++)
				{
					damTypes += damageTypesChLBx.CheckedItems[i].ToString() + ", ";
				}
				damTypes += damageTypesChLBx.CheckedItems[damageTypesChLBx.CheckedItems.Count - 1];
				addedSpell[(string)colInfo[19, 0]] = damTypes;
			}

			// Sets the description of the spell
			addedSpell[(string)colInfo[20, 0]] = spellDescriptionTBxF.Text;

			// Sets the atHigherLevels string of the spell
			addedSpell[(string)colInfo[21, 0]] = higherLevelsTBxF.Text;

			// Sets the addTags of the spell
			if (addTagsChLBx.CheckedItems.Count > 0)
			{
				string tags = "";

				for (int i = 0; i < addTagsChLBx.CheckedItems.Count - 1; i++)
				{
					tags += addTagsChLBx.CheckedItems[i].ToString() + ", ";
				}
				tags += addTagsChLBx.CheckedItems[addTagsChLBx.CheckedItems.Count - 1];
				addedSpell[(string)colInfo[22, 0]] = tags;
			}

			// Add the spell to the datatable
			try
			{
				spellsAdded.Rows.Add(addedSpell);
			}
			catch (ConstraintException)
			{
				Console.WriteLine("Spell not added to datatable, some constraint (likely ID) is wrong.");
			}
			catch (NoNullAllowedException)
			{
				Console.WriteLine("Spell needs to have an ID");
			}

			//DataSet tempDataSet = new DataSet();
			//tempDataSet.DataSetName = "root";
			//tempDataSet.Tables.Add(spellsAdded);

			//tempDataSet.WriteXml("test.xml");

			spellsAdded.WriteXml("test.xml");
			resetFields();
		}

		// resets the fields to their defaults
		private void resetFields()
		{
			spellIDTBxF.Clear();
			spellNameTBxF.Clear();
			spellLevelsCoBx.SelectedIndex = 0;
			spellSchoolsCoBx.SelectedIndex = 0;
			foreach(int i in componentChLBx.CheckedIndices)
			{
				componentChLBx.SetItemCheckState(i, CheckState.Unchecked);
			}
			materialCostTBxF.Clear();
			rangeTBxF.Clear();
			durationTBxF.Clear();
			castingTimeTBxF.Clear();
			castingConditionTBxF.Clear();
			swiftChBx.Checked = false;
			reactionChBx.Checked = false;
			savingThrowChBx.Checked = false;
			attackRollChBx.Checked = false;
			ritualChBx.Checked = false;
			concentrationChBx.Checked = false;
			spellDescriptionTBxF.Clear();
			scaleableChBx.Checked = false;
			higherLevelsTBxF.Clear();
			foreach (int i in damageTypesChLBx.CheckedIndices)
			{
				damageTypesChLBx.SetItemCheckState(i, CheckState.Unchecked);
			}
			foreach (int i in targetabilityChLBx.CheckedIndices)
			{
				targetabilityChLBx.SetItemCheckState(i, CheckState.Unchecked);
			}
			foreach (int i in addTagsChLBx.CheckedIndices)
			{
				addTagsChLBx.SetItemCheckState(i, CheckState.Unchecked);
			}
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
