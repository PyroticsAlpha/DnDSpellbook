namespace Spells
{
    partial class CreateBookDialog
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
			this.bookNameLabel = new System.Windows.Forms.Label();
			this.bookNameTBx = new System.Windows.Forms.TextBox();
			this.SaveBtn = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bookNameLabel
			// 
			this.bookNameLabel.AutoSize = true;
			this.bookNameLabel.Location = new System.Drawing.Point(12, 24);
			this.bookNameLabel.Name = "bookNameLabel";
			this.bookNameLabel.Size = new System.Drawing.Size(89, 13);
			this.bookNameLabel.TabIndex = 0;
			this.bookNameLabel.Text = "Spell book name:";
			// 
			// bookNameTBx
			// 
			this.bookNameTBx.Location = new System.Drawing.Point(107, 21);
			this.bookNameTBx.Name = "bookNameTBx";
			this.bookNameTBx.Size = new System.Drawing.Size(219, 20);
			this.bookNameTBx.TabIndex = 1;
			// 
			// SaveBtn
			// 
			this.SaveBtn.Location = new System.Drawing.Point(170, 61);
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new System.Drawing.Size(75, 23);
			this.SaveBtn.TabIndex = 2;
			this.SaveBtn.Text = "Save";
			this.SaveBtn.UseVisualStyleBackColor = true;
			this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// CancelBtn
			// 
			this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelBtn.Location = new System.Drawing.Point(251, 61);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(75, 23);
			this.CancelBtn.TabIndex = 3;
			this.CancelBtn.Text = "Cancel";
			this.CancelBtn.UseVisualStyleBackColor = true;
			// 
			// CreateBookDialog
			// 
			this.AcceptButton = this.SaveBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelBtn;
			this.ClientSize = new System.Drawing.Size(343, 106);
			this.Controls.Add(this.CancelBtn);
			this.Controls.Add(this.SaveBtn);
			this.Controls.Add(this.bookNameTBx);
			this.Controls.Add(this.bookNameLabel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "CreateBookDialog";
			this.Text = "Create New Spell Book";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Label bookNameLabel;
		private System.Windows.Forms.TextBox bookNameTBx;
		private System.Windows.Forms.Button SaveBtn;
		private System.Windows.Forms.Button CancelBtn;

	}
}