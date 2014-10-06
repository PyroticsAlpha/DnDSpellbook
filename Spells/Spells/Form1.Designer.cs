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
			this.resultsSpellDGV = new System.Windows.Forms.DataGridView();
			this.sbLoadBtn = new System.Windows.Forms.Button();
			this.sbCloseBtn = new System.Windows.Forms.Button();
			this.resultsDataSet = new System.Data.DataSet();
			this.sbSpellBookList = new System.Windows.Forms.ComboBox();
			this.resultsSpellListView = new System.Windows.Forms.ListBox();
			this.resultsSpellDetails = new System.Windows.Forms.TextBox();
			this.sbGroupBox = new System.Windows.Forms.GroupBox();
			this.sbExportBtn = new System.Windows.Forms.Button();
			this.sbCreateBtn = new System.Windows.Forms.Button();
			this.srchGroupBox = new System.Windows.Forms.GroupBox();
			this.srchSearchBox = new System.Windows.Forms.TextBox();
			this.srchSchoolPanel = new System.Windows.Forms.Panel();
			this.srchSchoolAllBox = new System.Windows.Forms.CheckBox();
			this.srchSchoolLabel = new System.Windows.Forms.Label();
			this.srchSchoolChecklist = new System.Windows.Forms.CheckedListBox();
			this.srchLevelsPanel = new System.Windows.Forms.Panel();
			this.srchLevelsChecklist = new System.Windows.Forms.CheckedListBox();
			this.srchLevelsLabel = new System.Windows.Forms.Label();
			this.srchLevelsAllBox = new System.Windows.Forms.CheckBox();
			this.cstmGroupBox = new System.Windows.Forms.GroupBox();
			this.cstmRestoreDefaultsBtn = new System.Windows.Forms.Button();
			this.cstmImportBtn = new System.Windows.Forms.Button();
			this.cstmEditClassesBtn = new System.Windows.Forms.Button();
			this.cstmAddSpellBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.resultsSpellDGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.resultsDataSet)).BeginInit();
			this.sbGroupBox.SuspendLayout();
			this.srchGroupBox.SuspendLayout();
			this.srchSchoolPanel.SuspendLayout();
			this.srchLevelsPanel.SuspendLayout();
			this.cstmGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// resultsSpellDGV
			// 
			this.resultsSpellDGV.AllowUserToAddRows = false;
			this.resultsSpellDGV.AllowUserToDeleteRows = false;
			this.resultsSpellDGV.AllowUserToOrderColumns = true;
			this.resultsSpellDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.resultsSpellDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.resultsSpellDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.resultsSpellDGV.BackgroundColor = System.Drawing.SystemColors.Window;
			this.resultsSpellDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.resultsSpellDGV.GridColor = System.Drawing.SystemColors.Control;
			this.resultsSpellDGV.Location = new System.Drawing.Point(11, 255);
			this.resultsSpellDGV.Margin = new System.Windows.Forms.Padding(2);
			this.resultsSpellDGV.MultiSelect = false;
			this.resultsSpellDGV.Name = "resultsSpellDGV";
			this.resultsSpellDGV.ReadOnly = true;
			this.resultsSpellDGV.RowHeadersVisible = false;
			this.resultsSpellDGV.RowTemplate.Height = 28;
			this.resultsSpellDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.resultsSpellDGV.Size = new System.Drawing.Size(154, 337);
			this.resultsSpellDGV.StandardTab = true;
			this.resultsSpellDGV.TabIndex = 0;
			this.resultsSpellDGV.SelectionChanged += new System.EventHandler(this.resultsSpellDGV_SelectionChanged);
			// 
			// sbLoadBtn
			// 
			this.sbLoadBtn.AutoSize = true;
			this.sbLoadBtn.Location = new System.Drawing.Point(142, 18);
			this.sbLoadBtn.Margin = new System.Windows.Forms.Padding(2);
			this.sbLoadBtn.Name = "sbLoadBtn";
			this.sbLoadBtn.Size = new System.Drawing.Size(74, 23);
			this.sbLoadBtn.TabIndex = 1;
			this.sbLoadBtn.Text = "Load";
			this.sbLoadBtn.UseVisualStyleBackColor = true;
			this.sbLoadBtn.Click += new System.EventHandler(this.sbLoadBtn_Click);
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
			// resultsDataSet
			// 
			this.resultsDataSet.DataSetName = "NewDataSet";
			// 
			// sbSpellBookList
			// 
			this.sbSpellBookList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sbSpellBookList.FormattingEnabled = true;
			this.sbSpellBookList.Location = new System.Drawing.Point(5, 18);
			this.sbSpellBookList.Margin = new System.Windows.Forms.Padding(2);
			this.sbSpellBookList.Name = "sbSpellBookList";
			this.sbSpellBookList.Size = new System.Drawing.Size(133, 21);
			this.sbSpellBookList.TabIndex = 5;
			// 
			// resultsSpellListView
			// 
			this.resultsSpellListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.resultsSpellListView.FormattingEnabled = true;
			this.resultsSpellListView.IntegralHeight = false;
			this.resultsSpellListView.Location = new System.Drawing.Point(696, 255);
			this.resultsSpellListView.Margin = new System.Windows.Forms.Padding(2);
			this.resultsSpellListView.Name = "resultsSpellListView";
			this.resultsSpellListView.Size = new System.Drawing.Size(78, 337);
			this.resultsSpellListView.TabIndex = 6;
			// 
			// resultsSpellDetails
			// 
			this.resultsSpellDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.resultsSpellDetails.Location = new System.Drawing.Point(169, 255);
			this.resultsSpellDetails.Margin = new System.Windows.Forms.Padding(2);
			this.resultsSpellDetails.Multiline = true;
			this.resultsSpellDetails.Name = "resultsSpellDetails";
			this.resultsSpellDetails.ReadOnly = true;
			this.resultsSpellDetails.Size = new System.Drawing.Size(523, 337);
			this.resultsSpellDetails.TabIndex = 8;
			// 
			// sbGroupBox
			// 
			this.sbGroupBox.Controls.Add(this.sbExportBtn);
			this.sbGroupBox.Controls.Add(this.sbCreateBtn);
			this.sbGroupBox.Controls.Add(this.sbCloseBtn);
			this.sbGroupBox.Controls.Add(this.sbSpellBookList);
			this.sbGroupBox.Controls.Add(this.sbLoadBtn);
			this.sbGroupBox.Location = new System.Drawing.Point(12, 12);
			this.sbGroupBox.Name = "sbGroupBox";
			this.sbGroupBox.Size = new System.Drawing.Size(760, 46);
			this.sbGroupBox.TabIndex = 9;
			this.sbGroupBox.TabStop = false;
			this.sbGroupBox.Text = "Spell Books";
			// 
			// sbExportBtn
			// 
			this.sbExportBtn.Location = new System.Drawing.Point(303, 18);
			this.sbExportBtn.Name = "sbExportBtn";
			this.sbExportBtn.Size = new System.Drawing.Size(75, 23);
			this.sbExportBtn.TabIndex = 10;
			this.sbExportBtn.Text = "Export";
			this.sbExportBtn.UseVisualStyleBackColor = true;
			// 
			// sbCreateBtn
			// 
			this.sbCreateBtn.AutoSize = true;
			this.sbCreateBtn.Location = new System.Drawing.Point(221, 18);
			this.sbCreateBtn.Name = "sbCreateBtn";
			this.sbCreateBtn.Size = new System.Drawing.Size(76, 23);
			this.sbCreateBtn.TabIndex = 10;
			this.sbCreateBtn.Text = "Create";
			this.sbCreateBtn.UseVisualStyleBackColor = true;
			// 
			// srchGroupBox
			// 
			this.srchGroupBox.Controls.Add(this.srchSearchBox);
			this.srchGroupBox.Controls.Add(this.srchSchoolPanel);
			this.srchGroupBox.Controls.Add(this.srchLevelsPanel);
			this.srchGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.srchGroupBox.Location = new System.Drawing.Point(12, 116);
			this.srchGroupBox.Name = "srchGroupBox";
			this.srchGroupBox.Size = new System.Drawing.Size(760, 117);
			this.srchGroupBox.TabIndex = 11;
			this.srchGroupBox.TabStop = false;
			this.srchGroupBox.Text = "Search";
			// 
			// srchSearchBox
			// 
			this.srchSearchBox.Location = new System.Drawing.Point(7, 20);
			this.srchSearchBox.Name = "srchSearchBox";
			this.srchSearchBox.Size = new System.Drawing.Size(131, 20);
			this.srchSearchBox.TabIndex = 6;
			// 
			// srchSchoolPanel
			// 
			this.srchSchoolPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.srchSchoolPanel.Controls.Add(this.srchSchoolAllBox);
			this.srchSchoolPanel.Controls.Add(this.srchSchoolLabel);
			this.srchSchoolPanel.Controls.Add(this.srchSchoolChecklist);
			this.srchSchoolPanel.Location = new System.Drawing.Point(557, 11);
			this.srchSchoolPanel.Name = "srchSchoolPanel";
			this.srchSchoolPanel.Size = new System.Drawing.Size(197, 100);
			this.srchSchoolPanel.TabIndex = 5;
			// 
			// srchSchoolAllBox
			// 
			this.srchSchoolAllBox.AutoSize = true;
			this.srchSchoolAllBox.Location = new System.Drawing.Point(99, 3);
			this.srchSchoolAllBox.Name = "srchSchoolAllBox";
			this.srchSchoolAllBox.Size = new System.Drawing.Size(37, 17);
			this.srchSchoolAllBox.TabIndex = 2;
			this.srchSchoolAllBox.Text = "All";
			this.srchSchoolAllBox.UseVisualStyleBackColor = true;
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
			// srchSchoolChecklist
			// 
			this.srchSchoolChecklist.BackColor = System.Drawing.SystemColors.Control;
			this.srchSchoolChecklist.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.srchSchoolChecklist.CheckOnClick = true;
			this.srchSchoolChecklist.ColumnWidth = 95;
			this.srchSchoolChecklist.FormattingEnabled = true;
			this.srchSchoolChecklist.Items.AddRange(new object[] {
            "Abjuration",
            "Conjuration",
            "Divination",
            "Enchantment",
            "Evocation",
            "Illusion",
            "Necromancy",
            "Transmutation"});
			this.srchSchoolChecklist.Location = new System.Drawing.Point(3, 20);
			this.srchSchoolChecklist.MultiColumn = true;
			this.srchSchoolChecklist.Name = "srchSchoolChecklist";
			this.srchSchoolChecklist.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.srchSchoolChecklist.Size = new System.Drawing.Size(199, 60);
			this.srchSchoolChecklist.TabIndex = 0;
			this.srchSchoolChecklist.SelectedIndexChanged += new System.EventHandler(this.searchSchoolChecklist_SelectedIndexChanged);
			// 
			// srchLevelsPanel
			// 
			this.srchLevelsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.srchLevelsPanel.Controls.Add(this.srchLevelsChecklist);
			this.srchLevelsPanel.Controls.Add(this.srchLevelsLabel);
			this.srchLevelsPanel.Controls.Add(this.srchLevelsAllBox);
			this.srchLevelsPanel.Location = new System.Drawing.Point(463, 11);
			this.srchLevelsPanel.Name = "srchLevelsPanel";
			this.srchLevelsPanel.Size = new System.Drawing.Size(88, 100);
			this.srchLevelsPanel.TabIndex = 4;
			// 
			// srchLevelsChecklist
			// 
			this.srchLevelsChecklist.BackColor = System.Drawing.SystemColors.Control;
			this.srchLevelsChecklist.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.srchLevelsChecklist.CheckOnClick = true;
			this.srchLevelsChecklist.ColumnWidth = 40;
			this.srchLevelsChecklist.FormattingEnabled = true;
			this.srchLevelsChecklist.Items.AddRange(new object[] {
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
			this.srchLevelsChecklist.Location = new System.Drawing.Point(3, 20);
			this.srchLevelsChecklist.MultiColumn = true;
			this.srchLevelsChecklist.Name = "srchLevelsChecklist";
			this.srchLevelsChecklist.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.srchLevelsChecklist.Size = new System.Drawing.Size(87, 75);
			this.srchLevelsChecklist.TabIndex = 1;
			this.srchLevelsChecklist.ThreeDCheckBoxes = true;
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
			// cstmGroupBox
			// 
			this.cstmGroupBox.Controls.Add(this.cstmRestoreDefaultsBtn);
			this.cstmGroupBox.Controls.Add(this.cstmImportBtn);
			this.cstmGroupBox.Controls.Add(this.cstmEditClassesBtn);
			this.cstmGroupBox.Controls.Add(this.cstmAddSpellBtn);
			this.cstmGroupBox.Location = new System.Drawing.Point(12, 64);
			this.cstmGroupBox.Name = "cstmGroupBox";
			this.cstmGroupBox.Size = new System.Drawing.Size(760, 46);
			this.cstmGroupBox.TabIndex = 0;
			this.cstmGroupBox.TabStop = false;
			this.cstmGroupBox.Text = "Customize";
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
			this.Controls.Add(this.cstmGroupBox);
			this.Controls.Add(this.srchGroupBox);
			this.Controls.Add(this.sbGroupBox);
			this.Controls.Add(this.resultsSpellDetails);
			this.Controls.Add(this.resultsSpellListView);
			this.Controls.Add(this.resultsSpellDGV);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.resultsSpellDGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.resultsDataSet)).EndInit();
			this.sbGroupBox.ResumeLayout(false);
			this.sbGroupBox.PerformLayout();
			this.srchGroupBox.ResumeLayout(false);
			this.srchGroupBox.PerformLayout();
			this.srchSchoolPanel.ResumeLayout(false);
			this.srchSchoolPanel.PerformLayout();
			this.srchLevelsPanel.ResumeLayout(false);
			this.srchLevelsPanel.PerformLayout();
			this.cstmGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView resultsSpellDGV;
        private System.Windows.Forms.Button sbLoadBtn;
        private System.Windows.Forms.Button sbCloseBtn;
        private System.Data.DataSet resultsDataSet;
        private System.Windows.Forms.ComboBox sbSpellBookList;
        private System.Windows.Forms.ListBox resultsSpellListView;
        private System.Windows.Forms.TextBox resultsSpellDetails;
        private System.Windows.Forms.GroupBox sbGroupBox;
        private System.Windows.Forms.Button sbCreateBtn;
        private System.Windows.Forms.Button sbExportBtn;
        private System.Windows.Forms.GroupBox srchGroupBox;
        private System.Windows.Forms.GroupBox cstmGroupBox;
        private System.Windows.Forms.Button cstmRestoreDefaultsBtn;
        private System.Windows.Forms.Button cstmImportBtn;
        private System.Windows.Forms.Button cstmEditClassesBtn;
        private System.Windows.Forms.Button cstmAddSpellBtn;
        private System.Windows.Forms.CheckedListBox srchLevelsChecklist;
        private System.Windows.Forms.CheckedListBox srchSchoolChecklist;
        private System.Windows.Forms.CheckBox srchLevelsAllBox;
        private System.Windows.Forms.Label srchLevelsLabel;
        private System.Windows.Forms.Panel srchLevelsPanel;
        private System.Windows.Forms.Panel srchSchoolPanel;
        private System.Windows.Forms.CheckBox srchSchoolAllBox;
        private System.Windows.Forms.Label srchSchoolLabel;
        private System.Windows.Forms.TextBox srchSearchBox;
    }
}

