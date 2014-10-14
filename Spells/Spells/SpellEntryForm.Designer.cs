namespace Spells
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
			this.damageTypeChLBx = new System.Windows.Forms.CheckedListBox();
			this.targetabilityChLBx = new System.Windows.Forms.CheckedListBox();
			this.damageTypesLabel = new System.Windows.Forms.Label();
			this.targetabilityLabel = new System.Windows.Forms.Label();
			this.addTagsLabel = new System.Windows.Forms.Label();
			this.addTagsChLBx = new System.Windows.Forms.CheckedListBox();
			this.componentChLBx = new System.Windows.Forms.CheckedListBox();
			this.materialCostTBxF = new System.Windows.Forms.TextBox();
			this.materialCostLabel = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.saveSpellBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.spellsAddedDGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// spellsAddedDGV
			// 
			this.spellsAddedDGV.AllowUserToAddRows = false;
			this.spellsAddedDGV.AllowUserToDeleteRows = false;
			this.spellsAddedDGV.AllowUserToOrderColumns = true;
			this.spellsAddedDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.spellsAddedDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
			this.spellsAddedDGV.Size = new System.Drawing.Size(154, 475);
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
			// 
			// castingTimeLabel
			// 
			this.castingTimeLabel.AutoSize = true;
			this.castingTimeLabel.Location = new System.Drawing.Point(180, 83);
			this.castingTimeLabel.Name = "castingTimeLabel";
			this.castingTimeLabel.Size = new System.Drawing.Size(71, 13);
			this.castingTimeLabel.TabIndex = 16;
			this.castingTimeLabel.Text = "Casting Time:";
			// 
			// castingTimeTBxF
			// 
			this.castingTimeTBxF.Location = new System.Drawing.Point(257, 80);
			this.castingTimeTBxF.Name = "castingTimeTBxF";
			this.castingTimeTBxF.Size = new System.Drawing.Size(120, 20);
			this.castingTimeTBxF.TabIndex = 17;
			// 
			// castingConditionLabel
			// 
			this.castingConditionLabel.AutoSize = true;
			this.castingConditionLabel.Location = new System.Drawing.Point(401, 83);
			this.castingConditionLabel.Name = "castingConditionLabel";
			this.castingConditionLabel.Size = new System.Drawing.Size(92, 13);
			this.castingConditionLabel.TabIndex = 20;
			this.castingConditionLabel.Text = "Casting Condition:";
			// 
			// castingConditionTBxF
			// 
			this.castingConditionTBxF.Location = new System.Drawing.Point(499, 80);
			this.castingConditionTBxF.Multiline = true;
			this.castingConditionTBxF.Name = "castingConditionTBxF";
			this.castingConditionTBxF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.castingConditionTBxF.Size = new System.Drawing.Size(266, 40);
			this.castingConditionTBxF.TabIndex = 21;
			this.castingConditionTBxF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBxF_KeyDown);
			// 
			// reactionChBx
			// 
			this.reactionChBx.AutoSize = true;
			this.reactionChBx.Location = new System.Drawing.Point(296, 103);
			this.reactionChBx.Name = "reactionChBx";
			this.reactionChBx.Size = new System.Drawing.Size(69, 17);
			this.reactionChBx.TabIndex = 19;
			this.reactionChBx.Text = "Reaction";
			this.reactionChBx.UseVisualStyleBackColor = true;
			// 
			// swiftChBx
			// 
			this.swiftChBx.AutoSize = true;
			this.swiftChBx.Location = new System.Drawing.Point(222, 103);
			this.swiftChBx.Name = "swiftChBx";
			this.swiftChBx.Size = new System.Drawing.Size(49, 17);
			this.swiftChBx.TabIndex = 18;
			this.swiftChBx.Text = "Swift";
			this.swiftChBx.UseVisualStyleBackColor = true;
			// 
			// spellDescriptionLabel
			// 
			this.spellDescriptionLabel.AutoSize = true;
			this.spellDescriptionLabel.Location = new System.Drawing.Point(183, 131);
			this.spellDescriptionLabel.Name = "spellDescriptionLabel";
			this.spellDescriptionLabel.Size = new System.Drawing.Size(89, 13);
			this.spellDescriptionLabel.TabIndex = 22;
			this.spellDescriptionLabel.Text = "Spell Description:";
			// 
			// spellDescriptionTBxF
			// 
			this.spellDescriptionTBxF.AcceptsReturn = true;
			this.spellDescriptionTBxF.Location = new System.Drawing.Point(186, 149);
			this.spellDescriptionTBxF.Multiline = true;
			this.spellDescriptionTBxF.Name = "spellDescriptionTBxF";
			this.spellDescriptionTBxF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.spellDescriptionTBxF.Size = new System.Drawing.Size(579, 140);
			this.spellDescriptionTBxF.TabIndex = 23;
			this.spellDescriptionTBxF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBxF_KeyDown);
			// 
			// higherLevelsLabel
			// 
			this.higherLevelsLabel.AutoSize = true;
			this.higherLevelsLabel.Enabled = false;
			this.higherLevelsLabel.Location = new System.Drawing.Point(183, 296);
			this.higherLevelsLabel.Name = "higherLevelsLabel";
			this.higherLevelsLabel.Size = new System.Drawing.Size(88, 13);
			this.higherLevelsLabel.TabIndex = 24;
			this.higherLevelsLabel.Text = "At Higher Levels:";
			// 
			// higherLevelsTBxF
			// 
			this.higherLevelsTBxF.AcceptsReturn = true;
			this.higherLevelsTBxF.Enabled = false;
			this.higherLevelsTBxF.Location = new System.Drawing.Point(186, 312);
			this.higherLevelsTBxF.Multiline = true;
			this.higherLevelsTBxF.Name = "higherLevelsTBxF";
			this.higherLevelsTBxF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.higherLevelsTBxF.Size = new System.Drawing.Size(582, 60);
			this.higherLevelsTBxF.TabIndex = 26;
			this.higherLevelsTBxF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBxF_KeyDown);
			// 
			// scaleableChBx
			// 
			this.scaleableChBx.AutoSize = true;
			this.scaleableChBx.Location = new System.Drawing.Point(292, 295);
			this.scaleableChBx.Name = "scaleableChBx";
			this.scaleableChBx.Size = new System.Drawing.Size(73, 17);
			this.scaleableChBx.TabIndex = 25;
			this.scaleableChBx.Text = "Scaleable";
			this.scaleableChBx.UseVisualStyleBackColor = true;
			this.scaleableChBx.CheckedChanged += new System.EventHandler(this.scaleableChBx_CheckedChanged);
			// 
			// damageTypeChLBx
			// 
			this.damageTypeChLBx.BackColor = System.Drawing.SystemColors.Control;
			this.damageTypeChLBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.damageTypeChLBx.CheckOnClick = true;
			this.damageTypeChLBx.ColumnWidth = 70;
			this.damageTypeChLBx.FormattingEnabled = true;
			this.damageTypeChLBx.Items.AddRange(new object[] {
            "Fire",
            "Cold",
            "Lightning",
            "Thunder",
            "Acid",
            "Radiant",
            "Necrotic",
            "Force"});
			this.damageTypeChLBx.Location = new System.Drawing.Point(186, 398);
			this.damageTypeChLBx.MultiColumn = true;
			this.damageTypeChLBx.Name = "damageTypeChLBx";
			this.damageTypeChLBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.damageTypeChLBx.Size = new System.Drawing.Size(144, 60);
			this.damageTypeChLBx.TabIndex = 28;
			this.damageTypeChLBx.ThreeDCheckBoxes = true;
			this.damageTypeChLBx.Enter += new System.EventHandler(this.chLBx_Enter);
			this.damageTypeChLBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chLBxTabOverride_KeyDown);
			this.damageTypeChLBx.Leave += new System.EventHandler(this.chLBx_Leave);
			this.damageTypeChLBx.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.chLBxTabOverride_PreviewKeyDown);
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
			this.targetabilityChLBx.Location = new System.Drawing.Point(336, 398);
			this.targetabilityChLBx.Name = "targetabilityChLBx";
			this.targetabilityChLBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.targetabilityChLBx.Size = new System.Drawing.Size(89, 60);
			this.targetabilityChLBx.TabIndex = 30;
			this.targetabilityChLBx.ThreeDCheckBoxes = true;
			this.targetabilityChLBx.Enter += new System.EventHandler(this.chLBx_Enter);
			this.targetabilityChLBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chLBxTabOverride_KeyDown);
			this.targetabilityChLBx.Leave += new System.EventHandler(this.chLBx_Leave);
			this.targetabilityChLBx.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.chLBxTabOverride_PreviewKeyDown);
			// 
			// damageTypesLabel
			// 
			this.damageTypesLabel.AutoSize = true;
			this.damageTypesLabel.Location = new System.Drawing.Point(183, 382);
			this.damageTypesLabel.Name = "damageTypesLabel";
			this.damageTypesLabel.Size = new System.Drawing.Size(82, 13);
			this.damageTypesLabel.TabIndex = 27;
			this.damageTypesLabel.Text = "Damage Types:";
			// 
			// targetabilityLabel
			// 
			this.targetabilityLabel.AutoSize = true;
			this.targetabilityLabel.Location = new System.Drawing.Point(333, 382);
			this.targetabilityLabel.Name = "targetabilityLabel";
			this.targetabilityLabel.Size = new System.Drawing.Size(67, 13);
			this.targetabilityLabel.TabIndex = 29;
			this.targetabilityLabel.Text = "Targetability:";
			// 
			// addTagsLabel
			// 
			this.addTagsLabel.AutoSize = true;
			this.addTagsLabel.Location = new System.Drawing.Point(433, 382);
			this.addTagsLabel.Name = "addTagsLabel";
			this.addTagsLabel.Size = new System.Drawing.Size(83, 13);
			this.addTagsLabel.TabIndex = 31;
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
			this.addTagsChLBx.Location = new System.Drawing.Point(436, 398);
			this.addTagsChLBx.Name = "addTagsChLBx";
			this.addTagsChLBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.addTagsChLBx.Size = new System.Drawing.Size(89, 75);
			this.addTagsChLBx.TabIndex = 32;
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
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(533, 382);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.HotTrack;
			this.splitContainer1.Panel1.Controls.Add(this.label3);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2Collapsed = true;
			this.splitContainer1.Size = new System.Drawing.Size(150, 100);
			this.splitContainer1.SplitterDistance = 100;
			this.splitContainer1.TabIndex = 33;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 13);
			this.label3.TabIndex = 36;
			this.label3.Text = "ID:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(93, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 35;
			this.label1.Text = "hide ME";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 13);
			this.label2.TabIndex = 36;
			this.label2.Text = "ID:";
			// 
			// saveSpellBtn
			// 
			this.saveSpellBtn.Location = new System.Drawing.Point(689, 382);
			this.saveSpellBtn.Name = "saveSpellBtn";
			this.saveSpellBtn.Size = new System.Drawing.Size(75, 23);
			this.saveSpellBtn.TabIndex = 34;
			this.saveSpellBtn.Text = "Save Spell";
			this.saveSpellBtn.UseVisualStyleBackColor = true;
			this.saveSpellBtn.Click += new System.EventHandler(this.saveSpellBtn_Click);
			// 
			// SpellEntryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(779, 497);
			this.Controls.Add(this.saveSpellBtn);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.materialCostTBxF);
			this.Controls.Add(this.materialCostLabel);
			this.Controls.Add(this.componentChLBx);
			this.Controls.Add(this.addTagsLabel);
			this.Controls.Add(this.addTagsChLBx);
			this.Controls.Add(this.targetabilityLabel);
			this.Controls.Add(this.damageTypesLabel);
			this.Controls.Add(this.targetabilityChLBx);
			this.Controls.Add(this.damageTypeChLBx);
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
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
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
		private System.Windows.Forms.CheckedListBox damageTypeChLBx;
		private System.Windows.Forms.CheckedListBox targetabilityChLBx;
		private System.Windows.Forms.Label damageTypesLabel;
		private System.Windows.Forms.Label targetabilityLabel;
		private System.Windows.Forms.Label addTagsLabel;
		private System.Windows.Forms.CheckedListBox addTagsChLBx;
		private System.Windows.Forms.CheckedListBox componentChLBx;
		private System.Windows.Forms.TextBox materialCostTBxF;
		private System.Windows.Forms.Label materialCostLabel;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button saveSpellBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}