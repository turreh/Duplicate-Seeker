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
            this.lblFolderPrompt = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFolderPrompt
            // 
            this.lblFolderPrompt.AutoSize = true;
            this.lblFolderPrompt.Location = new System.Drawing.Point(12, 21);
            this.lblFolderPrompt.Name = "lblFolderPrompt";
            this.lblFolderPrompt.Size = new System.Drawing.Size(76, 13);
            this.lblFolderPrompt.TabIndex = 0;
            this.lblFolderPrompt.Text = "Directory path:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(95, 21);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(177, 20);
            this.txtPath.TabIndex = 1;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(73, 58);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(161, 23);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "&Scan for Duplicate Pictures";
            this.btnScan.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(119, 87);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 121);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblFolderPrompt);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Duplicate Image Seeker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFolderPrompt;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnExit;
    }
}

