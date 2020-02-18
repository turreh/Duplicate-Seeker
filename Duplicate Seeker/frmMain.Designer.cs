namespace Duplicate_Seeker
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkWarningEnabled = new System.Windows.Forms.CheckBox();
            this.radNameScan = new System.Windows.Forms.RadioButton();
            this.radImageScan = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFolderPrompt = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.lstDupeOccurences = new System.Windows.Forms.ListBox();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.btnIgnore = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstDuplicates = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // chkWarningEnabled
            // 
            this.chkWarningEnabled.AutoSize = true;
            this.chkWarningEnabled.Location = new System.Drawing.Point(656, 72);
            this.chkWarningEnabled.Name = "chkWarningEnabled";
            this.chkWarningEnabled.Size = new System.Drawing.Size(142, 17);
            this.chkWarningEnabled.TabIndex = 19;
            this.chkWarningEnabled.Text = "Warn me before deleting";
            this.toolTip1.SetToolTip(this.chkWarningEnabled, "Displays a confirmation message when an image is about to be deleted.");
            this.chkWarningEnabled.UseVisualStyleBackColor = true;
            // 
            // radNameScan
            // 
            this.radNameScan.AutoSize = true;
            this.radNameScan.Checked = true;
            this.radNameScan.Location = new System.Drawing.Point(292, 27);
            this.radNameScan.Name = "radNameScan";
            this.radNameScan.Size = new System.Drawing.Size(81, 17);
            this.radNameScan.TabIndex = 20;
            this.radNameScan.TabStop = true;
            this.radNameScan.Text = "Name Scan";
            this.toolTip1.SetToolTip(this.radNameScan, "Searches for name duplicates rather than by image.");
            this.radNameScan.UseVisualStyleBackColor = true;
            // 
            // radImageScan
            // 
            this.radImageScan.AutoSize = true;
            this.radImageScan.Location = new System.Drawing.Point(292, 51);
            this.radImageScan.Name = "radImageScan";
            this.radImageScan.Size = new System.Drawing.Size(82, 17);
            this.radImageScan.TabIndex = 21;
            this.radImageScan.Text = "Image Scan";
            this.toolTip1.SetToolTip(this.radImageScan, "Scans images to detect duplicates.");
            this.radImageScan.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // lblFolderPrompt
            // 
            this.lblFolderPrompt.AutoSize = true;
            this.lblFolderPrompt.Location = new System.Drawing.Point(13, 27);
            this.lblFolderPrompt.Name = "lblFolderPrompt";
            this.lblFolderPrompt.Size = new System.Drawing.Size(76, 13);
            this.lblFolderPrompt.TabIndex = 10;
            this.lblFolderPrompt.Text = "Directory path:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(96, 27);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(177, 20);
            this.txtPath.TabIndex = 11;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(74, 64);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(161, 23);
            this.btnScan.TabIndex = 12;
            this.btnScan.Text = "&Scan for Duplicate Pictures";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lstDupeOccurences
            // 
            this.lstDupeOccurences.FormattingEnabled = true;
            this.lstDupeOccurences.Location = new System.Drawing.Point(16, 103);
            this.lstDupeOccurences.Name = "lstDupeOccurences";
            this.lstDupeOccurences.Size = new System.Drawing.Size(126, 303);
            this.lstDupeOccurences.TabIndex = 14;
            // 
            // picImg
            // 
            this.picImg.Location = new System.Drawing.Point(322, 103);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(530, 303);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImg.TabIndex = 15;
            this.picImg.TabStop = false;
            // 
            // btnIgnore
            // 
            this.btnIgnore.Location = new System.Drawing.Point(480, 62);
            this.btnIgnore.Name = "btnIgnore";
            this.btnIgnore.Size = new System.Drawing.Size(75, 35);
            this.btnIgnore.TabIndex = 17;
            this.btnIgnore.Text = "Ignor&e";
            this.btnIgnore.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(561, 62);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 35);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lstDuplicates
            // 
            this.lstDuplicates.FormattingEnabled = true;
            this.lstDuplicates.Location = new System.Drawing.Point(148, 103);
            this.lstDuplicates.Name = "lstDuplicates";
            this.lstDuplicates.Size = new System.Drawing.Size(168, 303);
            this.lstDuplicates.TabIndex = 22;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 417);
            this.Controls.Add(this.lstDuplicates);
            this.Controls.Add(this.radImageScan);
            this.Controls.Add(this.radNameScan);
            this.Controls.Add(this.chkWarningEnabled);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnIgnore);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblFolderPrompt);
            this.Controls.Add(this.picImg);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.lstDupeOccurences);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Duplicate Image Seeker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblFolderPrompt;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ListBox lstDupeOccurences;
        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.Button btnIgnore;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkWarningEnabled;
        private System.Windows.Forms.RadioButton radNameScan;
        private System.Windows.Forms.RadioButton radImageScan;
        private System.Windows.Forms.ListBox lstDuplicates;
    }
}

