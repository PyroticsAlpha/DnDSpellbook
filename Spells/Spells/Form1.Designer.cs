namespace Spells
{
    partial class MainForm
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
			this.rsltsSearchResultsDGV = new System.Windows.Forms.DataGridView();
			this.sbCloseBtn = new System.Windows.Forms.Button();
			this.rsltsDataSet = new System.Data.DataSet();
			this.sbBookNamesCoBx = new System.Windows.Forms.ComboBox();
			this.rsltsDetailsTB = new System.Windows.Forms.TextBox();
			this.sbGB = new System.Windows.Forms.GroupBox();
			this.sbDeleteBtn = new System.Windows.Forms.Button();
			this.sbExportBtn = new System.Windows.Forms.Button();
			this.sbCreateBtn = new System.Windows.Forms.Button();
			this.srchGBx = new System.Windows.Forms.GroupBox();
			this.srchSpellNameTBF = new System.Windows.Forms.TextBox();
			this.srchSchoolPanel = new System.Windows.Forms.Panel();
			this.srchSchoolAllChBx = new System.Windows.Forms.CheckBox();
			this.srchSchoolLabel = new System.Windows.Forms.Label();
			this.srchSchoolChLBx = new System.Windows.Forms.CheckedListBox();
			this.srchLevelsPanel = new System.Windows.Forms.Panel();
			this.srchLevelsChLBx = new System.Windows.Forms.CheckedListBox();
			this.srchLevelsLabel = new System.Windows.Forms.Label();
			this.srchLevelsAllBox = new System.Windows.Forms.CheckBox();
			this.cstmGBx = new System.Windows.Forms.GroupBox();
			this.cstmRestoreDefaultsBtn = new System.Windows.Forms.Button();
			this.cstmImportBtn = new System.Windows.Forms.Button();
			this.cstmEditClassesBtn = new System.Windows.Forms.Button();
			this.cstmAddSpellBtn = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.rsltsSearchResultsDGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rsltsDataSet)).BeginInit();
			this.sbGB.SuspendLayout();
			this.srchGBx.SuspendLayout();
			this.srchSchoolPanel.SuspendLayout();
			this.srchLevelsPanel.SuspendLayout();
			this.cstmGBx.SuspendLayout();
			this.SuspendLayout();
			// 
			// rsltsSearchResultsDGV
			// 
			this.rsltsSearchResultsDGV.AllowUserToAddRows = false;
			this.rsltsSearchResultsDGV.AllowUserToDeleteRows = false;
			this.rsltsSearchResultsDGV.AllowUserToOrderColumns = true;
			this.rsltsSearchResultsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.rsltsSearchResultsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.rsltsSearchResultsDGV.BackgroundColor = System.Drawing.SystemColors.Window;
			this.rsltsSearchResultsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.rsltsSearchResultsDGV.GridColor = System.Drawing.SystemColors.Control;
			this.rsltsSearchResultsDGV.Location = new System.Drawing.Point(11, 255);
			this.rsltsSearchResultsDGV.Margin = new System.Windows.Forms.Padding(2);
			this.rsltsSearchResultsDGV.MultiSelect = false;
			this.rsltsSearchResultsDGV.Name = "rsltsSearchResultsDGV";
			this.rsltsSearchResultsDGV.ReadOnly = true;
			this.rsltsSearchResultsDGV.RowHeadersVisible = false;
			this.rsltsSearchResultsDGV.RowTemplate.Height = 28;
			this.rsltsSearchResultsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.rsltsSearchResultsDGV.Size = new System.Drawing.Size(188, 337);
			this.rsltsSearchResultsDGV.StandardTab = true;
			this.rsltsSearchResultsDGV.TabIndex = 0;
			this.rsltsSearchResultsDGV.SelectionChanged += new System.EventHandler(this.rsltsSearchResultsDGV_SelectionChanged);
			// 
			// sbCloseBtn
			// 
			this.sbCloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.sbCloseBtn.AutoSize = true;
			this.sbCloseBtn.Location = new System.Drawing.Point(700, 18);
			this.sbCloseBtn.Margin = new System.Windows.Forms.Padding(2);
			this.sbCloseBtn.Name = "sbCloseBtn";
			this.sbCloseBtn.Size = new System.Drawing.Size(55, 23);
			this.sbCloseBtn.TabIndex = 2;
			this.sbCloseBtn.Text = "Close";
			this.sbCloseBtn.UseVisualStyleBackColor = true;
			this.sbCloseBtn.Click += new System.EventHandler(this.sbCloseBtn_Click);
			// 
			// rsltsDataSet
			// 
			this.rsltsDataSet.DataSetName = "NewDataSet";
			// 
			// sbBookNamesCoBx
			// 
			this.sbBookNamesCoBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sbBookNamesCoBx.FormattingEnabled = true;
			this.sbBookNamesCoBx.Location = new System.Drawing.Point(5, 18);
			this.sbBookNamesCoBx.Margin = new System.Windows.Forms.Padding(2);
			this.sbBookNamesCoBx.Name = "sbBookNamesCoBx";
			this.sbBookNamesCoBx.Size = new System.Drawing.Size(133, 21);
			this.sbBookNamesCoBx.TabIndex = 5;
			this.sbBookNamesCoBx.SelectedIndexChanged += new System.EventHandler(this.sbBookNamesCoBx_SelectedIndexChanged);
			// 
			// rsltsDetailsTB
			// 
			this.rsltsDetailsTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rsltsDetailsTB.Location = new System.Drawing.Point(203, 255);
			this.rsltsDetailsTB.Margin = new System.Windows.Forms.Padding(2);
			this.rsltsDetailsTB.Multiline = true;
			this.rsltsDetailsTB.Name = "rsltsDetailsTB";
			this.rsltsDetailsTB.ReadOnly = true;
			this.rsltsDetailsTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.rsltsDetailsTB.Size = new System.Drawing.Size(569, 337);
			this.rsltsDetailsTB.TabIndex = 8;
			// 
			// sbGB
			// 
			this.sbGB.Controls.Add(this.sbDeleteBtn);
			this.sbGB.Controls.Add(this.sbExportBtn);
			this.sbGB.Controls.Add(this.sbCreateBtn);
			this.sbGB.Controls.Add(this.sbCloseBtn);
			this.sbGB.Controls.Add(this.sbBookNamesCoBx);
			this.sbGB.Location = new System.Drawing.Point(12, 12);
			this.sbGB.Name = "sbGB";
			this.sbGB.Size = new System.Drawing.Size(760, 46);
			this.sbGB.TabIndex = 9;
			this.sbGB.TabStop = false;
			this.sbGB.Text = "Spell Books";
			// 
			// sbDeleteBtn
			// 
			this.sbDeleteBtn.AutoSize = true;
			this.sbDeleteBtn.Location = new System.Drawing.Point(306, 17);
			this.sbDeleteBtn.Name = "sbDeleteBtn";
			this.sbDeleteBtn.Size = new System.Drawing.Size(76, 23);
			this.sbDeleteBtn.TabIndex = 11;
			this.sbDeleteBtn.Text = "Delete";
			this.sbDeleteBtn.UseVisualStyleBackColor = true;
			this.sbDeleteBtn.Click += new System.EventHandler(this.sbDeleteBtn_Click);
			// 
			// sbExportBtn
			// 
			this.sbExportBtn.Location = new System.Drawing.Point(225, 17);
			this.sbExportBtn.Name = "sbExportBtn";
			this.sbExportBtn.Size = new System.Drawing.Size(75, 23);
			this.sbExportBtn.TabIndex = 10;
			this.sbExportBtn.Text = "Export";
			this.sbExportBtn.UseVisualStyleBackColor = true;
			// 
			// sbCreateBtn
			// 
			this.sbCreateBtn.AutoSize = true;
			this.sbCreateBtn.Location = new System.Drawing.Point(143, 17);
			this.sbCreateBtn.Name = "sbCreateBtn";
			this.sbCreateBtn.Size = new System.Drawing.Size(76, 23);
			this.sbCreateBtn.TabIndex = 10;
			this.sbCreateBtn.Text = "Create";
			this.sbCreateBtn.UseVisualStyleBackColor = true;
			this.sbCreateBtn.Click += new System.EventHandler(this.sbCreateBtn_Click);
			// 
			// srchGBx
			// 
			this.srchGBx.Controls.Add(this.srchSpellNameTBF);
			this.srchGBx.Controls.Add(this.srchSchoolPanel);
			this.srchGBx.Controls.Add(this.srchLevelsPanel);
			this.srchGBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.srchGBx.Location = new System.Drawing.Point(12, 116);
			this.srchGBx.Name = "srchGBx";
			this.srchGBx.Size = new System.Drawing.Size(760, 117);
			this.srchGBx.TabIndex = 11;
			this.srchGBx.TabStop = false;
			this.srchGBx.Text = "Search";
			// 
			// srchSpellNameTBF
			// 
			this.srchSpellNameTBF.Location = new System.Drawing.Point(7, 20);
			this.srchSpellNameTBF.Name = "srchSpellNameTBF";
			this.srchSpellNameTBF.Size = new System.Drawing.Size(131, 20);
			this.srchSpellNameTBF.TabIndex = 6;
			// 
			// srchSchoolPanel
			// 
			this.srchSchoolPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.srchSchoolPanel.Controls.Add(this.srchSchoolAllChBx);
			this.srchSchoolPanel.Controls.Add(this.srchSchoolLabel);
			this.srchSchoolPanel.Controls.Add(this.srchSchoolChLBx);
			this.srchSchoolPanel.Location = new System.Drawing.Point(557, 11);
			this.srchSchoolPanel.Name = "srchSchoolPanel";
			this.srchSchoolPanel.Size = new System.Drawing.Size(197, 100);
			this.srchSchoolPanel.TabIndex = 5;
			// 
			// srchSchoolAllChBx
			// 
			this.srchSchoolAllChBx.AutoSize = true;
			this.srchSchoolAllChBx.Location = new System.Drawing.Point(99, 3);
			this.srchSchoolAllChBx.Name = "srchSchoolAllChBx";
			this.srchSchoolAllChBx.Size = new System.Drawing.Size(37, 17);
			this.srchSchoolAllChBx.TabIndex = 2;
			this.srchSchoolAllChBx.Text = "All";
			this.srchSchoolAllChBx.UseVisualStyleBackColor = true;
			// 
			// srchSchoolLabel
			// 
			this.srchSchoolLabel.AutoSize = true;
			this.srchSchoolLabel.Location = new System.Drawing.Point(3, 4);
			this.srchSchoolLabel.Name = "srchSchoolLabel";
			this.srchSchoolLabel.Size = new System.Drawing.Size(71, 13);
			this.srchSchoolLabel.TabIndex = 1;
			this.srchSchoolLabel.Text = "Spell Schools";
			// 
			// srchSchoolChLBx
			// 
			this.srchSchoolChLBx.BackColor = System.Drawing.SystemColors.Control;
			this.srchSchoolChLBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.srchSchoolChLBx.CheckOnClick = true;
			this.srchSchoolChLBx.ColumnWidth = 95;
			this.srchSchoolChLBx.FormattingEnabled = true;
			this.srchSchoolChLBx.Items.AddRange(new object[] {
            "Abjuration",
            "Conjuration",
            "Divination",
            "Enchantment",
            "Evocation",
            "Illusion",
            "Necromancy",
            "Transmutation"});
			this.srchSchoolChLBx.Location = new System.Drawing.Point(3, 20);
			this.srchSchoolChLBx.MultiColumn = true;
			this.srchSchoolChLBx.Name = "srchSchoolChLBx";
			this.srchSchoolChLBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.srchSchoolChLBx.Size = new System.Drawing.Size(199, 60);
			this.srchSchoolChLBx.TabIndex = 0;
			// 
			// srchLevelsPanel
			// 
			this.srchLevelsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.srchLevelsPanel.Controls.Add(this.srchLevelsChLBx);
			this.srchLevelsPanel.Controls.Add(this.srchLevelsLabel);
			this.srchLevelsPanel.Controls.Add(this.srchLevelsAllBox);
			this.srchLevelsPanel.Location = new System.Drawing.Point(463, 11);
			this.srchLevelsPanel.Name = "srchLevelsPanel";
			this.srchLevelsPanel.Size = new System.Drawing.Size(88, 100);
			this.srchLevelsPanel.TabIndex = 4;
			// 
			// srchLevelsChLBx
			// 
			this.srchLevelsChLBx.BackColor = System.Drawing.SystemColors.Control;
			this.srchLevelsChLBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.srchLevelsChLBx.CheckOnClick = true;
			this.srchLevelsChLBx.ColumnWidth = 40;
			this.srchLevelsChLBx.FormattingEnabled = true;
			this.srchLevelsChLBx.Items.AddRange(new object[] {
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
			this.srchLevelsChLBx.Location = new System.Drawing.Point(3, 20);
			this.srchLevelsChLBx.MultiColumn = true;
			this.srchLevelsChLBx.Name = "srchLevelsChLBx";
			this.srchLevelsChLBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.srchLevelsChLBx.Size = new System.Drawing.Size(87, 75);
			this.srchLevelsChLBx.TabIndex = 1;
			this.srchLevelsChLBx.ThreeDCheckBoxes = true;
			// 
			// srchLevelsLabel
			// 
			this.srchLevelsLabel.AutoSize = true;
			this.srchLevelsLabel.Location = new System.Drawing.Point(0, 4);
			this.srchLevelsLabel.Name = "srchLevelsLabel";
			this.srchLevelsLabel.Size = new System.Drawing.Size(38, 13);
			this.srchLevelsLabel.TabIndex = 3;
			this.srchLevelsLabel.Text = "Levels";
			// 
			// srchLevelsAllBox
			// 
			this.srchLevelsAllBox.AutoSize = true;
			this.srchLevelsAllBox.Location = new System.Drawing.Point(44, 3);
			this.srchLevelsAllBox.Name = "srchLevelsAllBox";
			this.srchLevelsAllBox.Size = new System.Drawing.Size(37, 17);
			this.srchLevelsAllBox.TabIndex = 2;
			this.srchLevelsAllBox.Text = "All";
			this.srchLevelsAllBox.UseVisualStyleBackColor = true;
			// 
			// cstmGBx
			// 
			this.cstmGBx.Controls.Add(this.cstmRestoreDefaultsBtn);
			this.cstmGBx.Controls.Add(this.cstmImportBtn);
			this.cstmGBx.Controls.Add(this.cstmEditClassesBtn);
			this.cstmGBx.Controls.Add(this.cstmAddSpellBtn);
			this.cstmGBx.Location = new System.Drawing.Point(12, 64);
			this.cstmGBx.Name = "cstmGBx";
			this.cstmGBx.Size = new System.Drawing.Size(760, 46);
			this.cstmGBx.TabIndex = 0;
			this.cstmGBx.TabStop = false;
			this.cstmGBx.Text = "Customize";
			// 
			// cstmRestoreDefaultsBtn
			// 
			this.cstmRestoreDefaultsBtn.Location = new System.Drawing.Point(323, 17);
			this.cstmRestoreDefaultsBtn.Name = "cstmRestoreDefaultsBtn";
			this.cstmRestoreDefaultsBtn.Size = new System.Drawing.Size(126, 23);
			this.cstmRestoreDefaultsBtn.TabIndex = 13;
			this.cstmRestoreDefaultsBtn.Text = "Restore Defaults";
			this.cstmRestoreDefaultsBtn.UseVisualStyleBackColor = true;
			// 
			// cstmImportBtn
			// 
			this.cstmImportBtn.Location = new System.Drawing.Point(242, 17);
			this.cstmImportBtn.Name = "cstmImportBtn";
			this.cstmImportBtn.Size = new System.Drawing.Size(75, 23);
			this.cstmImportBtn.TabIndex = 0;
			this.cstmImportBtn.Text = "Import";
			this.cstmImportBtn.UseVisualStyleBackColor = true;
			this.cstmImportBtn.Click += new System.EventHandler(this.cstmImportBtn_Click);
			// 
			// cstmEditClassesBtn
			// 
			this.cstmEditClassesBtn.Location = new System.Drawing.Point(106, 17);
			this.cstmEditClassesBtn.Name = "cstmEditClassesBtn";
			this.cstmEditClassesBtn.Size = new System.Drawing.Size(130, 23);
			this.cstmEditClassesBtn.TabIndex = 12;
			this.cstmEditClassesBtn.Text = "Add/Edit Classes";
			this.cstmEditClassesBtn.UseVisualStyleBackColor = true;
			// 
			// cstmAddSpellBtn
			// 
			this.cstmAddSpellBtn.Location = new System.Drawing.Point(5, 17);
			this.cstmAddSpellBtn.Name = "cstmAddSpellBtn";
			this.cstmAddSpellBtn.Size = new System.Drawing.Size(95, 23);
			this.cstmAddSpellBtn.TabIndex = 11;
			this.cstmAddSpellBtn.Text = "Add Spell";
			this.cstmAddSpellBtn.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(784, 603);
			this.Controls.Add(this.cstmGBx);
			this.Controls.Add(this.srchGBx);
			this.Controls.Add(this.sbGB);
			this.Controls.Add(this.rsltsDetailsTB);
			this.Controls.Add(this.rsltsSearchResultsDGV);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "MainForm";
			this.Text = "DnD Spell Book Database";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.rsltsSearchResultsDGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rsltsDataSet)).EndInit();
			this.sbGB.ResumeLayout(false);
			this.sbGB.PerformLayout();
			this.srchGBx.ResumeLayout(false);
			this.srchGBx.PerformLayout();
			this.srchSchoolPanel.ResumeLayout(false);
			this.srchSchoolPanel.PerformLayout();
			this.srchLevelsPanel.ResumeLayout(false);
			this.srchLevelsPanel.PerformLayout();
			this.cstmGBx.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rsltsSearchResultsDGV;
        private System.Windows.Forms.Button sbCloseBtn;
        private System.Data.DataSet rsltsDataSet;
		private System.Windows.Forms.ComboBox sbBookNamesCoBx;
        private System.Windows.Forms.TextBox rsltsDetailsTB;
        private System.Windows.Forms.GroupBox sbGB;
        private System.Windows.Forms.Button sbCreateBtn;
        private System.Windows.Forms.Button sbExportBtn;
        private System.Windows.Forms.GroupBox srchGBx;
        private System.Windows.Forms.GroupBox cstmGBx;
        private System.Windows.Forms.Button cstmRestoreDefaultsBtn;
        private System.Windows.Forms.Button cstmImportBtn;
        private System.Windows.Forms.Button cstmEditClassesBtn;
        private System.Windows.Forms.Button cstmAddSpellBtn;
        private System.Windows.Forms.CheckedListBox srchLevelsChLBx;
        private System.Windows.Forms.CheckedListBox srchSchoolChLBx;
        private System.Windows.Forms.CheckBox srchLevelsAllBox;
        private System.Windows.Forms.Label srchLevelsLabel;
        private System.Windows.Forms.Panel srchLevelsPanel;
        private System.Windows.Forms.Panel srchSchoolPanel;
        private System.Windows.Forms.CheckBox srchSchoolAllChBx;
        private System.Windows.Forms.Label srchSchoolLabel;
		private System.Windows.Forms.TextBox srchSpellNameTBF;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button sbDeleteBtn;
    }
}

