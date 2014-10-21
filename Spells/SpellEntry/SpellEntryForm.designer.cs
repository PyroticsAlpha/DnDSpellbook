namespace SpellEntry
{
	partial class SpellEntryForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.spellsAddedDGV = new System.Windows.Forms.DataGridView();
			this.spellIDTBxF = new System.Windows.Forms.TextBox();
			this.spellIDLabel = new System.Windows.Forms.Label();
			this.spellNameLabel = new System.Windows.Forms.Label();
			this.spellNameTBxF = new System.Windows.Forms.TextBox();
			this.spellLevelsLabel = new System.Windows.Forms.Label();
			this.spellLevelsCoBx = new System.Windows.Forms.ComboBox();
			this.spellSchoolsCoBx = new System.Windows.Forms.ComboBox();
			this.spellSchoolsLabel = new System.Windows.Forms.Label();
			this.rangeLabel = new System.Windows.Forms.Label();
			this.rangeTBxF = new System.Windows.Forms.TextBox();
			this.durationLabel = new System.Windows.Forms.Label();
			this.durationTBxF = new System.Windows.Forms.TextBox();
			this.castingTimeLabel = new System.Windows.Forms.Label();
			this.castingTimeTBxF = new System.Windows.Forms.TextBox();
			this.castingConditionLabel = new System.Windows.Forms.Label();
			this.castingConditionTBxF = new System.Windows.Forms.TextBox();
			this.reactionChBx = new System.Windows.Forms.CheckBox();
			this.swiftChBx = new System.Windows.Forms.CheckBox();
			this.spellDescriptionLabel = new System.Windows.Forms.Label();
			this.spellDescriptionTBxF = new System.Windows.Forms.TextBox();
			this.higherLevelsLabel = new System.Windows.Forms.Label();
			this.higherLevelsTBxF = new System.Windows.Forms.TextBox();
			this.scaleableChBx = new System.Windows.Forms.CheckBox();
			this.damageTypesChLBx = new System.Windows.Forms.CheckedListBox();
			this.targetabilityChLBx = new System.Windows.Forms.CheckedListBox();
			this.damageTypesLabel = new System.Windows.Forms.Label();
			this.targetabilityLabel = new System.Windows.Forms.Label();
			this.addTagsLabel = new System.Windows.Forms.Label();
			this.addTagsChLBx = new System.Windows.Forms.CheckedListBox();
			this.componentChLBx = new System.Windows.Forms.CheckedListBox();
			this.materialCostTBxF = new System.Windows.Forms.TextBox();
			this.materialCostLabel = new System.Windows.Forms.Label();
			this.saveSpellBtn = new System.Windows.Forms.Button();
			this.attackRollChBx = new System.Windows.Forms.CheckBox();
			this.savingThrowChBx = new System.Windows.Forms.CheckBox();
			this.concentrationChBx = new System.Windows.Forms.CheckBox();
			this.ritualChBx = new System.Windows.Forms.CheckBox();
			this.loadSpellBtn = new System.Windows.Forms.Button();
			this.deleteSpellBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.spellsAddedDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// spellsAddedDGV
			// 
			this.spellsAddedDGV.AllowUserToAddRows = false;
			this.spellsAddedDGV.AllowUserToDeleteRows = false;
			this.spellsAddedDGV.AllowUserToOrderColumns = true;
			this.spellsAddedDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.spellsAddedDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.spellsAddedDGV.BackgroundColor = System.Drawing.SystemColors.Window;
			this.spellsAddedDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.spellsAddedDGV.GridColor = System.Drawing.SystemColors.Control;
			this.spellsAddedDGV.Location = new System.Drawing.Point(11, 11);
			this.spellsAddedDGV.Margin = new System.Windows.Forms.Padding(2);
			this.spellsAddedDGV.MultiSelect = false;
			this.spellsAddedDGV.Name = "spellsAddedDGV";
			this.spellsAddedDGV.ReadOnly = true;
			this.spellsAddedDGV.RowHeadersVisible = false;
			this.spellsAddedDGV.RowTemplate.Height = 28;
			this.spellsAddedDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.spellsAddedDGV.Size = new System.Drawing.Size(154, 465);
			this.spellsAddedDGV.StandardTab = true;
			this.spellsAddedDGV.TabIndex = 0;
			this.spellsAddedDGV.SelectionChanged += new System.EventHandler(this.spellsAddedDGV_SelectionChange);
			// 
			// spellIDTBxF
			// 
			this.spellIDTBxF.Location = new System.Drawing.Point(207, 12);
			this.spellIDTBxF.Name = "spellIDTBxF";
			this.spellIDTBxF.Size = new System.Drawing.Size(36, 20);
			this.spellIDTBxF.TabIndex = 2;
			this.spellIDTBxF.Leave += new System.EventHandler(this.spellIDTBxF_Leave);
			// 
			// spellIDLabel
			// 
			this.spellIDLabel.AutoSize = true;
			this.spellIDLabel.Location = new System.Drawing.Point(180, 15);
			this.spellIDLabel.Name = "spellIDLabel";
			this.spellIDLabel.Size = new System.Drawing.Size(21, 13);
			this.spellIDLabel.TabIndex = 1;
			this.spellIDLabel.Text = "ID:";
			// 
			// spellNameLabel
			// 
			this.spellNameLabel.AutoSize = true;
			this.spellNameLabel.Location = new System.Drawing.Point(249, 15);
			this.spellNameLabel.Name = "spellNameLabel";
			this.spellNameLabel.Size = new System.Drawing.Size(38, 13);
			this.spellNameLabel.TabIndex = 3;
			this.spellNameLabel.Text = "Name:";
			// 
			// spellNameTBxF
			// 
			this.spellNameTBxF.Location = new System.Drawing.Point(292, 12);
			this.spellNameTBxF.Name = "spellNameTBxF";
			this.spellNameTBxF.Size = new System.Drawing.Size(180, 20);
			this.spellNameTBxF.TabIndex = 4;
			this.spellNameTBxF.Leave += new System.EventHandler(this.spellNameTBxF_Leave);
			// 
			// spellLevelsLabel
			// 
			this.spellLevelsLabel.AutoSize = true;
			this.spellLevelsLabel.Location = new System.Drawing.Point(478, 16);
			this.spellLevelsLabel.Name = "spellLevelsLabel";
			this.spellLevelsLabel.Size = new System.Drawing.Size(36, 13);
			this.spellLevelsLabel.TabIndex = 5;
			this.spellLevelsLabel.Text = "Level:";
			// 
			// spellLevelsCoBx
			// 
			this.spellLevelsCoBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.spellLevelsCoBx.FormattingEnabled = true;
			this.spellLevelsCoBx.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
			this.spellLevelsCoBx.Location = new System.Drawing.Point(520, 13);
			this.spellLevelsCoBx.Name = "spellLevelsCoBx";
			this.spellLevelsCoBx.Size = new System.Drawing.Size(36, 21);
			this.spellLevelsCoBx.TabIndex = 6;
			// 
			// spellSchoolsCoBx
			// 
			this.spellSchoolsCoBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.spellSchoolsCoBx.FormattingEnabled = true;
			this.spellSchoolsCoBx.Items.AddRange(new object[] {
            "Abjuration",
            "Alteration",
            "Conjuration",
            "Divination",
            "Evocation",
            "Illusion",
            "Necromancy",
            "Transmutation"});
			this.spellSchoolsCoBx.Location = new System.Drawing.Point(613, 12);
			this.spellSchoolsCoBx.Name = "spellSchoolsCoBx";
			this.spellSchoolsCoBx.Size = new System.Drawing.Size(152, 21);
			this.spellSchoolsCoBx.TabIndex = 8;
			// 
			// spellSchoolsLabel
			// 
			this.spellSchoolsLabel.AutoSize = true;
			this.spellSchoolsLabel.Location = new System.Drawing.Point(571, 16);
			this.spellSchoolsLabel.Name = "spellSchoolsLabel";
			this.spellSchoolsLabel.Size = new System.Drawing.Size(43, 13);
			this.spellSchoolsLabel.TabIndex = 7;
			this.spellSchoolsLabel.Text = "School:";
			// 
			// rangeLabel
			// 
			this.rangeLabel.AutoSize = true;
			this.rangeLabel.Location = new System.Drawing.Point(517, 49);
			this.rangeLabel.Name = "rangeLabel";
			this.rangeLabel.Size = new System.Drawing.Size(42, 13);
			this.rangeLabel.TabIndex = 12;
			this.rangeLabel.Text = "Range:";
			// 
			// rangeTBxF
			// 
			this.rangeTBxF.Location = new System.Drawing.Point(560, 46);
			this.rangeTBxF.Name = "rangeTBxF";
			this.rangeTBxF.Size = new System.Drawing.Size(54, 20);
			this.rangeTBxF.TabIndex = 13;
			this.rangeTBxF.Leave += new System.EventHandler(this.rangeTBxF_Leave);
			// 
			// durationLabel
			// 
			this.durationLabel.AutoSize = true;
			this.durationLabel.Location = new System.Drawing.Point(622, 50);
			this.durationLabel.Name = "durationLabel";
			this.durationLabel.Size = new System.Drawing.Size(50, 13);
			this.durationLabel.TabIndex = 14;
			this.durationLabel.Text = "Duration:";
			// 
			// durationTBxF
			// 
			this.durationTBxF.Location = new System.Drawing.Point(678, 46);
			this.durationTBxF.Name = "durationTBxF";
			this.durationTBxF.Size = new System.Drawing.Size(87, 20);
			this.durationTBxF.TabIndex = 15;
			this.durationTBxF.Leave += new System.EventHandler(this.durationTBxF_Leave);
			// 
			// castingTimeLabel
			// 
			this.castingTimeLabel.AutoSize = true;
			this.castingTimeLabel.Location = new System.Drawing.Point(180, 81);
			this.castingTimeLabel.Name = "castingTimeLabel";
			this.castingTimeLabel.Size = new System.Drawing.Size(71, 13);
			this.castingTimeLabel.TabIndex = 16;
			this.castingTimeLabel.Text = "Casting Time:";
			// 
			// castingTimeTBxF
			// 
			this.castingTimeTBxF.Location = new System.Drawing.Point(257, 78);
			this.castingTimeTBxF.Name = "castingTimeTBxF";
			this.castingTimeTBxF.Size = new System.Drawing.Size(120, 20);
			this.castingTimeTBxF.TabIndex = 17;
			this.castingTimeTBxF.Leave += new System.EventHandler(this.castingTimeTBxF_Leave);
			// 
			// castingConditionLabel
			// 
			this.castingConditionLabel.AutoSize = true;
			this.castingConditionLabel.Location = new System.Drawing.Point(401, 81);
			this.castingConditionLabel.Name = "castingConditionLabel";
			this.castingConditionLabel.Size = new System.Drawing.Size(92, 13);
			this.castingConditionLabel.TabIndex = 18;
			this.castingConditionLabel.Text = "Casting Condition:";
			// 
			// castingConditionTBxF
			// 
			this.castingConditionTBxF.Location = new System.Drawing.Point(499, 78);
			this.castingConditionTBxF.Multiline = true;
			this.castingConditionTBxF.Name = "castingConditionTBxF";
			this.castingConditionTBxF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.castingConditionTBxF.Size = new System.Drawing.Size(266, 40);
			this.castingConditionTBxF.TabIndex = 19;
			this.castingConditionTBxF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBxF_KeyDown);
			// 
			// reactionChBx
			// 
			this.reactionChBx.AutoSize = true;
			this.reactionChBx.Location = new System.Drawing.Point(238, 121);
			this.reactionChBx.Name = "reactionChBx";
			this.reactionChBx.Size = new System.Drawing.Size(69, 17);
			this.reactionChBx.TabIndex = 21;
			this.reactionChBx.Text = "Reaction";
			this.reactionChBx.UseVisualStyleBackColor = true;
			// 
			// swiftChBx
			// 
			this.swiftChBx.AutoSize = true;
			this.swiftChBx.Location = new System.Drawing.Point(183, 121);
			this.swiftChBx.Name = "swiftChBx";
			this.swiftChBx.Size = new System.Drawing.Size(49, 17);
			this.swiftChBx.TabIndex = 20;
			this.swiftChBx.Text = "Swift";
			this.swiftChBx.UseVisualStyleBackColor = true;
			// 
			// spellDescriptionLabel
			// 
			this.spellDescriptionLabel.AutoSize = true;
			this.spellDescriptionLabel.Location = new System.Drawing.Point(180, 141);
			this.spellDescriptionLabel.Name = "spellDescriptionLabel";
			this.spellDescriptionLabel.Size = new System.Drawing.Size(89, 13);
			this.spellDescriptionLabel.TabIndex = 26;
			this.spellDescriptionLabel.Text = "Spell Description:";
			// 
			// spellDescriptionTBxF
			// 
			this.spellDescriptionTBxF.AcceptsReturn = true;
			this.spellDescriptionTBxF.Location = new System.Drawing.Point(183, 159);
			this.spellDescriptionTBxF.Multiline = true;
			this.spellDescriptionTBxF.Name = "spellDescriptionTBxF";
			this.spellDescriptionTBxF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.spellDescriptionTBxF.Size = new System.Drawing.Size(579, 140);
			this.spellDescriptionTBxF.TabIndex = 27;
			this.spellDescriptionTBxF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBxF_KeyDown);
			// 
			// higherLevelsLabel
			// 
			this.higherLevelsLabel.AutoSize = true;
			this.higherLevelsLabel.Enabled = false;
			this.higherLevelsLabel.Location = new System.Drawing.Point(180, 311);
			this.higherLevelsLabel.Name = "higherLevelsLabel";
			this.higherLevelsLabel.Size = new System.Drawing.Size(88, 13);
			this.higherLevelsLabel.TabIndex = 29;
			this.higherLevelsLabel.Text = "At Higher Levels:";
			// 
			// higherLevelsTBxF
			// 
			this.higherLevelsTBxF.AcceptsReturn = true;
			this.higherLevelsTBxF.Enabled = false;
			this.higherLevelsTBxF.Location = new System.Drawing.Point(183, 327);
			this.higherLevelsTBxF.Multiline = true;
			this.higherLevelsTBxF.Name = "higherLevelsTBxF";
			this.higherLevelsTBxF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.higherLevelsTBxF.Size = new System.Drawing.Size(582, 60);
			this.higherLevelsTBxF.TabIndex = 30;
			this.higherLevelsTBxF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBxF_KeyDown);
			// 
			// scaleableChBx
			// 
			this.scaleableChBx.AutoSize = true;
			this.scaleableChBx.Location = new System.Drawing.Point(289, 310);
			this.scaleableChBx.Name = "scaleableChBx";
			this.scaleableChBx.Size = new System.Drawing.Size(73, 17);
			this.scaleableChBx.TabIndex = 28;
			this.scaleableChBx.Text = "Scaleable";
			this.scaleableChBx.UseVisualStyleBackColor = true;
			this.scaleableChBx.CheckedChanged += new System.EventHandler(this.scaleableChBx_CheckedChanged);
			// 
			// damageTypesChLBx
			// 
			this.damageTypesChLBx.BackColor = System.Drawing.SystemColors.Control;
			this.damageTypesChLBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.damageTypesChLBx.CheckOnClick = true;
			this.damageTypesChLBx.ColumnWidth = 80;
			this.damageTypesChLBx.FormattingEnabled = true;
			this.damageTypesChLBx.Items.AddRange(new object[] {
            "Slashing",
            "Bludgeoning",
            "Piercing",
            "Fire",
            "Cold",
            "Lightning",
            "Thunder",
            "Acid",
            "Radiant",
            "Necrotic",
            "Force",
            "Psychic",
            "Poison",
            "Other"});
			this.damageTypesChLBx.Location = new System.Drawing.Point(183, 416);
			this.damageTypesChLBx.MultiColumn = true;
			this.damageTypesChLBx.Name = "damageTypesChLBx";
			this.damageTypesChLBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.damageTypesChLBx.Size = new System.Drawing.Size(255, 75);
			this.damageTypesChLBx.TabIndex = 32;
			this.damageTypesChLBx.ThreeDCheckBoxes = true;
			this.damageTypesChLBx.Enter += new System.EventHandler(this.chLBx_Enter);
			this.damageTypesChLBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chLBxTabOverride_KeyDown);
			this.damageTypesChLBx.Leave += new System.EventHandler(this.chLBx_Leave);
			this.damageTypesChLBx.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.chLBxTabOverride_PreviewKeyDown);
			// 
			// targetabilityChLBx
			// 
			this.targetabilityChLBx.BackColor = System.Drawing.SystemColors.Control;
			this.targetabilityChLBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.targetabilityChLBx.CheckOnClick = true;
			this.targetabilityChLBx.ColumnWidth = 70;
			this.targetabilityChLBx.FormattingEnabled = true;
			this.targetabilityChLBx.Items.AddRange(new object[] {
            "AoE",
            "Single Target",
            "Multi Target"});
			this.targetabilityChLBx.Location = new System.Drawing.Point(414, 416);
			this.targetabilityChLBx.Name = "targetabilityChLBx";
			this.targetabilityChLBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.targetabilityChLBx.Size = new System.Drawing.Size(89, 60);
			this.targetabilityChLBx.TabIndex = 34;
			this.targetabilityChLBx.ThreeDCheckBoxes = true;
			this.targetabilityChLBx.Enter += new System.EventHandler(this.chLBx_Enter);
			this.targetabilityChLBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chLBxTabOverride_KeyDown);
			this.targetabilityChLBx.Leave += new System.EventHandler(this.chLBx_Leave);
			this.targetabilityChLBx.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.chLBxTabOverride_PreviewKeyDown);
			// 
			// damageTypesLabel
			// 
			this.damageTypesLabel.AutoSize = true;
			this.damageTypesLabel.Location = new System.Drawing.Point(180, 400);
			this.damageTypesLabel.Name = "damageTypesLabel";
			this.damageTypesLabel.Size = new System.Drawing.Size(82, 13);
			this.damageTypesLabel.TabIndex = 31;
			this.damageTypesLabel.Text = "Damage Types:";
			// 
			// targetabilityLabel
			// 
			this.targetabilityLabel.AutoSize = true;
			this.targetabilityLabel.Location = new System.Drawing.Point(411, 400);
			this.targetabilityLabel.Name = "targetabilityLabel";
			this.targetabilityLabel.Size = new System.Drawing.Size(67, 13);
			this.targetabilityLabel.TabIndex = 33;
			this.targetabilityLabel.Text = "Targetability:";
			// 
			// addTagsLabel
			// 
			this.addTagsLabel.AutoSize = true;
			this.addTagsLabel.Location = new System.Drawing.Point(507, 400);
			this.addTagsLabel.Name = "addTagsLabel";
			this.addTagsLabel.Size = new System.Drawing.Size(83, 13);
			this.addTagsLabel.TabIndex = 35;
			this.addTagsLabel.Text = "Additional Tags:";
			// 
			// addTagsChLBx
			// 
			this.addTagsChLBx.BackColor = System.Drawing.SystemColors.Control;
			this.addTagsChLBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.addTagsChLBx.CheckOnClick = true;
			this.addTagsChLBx.ColumnWidth = 70;
			this.addTagsChLBx.FormattingEnabled = true;
			this.addTagsChLBx.Items.AddRange(new object[] {
            "Healing",
            "Damaging",
            "Crowd Control",
            "Buffing",
            "Utility"});
			this.addTagsChLBx.Location = new System.Drawing.Point(510, 416);
			this.addTagsChLBx.Name = "addTagsChLBx";
			this.addTagsChLBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.addTagsChLBx.Size = new System.Drawing.Size(89, 75);
			this.addTagsChLBx.TabIndex = 36;
			this.addTagsChLBx.ThreeDCheckBoxes = true;
			this.addTagsChLBx.Enter += new System.EventHandler(this.chLBx_Enter);
			this.addTagsChLBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chLBxTabOverride_KeyDown);
			this.addTagsChLBx.Leave += new System.EventHandler(this.chLBx_Leave);
			this.addTagsChLBx.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.chLBxTabOverride_PreviewKeyDown);
			// 
			// componentChLBx
			// 
			this.componentChLBx.BackColor = System.Drawing.SystemColors.Control;
			this.componentChLBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.componentChLBx.CheckOnClick = true;
			this.componentChLBx.ColumnWidth = 30;
			this.componentChLBx.FormattingEnabled = true;
			this.componentChLBx.Items.AddRange(new object[] {
            "V",
            "S",
            "M"});
			this.componentChLBx.Location = new System.Drawing.Point(183, 50);
			this.componentChLBx.MultiColumn = true;
			this.componentChLBx.Name = "componentChLBx";
			this.componentChLBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.componentChLBx.Size = new System.Drawing.Size(100, 15);
			this.componentChLBx.TabIndex = 9;
			this.componentChLBx.ThreeDCheckBoxes = true;
			this.componentChLBx.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.componentChLBx_ItemCheck);
			this.componentChLBx.Enter += new System.EventHandler(this.chLBx_Enter);
			this.componentChLBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chLBxTabOverride_KeyDown);
			this.componentChLBx.Leave += new System.EventHandler(this.chLBx_Leave);
			this.componentChLBx.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.chLBxTabOverride_PreviewKeyDown);
			// 
			// materialCostTBxF
			// 
			this.materialCostTBxF.Enabled = false;
			this.materialCostTBxF.Location = new System.Drawing.Point(359, 47);
			this.materialCostTBxF.Name = "materialCostTBxF";
			this.materialCostTBxF.Size = new System.Drawing.Size(152, 20);
			this.materialCostTBxF.TabIndex = 11;
			// 
			// materialCostLabel
			// 
			this.materialCostLabel.AutoSize = true;
			this.materialCostLabel.Enabled = false;
			this.materialCostLabel.Location = new System.Drawing.Point(289, 50);
			this.materialCostLabel.Name = "materialCostLabel";
			this.materialCostLabel.Size = new System.Drawing.Size(71, 13);
			this.materialCostLabel.TabIndex = 10;
			this.materialCostLabel.Text = "Material Cost:";
			// 
			// saveSpellBtn
			// 
			this.saveSpellBtn.Location = new System.Drawing.Point(686, 400);
			this.saveSpellBtn.Name = "saveSpellBtn";
			this.saveSpellBtn.Size = new System.Drawing.Size(75, 23);
			this.saveSpellBtn.TabIndex = 38;
			this.saveSpellBtn.Text = "Save Spell";
			this.saveSpellBtn.UseVisualStyleBackColor = true;
			this.saveSpellBtn.Click += new System.EventHandler(this.saveSpellBtn_Click);
			// 
			// attackRollChBx
			// 
			this.attackRollChBx.AutoSize = true;
			this.attackRollChBx.Location = new System.Drawing.Point(414, 121);
			this.attackRollChBx.Name = "attackRollChBx";
			this.attackRollChBx.Size = new System.Drawing.Size(78, 17);
			this.attackRollChBx.TabIndex = 23;
			this.attackRollChBx.Text = "Attack Roll";
			this.attackRollChBx.UseVisualStyleBackColor = true;
			// 
			// savingThrowChBx
			// 
			this.savingThrowChBx.AutoSize = true;
			this.savingThrowChBx.Location = new System.Drawing.Point(316, 121);
			this.savingThrowChBx.Name = "savingThrowChBx";
			this.savingThrowChBx.Size = new System.Drawing.Size(92, 17);
			this.savingThrowChBx.TabIndex = 22;
			this.savingThrowChBx.Text = "Saving Throw";
			this.savingThrowChBx.UseVisualStyleBackColor = true;
			// 
			// concentrationChBx
			// 
			this.concentrationChBx.AutoSize = true;
			this.concentrationChBx.Location = new System.Drawing.Point(557, 121);
			this.concentrationChBx.Name = "concentrationChBx";
			this.concentrationChBx.Size = new System.Drawing.Size(92, 17);
			this.concentrationChBx.TabIndex = 25;
			this.concentrationChBx.Text = "Concentration";
			this.concentrationChBx.UseVisualStyleBackColor = true;
			// 
			// ritualChBx
			// 
			this.ritualChBx.AutoSize = true;
			this.ritualChBx.Location = new System.Drawing.Point(499, 121);
			this.ritualChBx.Name = "ritualChBx";
			this.ritualChBx.Size = new System.Drawing.Size(53, 17);
			this.ritualChBx.TabIndex = 24;
			this.ritualChBx.Text = "Ritual";
			this.ritualChBx.UseVisualStyleBackColor = true;
			// 
			// loadSpellBtn
			// 
			this.loadSpellBtn.Enabled = false;
			this.loadSpellBtn.Location = new System.Drawing.Point(11, 484);
			this.loadSpellBtn.Name = "loadSpellBtn";
			this.loadSpellBtn.Size = new System.Drawing.Size(75, 23);
			this.loadSpellBtn.TabIndex = 39;
			this.loadSpellBtn.Text = "Load Spell";
			this.loadSpellBtn.UseVisualStyleBackColor = true;
			this.loadSpellBtn.Click += new System.EventHandler(this.loadSpellBtn_Click);
			// 
			// deleteSpellBtn
			// 
			this.deleteSpellBtn.Enabled = false;
			this.deleteSpellBtn.Location = new System.Drawing.Point(92, 484);
			this.deleteSpellBtn.Name = "deleteSpellBtn";
			this.deleteSpellBtn.Size = new System.Drawing.Size(75, 23);
			this.deleteSpellBtn.TabIndex = 40;
			this.deleteSpellBtn.Text = "Delete Spell";
			this.deleteSpellBtn.UseVisualStyleBackColor = true;
			this.deleteSpellBtn.Click += new System.EventHandler(this.deleteSpellBtn_Click);
			// 
			// SpellEntryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(779, 519);
			this.Controls.Add(this.deleteSpellBtn);
			this.Controls.Add(this.loadSpellBtn);
			this.Controls.Add(this.concentrationChBx);
			this.Controls.Add(this.ritualChBx);
			this.Controls.Add(this.attackRollChBx);
			this.Controls.Add(this.savingThrowChBx);
			this.Controls.Add(this.saveSpellBtn);
			this.Controls.Add(this.materialCostTBxF);
			this.Controls.Add(this.materialCostLabel);
			this.Controls.Add(this.componentChLBx);
			this.Controls.Add(this.addTagsLabel);
			this.Controls.Add(this.addTagsChLBx);
			this.Controls.Add(this.targetabilityLabel);
			this.Controls.Add(this.damageTypesLabel);
			this.Controls.Add(this.targetabilityChLBx);
			this.Controls.Add(this.damageTypesChLBx);
			this.Controls.Add(this.scaleableChBx);
			this.Controls.Add(this.higherLevelsTBxF);
			this.Controls.Add(this.higherLevelsLabel);
			this.Controls.Add(this.spellDescriptionTBxF);
			this.Controls.Add(this.spellDescriptionLabel);
			this.Controls.Add(this.reactionChBx);
			this.Controls.Add(this.swiftChBx);
			this.Controls.Add(this.castingConditionLabel);
			this.Controls.Add(this.castingConditionTBxF);
			this.Controls.Add(this.castingTimeLabel);
			this.Controls.Add(this.castingTimeTBxF);
			this.Controls.Add(this.durationLabel);
			this.Controls.Add(this.durationTBxF);
			this.Controls.Add(this.rangeTBxF);
			this.Controls.Add(this.rangeLabel);
			this.Controls.Add(this.spellSchoolsCoBx);
			this.Controls.Add(this.spellSchoolsLabel);
			this.Controls.Add(this.spellLevelsCoBx);
			this.Controls.Add(this.spellLevelsLabel);
			this.Controls.Add(this.spellNameLabel);
			this.Controls.Add(this.spellNameTBxF);
			this.Controls.Add(this.spellIDLabel);
			this.Controls.Add(this.spellIDTBxF);
			this.Controls.Add(this.spellsAddedDGV);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "SpellEntryForm";
			this.Text = "Spell Entry";
			((System.ComponentModel.ISupportInitialize)(this.spellsAddedDGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView spellsAddedDGV;
		private System.Windows.Forms.TextBox spellIDTBxF;
		private System.Windows.Forms.Label spellIDLabel;
		private System.Windows.Forms.Label spellNameLabel;
		private System.Windows.Forms.TextBox spellNameTBxF;
		private System.Windows.Forms.Label spellLevelsLabel;
		private System.Windows.Forms.ComboBox spellLevelsCoBx;
		private System.Windows.Forms.ComboBox spellSchoolsCoBx;
		private System.Windows.Forms.Label spellSchoolsLabel;
		private System.Windows.Forms.Label rangeLabel;
		private System.Windows.Forms.TextBox rangeTBxF;
		private System.Windows.Forms.Label durationLabel;
		private System.Windows.Forms.TextBox durationTBxF;
		private System.Windows.Forms.Label castingTimeLabel;
		private System.Windows.Forms.TextBox castingTimeTBxF;
		private System.Windows.Forms.Label castingConditionLabel;
		private System.Windows.Forms.TextBox castingConditionTBxF;
		private System.Windows.Forms.CheckBox reactionChBx;
		private System.Windows.Forms.CheckBox swiftChBx;
		private System.Windows.Forms.Label spellDescriptionLabel;
		private System.Windows.Forms.TextBox spellDescriptionTBxF;
		private System.Windows.Forms.Label higherLevelsLabel;
		private System.Windows.Forms.TextBox higherLevelsTBxF;
		private System.Windows.Forms.CheckBox scaleableChBx;
		private System.Windows.Forms.CheckedListBox damageTypesChLBx;
		private System.Windows.Forms.CheckedListBox targetabilityChLBx;
		private System.Windows.Forms.Label damageTypesLabel;
		private System.Windows.Forms.Label targetabilityLabel;
		private System.Windows.Forms.Label addTagsLabel;
		private System.Windows.Forms.CheckedListBox addTagsChLBx;
		private System.Windows.Forms.CheckedListBox componentChLBx;
		private System.Windows.Forms.TextBox materialCostTBxF;
		private System.Windows.Forms.Label materialCostLabel;
		private System.Windows.Forms.Button saveSpellBtn;
		private System.Windows.Forms.CheckBox attackRollChBx;
		private System.Windows.Forms.CheckBox savingThrowChBx;
		private System.Windows.Forms.CheckBox concentrationChBx;
		private System.Windows.Forms.CheckBox ritualChBx;
		private System.Windows.Forms.Button loadSpellBtn;
		private System.Windows.Forms.Button deleteSpellBtn;
	}
}