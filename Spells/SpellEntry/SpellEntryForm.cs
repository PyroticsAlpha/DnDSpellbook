using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellEntry
{
	public partial class SpellEntryForm : Form
	{
		private DataTable spellsAdded;
		private Color defaultColor = SystemColors.ControlText;
		private Color errorColor = Color.Red;
		DataSet spellDataSet = new DataSet();

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
												{"swift", typeof(bool)},
												{"reaction", typeof(bool)},
												{"st", typeof(bool)},
												{"ar", typeof(bool)},
												{"ritual", typeof(bool)},
												{"concentration", typeof(bool)},
												{"description", typeof(string)},
												{"scaleable", typeof(bool)},
												{"atHigherLevels", typeof(string)},
												{"damType", typeof(string)},
												{"aoe", typeof(bool)},
												{"single", typeof(bool)},
												{"multi", typeof(bool)},
												{"addTags", typeof(string)}
											 };

		public SpellEntryForm()
		{
			InitializeComponent();
			// Sets default values for the ComboBoxes
			initializeSpellDatatable();
			initializeToolTips();
			resetFields();
		}


		// A method that initializes the tooltips for the form
		public void initializeToolTips()
		{
			sefTT.SetToolTip(spellsAddedDGV, "Your currently created spells are stored here. Double click or click Load to load a spell.");
			sefTT.SetToolTip(spellIDTBxF, "A numerical identifier for spells. Must be a number less than 2,147,483,647");
			sefTT.SetToolTip(spellNameTBxF, "A name for the spell. Must not be a number.");
			sefTT.SetToolTip(spellLevelsCoBx, "The spell's level; 0 is cantrip.");
			sefTT.SetToolTip(spellSchoolsCoBx, "The spell's school.");
			sefTT.SetToolTip(componentChLBx, "Whether the spell has (V)ocal, (S)omatic, and/or (M)aterial components");
			sefTT.SetToolTip(materialCostTBxF, "The material cost of the spell (if any)");
			sefTT.SetToolTip(rangeTBxF, "Range of the spell in feet.");
			sefTT.SetToolTip(durationTBxF, "Duration of spell in ROUNDS. 0 is instantaneous. 6 seconds/round, 10 rounds/minute");
			sefTT.SetToolTip(castingTimeTBxF, "Time it takes to cast the spell in ROUNDS. 6 Seconds/Round, 10 rounds/minute");
			sefTT.SetToolTip(castingConditionTBxF, "Conditions for casting the spell. Generally used for Reaction spells.");
			sefTT.SetToolTip(swiftChBx, "Whether the spell can be cast as a bonus action.");
			sefTT.SetToolTip(reactionChBx, "Whether the spell can be cast as a reaction.");
			sefTT.SetToolTip(savingThrowChBx, "Whether the spell requires a saving throw.");
			sefTT.SetToolTip(attackRollChBx, "Whether the spell requires an attack roll.");
			sefTT.SetToolTip(ritualChBx, "Whether the spell can be cast as a ritual.");
			sefTT.SetToolTip(concentrationChBx, "Whether the spell requires the caster to maintain concentration.");
			sefTT.SetToolTip(spellDescriptionTBxF, "The description of the spell.");
			sefTT.SetToolTip(scaleableChBx, "Whether the spell can get stronger with levels (player or casted level)");
			sefTT.SetToolTip(higherLevelsTBxF, "The \"At higher levels\" text of the spell.");
			sefTT.SetToolTip(damageTypesChLBx, "The damage types the spell inflicts, if any.");
			sefTT.SetToolTip(targetabilityChLBx, "Whether the spell has an Area of Effect (AoE), can target a single thing, and/or can target multiple things");
			sefTT.SetToolTip(addTagsChLBx, "Healing = spell restores Heallth.\nDamaging = spell damages Health.\nCrowd Control = spell restricts movement/action of target(s).\nBuffing = spell enhances the target.\nUtility = spell provides out-of-combat utility.");
			sefTT.SetToolTip(saveSpellBtn, "Saves the entered data as a spell in the table.");
			sefTT.SetToolTip(deleteSpellBtn, "Deletes the selected spell from the table.");
			sefTT.SetToolTip(loadSpellBtn, "Loads the selected spell into the editable fields.");
			sefTT.SetToolTip(exportXMLBtn, "Saves the current spell (if there is one) to the spell table and writes the whole spell table to an XML file.");
		}

		// A method that initializes the spellsAdded DataTable (properties & columns specifically)
		public void initializeSpellDatatable()
		{
			spellsAdded = new DataTable();
			spellsAdded.CaseSensitive = false;
			spellsAdded.TableName = "Spell";
			
			// Sets id as the primary key for the spellsAdded data table
			DataColumn[] keyColumn = new DataColumn[1];
			keyColumn[0] = spellsAdded.Columns.Add("id", typeof(int));
			spellsAdded.PrimaryKey = keyColumn;

			//// Sets the default column of ID with a Unique and NotNull property. This is the most important value.
			//DataColumn tempColumn = spellsAdded.Columns.Add("id", typeof(int));
			//tempColumn.Unique = true;
			//tempColumn.AllowDBNull = false;

			for(int i = 0; i < colInfo.GetLength(0); i++)
			{
				spellsAdded.Columns.Add((string)colInfo[i, 0], (Type)colInfo[i, 1]);
			}

			// Applies the data to the DGV
			spellsAddedDGV.DataSource = spellsAdded.DefaultView;
			foreach(DataGridViewColumn col in spellsAddedDGV.Columns)
				if(col.Name != "id" && col.Name != "name")
					col.Visible = false;

			int idColWidth = 30;
			spellsAddedDGV.Columns[0].Width = idColWidth;
			spellsAddedDGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			// adds the spellsAdded data table to the spellDataSet
			spellDataSet.DataSetName = "root";
			spellDataSet.Tables.Add(spellsAdded);
		}

		private void saveSpellBtn_Click(object sender, EventArgs e)
		{
			saveSpell();

			spellDataSet.WriteXml("backup.xml");
		}

		// Saves the spell information from the data fields into the spellsAdded datatable (unless errors)
		private void saveSpell()
		{
			DataRow addedSpell = spellsAdded.NewRow();
			bool errorFlag = false; // errorFlag determines if an error prevents the spell from being saved.
			bool overwriteFlag = false; // a flag for if the id is the same and an overwrite is requrested. (using a flag instead of doing it when it's encountered allows for other errors to be revealed before 
			// deleting
			int idInt = -0;

			// Ensure that spellID has a value
			if (spellIDTBxF.Text == "")
			{
				string error = "Spell ID needs to have a value.";
				MessageBox.Show(error, "ID Missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				errorFlag = true;
			}
			else
			{
				// Determine if the entered ID Value is an integer 
				if (int.TryParse(spellIDTBxF.Text, out idInt))
				{
					// Checks to see that the id doesn't already exist in the data table
					if (spellsAdded.Rows.Contains(idInt))
					{
						string message = "A spell with the same ID is already in the data table. \nPress 'OK' to overwrite the existing spell or 'Cancel' to not.";
						var result = MessageBox.Show(message, "Overwrite?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
						if (result == DialogResult.Cancel)
						{
							errorFlag = true;
						}
						else
						{
							overwriteFlag = true;
						}
					}
					addedSpell["id"] = idInt;
				}
				else
				{
					string message = "Spell ID is invalid. The ID needs to be a number less than " + int.MaxValue.ToString();
					MessageBox.Show(message, "ID Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					errorFlag = true;
				}

				//// Set the id value and throw error messages if something is amiss
				//try
				//{
				//	addedSpell["id"] = Convert.ToInt32(spellIDTBxF.Text);
				//}
				//catch (FormatException)
				//{
				//	//Console.WriteLine("ID needs to be a number");
				//	string error = "Spell ID needs to exist and be a number.";
				//	MessageBox.Show(error, "ID Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//	errorFlag = true;
				//}
				//catch (OverflowException)
				//{
				//	//Console.WriteLine("ID entered is out of bounds");
				//	string error = "The spell ID is too large a value.";
				//	MessageBox.Show(error, "ID Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//	errorFlag = true;
				//}
			}

			// Set the name of the row
			addedSpell[(string)colInfo[0, 0]] = spellNameTBxF.Text;

			// Set the Level of the spell
			addedSpell[(string)colInfo[1, 0]] = Convert.ToInt32(spellLevelsCoBx.SelectedItem.ToString());

			// Set the School of the spell
			addedSpell[(string)colInfo[2, 0]] = spellSchoolsCoBx.SelectedItem.ToString();

			// Set the VSM values of the spell (VSM is stored as a "binary" value (represented in decimal) ex. 111 = 7 = V, S, and M are true)
			int vsmValue = 0;
			if (componentChLBx.GetItemChecked(0)) // V
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
			if (materialCostTBxF.Enabled)
			{
				addedSpell[(string)colInfo[4, 0]] = materialCostTBxF.Text;
			}
			else if (materialCostTBxF.Text != "") // if the materialCostTBxF is disabled but has text; throw a message to the user
			{
				string message = "Material Cost is entered but spell has no materials. \nPress 'OK' if you want ignore the Material Cost field (the data will be lost).";
				var result = MessageBox.Show(message, "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				if (result == DialogResult.Cancel)
				{
					errorFlag = true; // Not technically an error but serves the same purpose of not saving the spell.
				}
			}

			// If the range has a value, ensure that it's valid
			if (rangeTBxF.Text != "")
			{
				int rangeInt;
				if (int.TryParse(rangeTBxF.Text, out rangeInt))
				{
					addedSpell[(string)colInfo[5, 0]] = rangeInt;
				}
				else
				{
					string message = "Range is invalid. The Range needs to be a number less than " + int.MaxValue.ToString();
					MessageBox.Show(message, "Range Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					errorFlag = true;
				}

				//// Sets the range of the spell
				//try
				//{
				//	addedSpell[(string)colInfo[5, 0]] = Convert.ToInt32(rangeTBxF.Text);
				//}
				//catch (FormatException)
				//{
				//	string error = "Spell Range needs to be a number or blank.";
				//	MessageBox.Show(error, "Range Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//	errorFlag = true;
				//	//Console.WriteLine("Range needs to be a number");
				//}
				//catch (OverflowException)
				//{
				//	string error = "Spell Range is too large a value.";
				//	MessageBox.Show(error, "Range Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//	errorFlag = true;
				//	//Console.WriteLine("Range entered is out of bounds");
				//}
			}

			// If the range has a value, ensure that it's valid
			if (durationTBxF.Text != "")
			{
				int durInt;
				if (int.TryParse(durationTBxF.Text, out durInt))
				{
					addedSpell[(string)colInfo[6, 0]] = durInt;
				}
				else
				{
					string message = "Duration is invalid. The Duration needs to be a number less than " + int.MaxValue.ToString();
					MessageBox.Show(message, "Duration Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					errorFlag = true;
				}
				//// Sets the duration of the spell
				//try
				//{
				//	addedSpell[(string)colInfo[6, 0]] = Convert.ToInt32(durationTBxF.Text);
				//}
				//catch (FormatException)
				//{
				//	string error = "Spell Duration needs to be a number or blank.";
				//	MessageBox.Show(error, "Duration Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//	errorFlag = true;
				//	//Console.WriteLine("Duration needs to be a number");
				//}
				//catch (OverflowException)
				//{
				//	string error = "Spell Duration is too large a value.";
				//	MessageBox.Show(error, "Duration Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//	errorFlag = true;
				//	//Console.WriteLine("Duration entered is out of bounds");
				//}
			}

			// If the casting time yhas a value, ensure that it's valid
			if (castingTimeTBxF.Text != "")
			{
				int castTimeInt;
				if (int.TryParse(castingTimeTBxF.Text, out castTimeInt))
				{
					addedSpell[(string)colInfo[7, 0]] = castTimeInt;
				}
				else
				{
					string message = "Casting Time is invalid. The Casting Time needs to be a number less than " + int.MaxValue.ToString();
					MessageBox.Show(message, "Casting Time Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					errorFlag = true;
				}
				//// Sets the castTimeValue of the spell
				//try
				//{
				//	addedSpell[(string)colInfo[7, 0]] = Convert.ToInt32(castingTimeTBxF.Text);
				//}
				//catch (FormatException)
				//{
				//	string error = "Casting Time needs to be a number or blank.";
				//	MessageBox.Show(error, "Casting Time Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//	errorFlag = true;
				//	//Console.WriteLine("Casting Time needs to be a number");
				//}
				//catch (OverflowException)
				//{
				//	string error = "Casting Time is too large a value.";
				//	MessageBox.Show(error, "Casting Time Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//	errorFlag = true;
				//	//Console.WriteLine("Casting Time entered is out of bounds");
				//}
			}

			// Sets the castCondition of the spell
			addedSpell[(string)colInfo[8, 0]] = castingConditionTBxF.Text;

			// Sets if the spell is swift
			addedSpell[(string)colInfo[9, 0]] = swiftChBx.Checked;

			// Sets if the spell is a reaction
			addedSpell[(string)colInfo[10, 0]] = reactionChBx.Checked;

			// Sets if the spell has an st
			addedSpell[(string)colInfo[11, 0]] = savingThrowChBx.Checked;

			// sets if the spell has an ar
			addedSpell[(string)colInfo[12, 0]] = attackRollChBx.Checked;

			// Sets the if the spell has a ritual
			addedSpell[(string)colInfo[13, 0]] = ritualChBx.Checked;

			// Sets if the spell requires concentration
			addedSpell[(string)colInfo[14, 0]] = concentrationChBx.Checked;

			// Sets the description of the spell
			addedSpell[(string)colInfo[15, 0]] = spellDescriptionTBxF.Text;

			// Sets if the spell is scaleable
			addedSpell[(string)colInfo[16, 0]] = scaleableChBx.Checked;

			// Sets the atHigherLevels string of the spell
			if (higherLevelsTBxF.Enabled)
			{
				addedSpell[(string)colInfo[17, 0]] = higherLevelsTBxF.Text;
			}
			else if (higherLevelsTBxF.Text != "") // if the higherlevelsTBxF has text in it but is disabled
			{
				string message = "At Higher Levels has text entered but the spell is not scaleable. \nPress 'OK' if you want ignore the At Higher Levels field (the data will be lost).";
				var result = MessageBox.Show(message, "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				if (result == DialogResult.Cancel)
				{
					errorFlag = true; // Not technically an error but serves the same purpose of not saving the spell.
				}
			}

			// Sets the damtypes of the spell (if any)
			if (damageTypesChLBx.CheckedItems.Count > 0)
			{
				string damTypes = "";

				for (int i = 0; i < damageTypesChLBx.CheckedItems.Count - 1; i++)
				{
					damTypes += damageTypesChLBx.CheckedItems[i].ToString() + ", ";
				}
				damTypes += damageTypesChLBx.CheckedItems[damageTypesChLBx.CheckedItems.Count - 1];
				addedSpell[(string)colInfo[18, 0]] = damTypes;
			}

			// Sets if the spell has an AoE
			addedSpell[(string)colInfo[19, 0]] = targetabilityChLBx.GetItemChecked(0);

			// Sets if the spell has a single target
			addedSpell[(string)colInfo[20, 0]] = targetabilityChLBx.GetItemChecked(1);

			// Sets if the spell can have multiple targets
			addedSpell[(string)colInfo[21, 0]] = targetabilityChLBx.GetItemChecked(2);

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

			if (!errorFlag)
			{
				// Add the spell to the datatable
				if (overwriteFlag)
				{
					spellsAdded.Rows.Remove(spellsAdded.Rows.Find(idInt));
				}
				try
				{
					spellsAdded.Rows.Add(addedSpell);
				}
				catch (ConstraintException err) // These catches shouldn't happen if the code runs properly; just a catch all.
				{
					Console.WriteLine(err.Message);
					//Console.WriteLine("Not a Pie. " + spellsAdded.Rows.Find(addedSpell["id"]).RowError.ToString());
					//Console.WriteLine("Spell not added to datatable, some constraint (likely ID) is wrong.");
				}
				catch (NoNullAllowedException err)
				{
					Console.WriteLine(err.Message);
					//Console.WriteLine("Spell needs to have an ID");
				}

				//spellDataSet.WriteXml("test.xml");

				//spellsAdded.WriteXml("test.xml");
				resetFields();
			}
		}

		// resets the fields to their defaults
		private void resetFields()
		{
			spellIDLabel.ForeColor = errorColor;
			spellIDTBxF.Clear();
			spellIDTBxF.Focus();
			spellNameTBxF.Clear();
			spellLevelsCoBx.SelectedIndex = 0;
			spellSchoolsCoBx.SelectedIndex = 0;
			foreach (int i in componentChLBx.CheckedIndices)
			{
				componentChLBx.SetItemChecked(i, false); ;
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
				damageTypesChLBx.SetItemChecked(i, false);
			}
			foreach (int i in targetabilityChLBx.CheckedIndices)
			{
				targetabilityChLBx.SetItemChecked(i, false);
			}
			foreach (int i in addTagsChLBx.CheckedIndices)
			{
				addTagsChLBx.SetItemChecked(i, false);
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

		// Activates the load/delete spell buttons
		private void spellsAddedDGV_SelectionChange(object sender, EventArgs e)
		{
			loadSpellBtn.Enabled = deleteSpellBtn.Enabled = (spellsAddedDGV.SelectedRows.Count > 0);
		}

		// Deletes the currently selected spell from the spellsAdded datatable
		private void deleteSpellBtn_Click(object sender, EventArgs e)
		{
			spellsAdded.Rows.Remove(spellsAdded.Rows.Find(spellsAddedDGV.SelectedRows[0].Cells["id"].Value));
		}

		// Loads the currently selected spell into the editable fields
		private void loadSpellBtn_Click(object sender, EventArgs e)
		{
			loadSpell();
		}

		// Performs the functions of loading the selected spell into the input fields.
		private void loadSpell()
		{
			// Clears the fields to start again.
			resetFields();
			spellIDLabel.ForeColor = defaultColor;

			// Gets the spell data from the spellsAdded DataTable by way of the spellsAddedDGV DGV
			DataRow spellToLoad = spellsAdded.Rows.Find(spellsAddedDGV.SelectedRows[0].Cells["id"].Value);

			spellIDTBxF.Text = spellToLoad["id"].ToString();
			spellNameTBxF.Text = spellToLoad[(string)colInfo[0, 0]].ToString();
			spellLevelsCoBx.SelectedIndex = spellLevelsCoBx.FindStringExact(spellToLoad[(string)colInfo[1, 0]].ToString());
			spellSchoolsCoBx.SelectedIndex = spellSchoolsCoBx.FindStringExact(spellToLoad[(string)colInfo[2, 0]].ToString());

			int componentValue = Convert.ToInt32(spellToLoad[(string)colInfo[3, 0]].ToString());
			// Use binary math to determine M, S, and then V
			componentChLBx.SetItemChecked(2, Convert.ToBoolean(componentValue % 2));
			componentValue /= 2;
			componentChLBx.SetItemChecked(1, Convert.ToBoolean(componentValue % 2));
			componentValue /= 2;
			componentChLBx.SetItemChecked(0, Convert.ToBoolean(componentValue % 2));

			materialCostTBxF.Text = spellToLoad[(string)colInfo[4, 0]].ToString();
			rangeTBxF.Text = spellToLoad[(string)colInfo[5, 0]].ToString();
			durationTBxF.Text = spellToLoad[(string)colInfo[6, 0]].ToString();
			castingTimeTBxF.Text = spellToLoad[(string)colInfo[7, 0]].ToString();
			castingConditionTBxF.Text = spellToLoad[(string)colInfo[8, 0]].ToString();

			swiftChBx.Checked = (bool)spellToLoad[(string)colInfo[9, 0]];
			reactionChBx.Checked = (bool)spellToLoad[(string)colInfo[10, 0]];
			savingThrowChBx.Checked = (bool)spellToLoad[(string)colInfo[11, 0]];
			attackRollChBx.Checked = (bool)spellToLoad[(string)colInfo[12, 0]];
			ritualChBx.Checked = (bool)spellToLoad[(string)colInfo[13, 0]];
			concentrationChBx.Checked = (bool)spellToLoad[(string)colInfo[14, 0]];

			spellDescriptionTBxF.Text = spellToLoad[(string)colInfo[15, 0]].ToString();
			scaleableChBx.Checked = (bool)spellToLoad[(string)colInfo[16, 0]];
			higherLevelsTBxF.Text = spellToLoad[(string)colInfo[17, 0]].ToString();

			String damTypeList = spellToLoad[(string)colInfo[18, 0]].ToString();
			for (int i = 0; i < damageTypesChLBx.Items.Count; i++)
			{
				damageTypesChLBx.SetItemChecked(i, damTypeList.Contains(damageTypesChLBx.Items[i].ToString()));
			}

			targetabilityChLBx.SetItemChecked(0, (bool)spellToLoad[(string)colInfo[19, 0]]);
			targetabilityChLBx.SetItemChecked(1, (bool)spellToLoad[(string)colInfo[20, 0]]);
			targetabilityChLBx.SetItemChecked(2, (bool)spellToLoad[(string)colInfo[21, 0]]);

			String addTagsList = spellToLoad[(string)colInfo[22, 0]].ToString();
			for (int i = 0; i < addTagsChLBx.Items.Count; i++)
			{
				addTagsChLBx.SetItemChecked(i, addTagsList.Contains(addTagsChLBx.Items[i].ToString()));
			}
		}

		// Validates that spellID took an integer value
		private void spellIDTBxF_Leave(object sender, EventArgs e)
		{
			int toss = 0; // Honestly useless integer, but TryParse has no override that doesn't require it.
			if(int.TryParse(spellIDTBxF.Text, out toss))
			{
				spellIDLabel.ForeColor = defaultColor;
			}
			else
			{
				spellIDLabel.ForeColor = errorColor;
			}
		}

		// Validates that he spellID did NOT take an integer value
		private void spellNameTBxF_Leave(object sender, EventArgs e)
		{
			int toss = 0; // Honestly useless integer, but TryParse has no override that doesn't require it.
			if(int.TryParse(spellNameLabel.Text, out toss))
			{
				spellNameLabel.ForeColor = errorColor;
			}
			else
			{
				spellNameLabel.ForeColor = defaultColor;
			}
		}

		// Validates that the range is either an integer or blank
		private void rangeTBxF_Leave(object sender, EventArgs e)
		{
			int toss = 0; // Honestly useless integer, but TryParse has no override that doesn't require it.
			if(rangeTBxF.Text == "" | int.TryParse(rangeTBxF.Text, out toss))
			{
				rangeLabel.ForeColor = defaultColor;
			}
			else
			{
				rangeLabel.ForeColor = errorColor;
			}
		}

		// Validates that the duration is either an integer or blank
		private void durationTBxF_Leave(object sender, EventArgs e)
		{
			int toss = 0; // Honestly useless integer, but TryParse has no override that doesn't require it.
			if (durationTBxF.Text == "" | int.TryParse(durationTBxF.Text, out toss))
			{
				durationLabel.ForeColor = defaultColor;
			}
			else
			{
				durationLabel.ForeColor = errorColor;
			}
		}

		// Validates that the casting time is either an integer or blank
		private void castingTimeTBxF_Leave(object sender, EventArgs e)
		{
			int toss = 0; // Honestly useless integer, but TryParse has no override that doesn't require it.
			if (castingTimeTBxF.Text == "" | int.TryParse(castingTimeTBxF.Text, out toss))
			{
				castingTimeLabel.ForeColor = defaultColor;
			}
			else
			{
				castingTimeLabel.ForeColor = errorColor;
			}
		}

		// Prompts a message box if the user wants to load the double clicked spell
		private void spellsAddedDGV_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			string spellName = spellsAddedDGV.SelectedRows[0].Cells["name"].Value.ToString();
			string message = "Do you want to load " + spellName + "?\nAll unsaved data will be lost if you do so.";

			var result = MessageBox.Show(message, "Load Spell?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				loadSpell();
			}
		}

		// Saves the currently entered spell (if there is one)
		private void exportXMLBtn_Click(object sender, EventArgs e)
		{
			// Admittedly not a full check for data entry, but will assume that no spellID means no spell meant to be save.
			if(spellIDTBxF.Text != "")
			{
				saveSpell();
			}

			// Prompts the user to save an xml file with a SaveFileDialog
			SaveFileDialog saveXML = new SaveFileDialog();
			saveXML.Filter = "XML files (*.xml)|*.xml";

			if(saveXML.ShowDialog() == DialogResult.OK)
			{
				spellDataSet.WriteXml(saveXML.FileName);
			}
		}
	}
}