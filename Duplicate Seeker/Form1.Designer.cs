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
            this.lblFolderPrompt = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstDupeOccurences = new System.Windows.Forms.ListBox();
            this.picDupe1 = new System.Windows.Forms.PictureBox();
            this.picDupe2 = new System.Windows.Forms.PictureBox();
            this.btnIgnore = new System.Windows.Forms.Button();
            this.btnDeleteTop = new System.Windows.Forms.Button();
            this.btnDeleteBottom = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picDupe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDupe2)).BeginInit();
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
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(119, 87);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstDupeOccurences
            // 
            this.lstDupeOccurences.FormattingEnabled = true;
            this.lstDupeOccurences.Location = new System.Drawing.Point(15, 135);
            this.lstDupeOccurences.Name = "lstDupeOccurences";
            this.lstDupeOccurences.Size = new System.Drawing.Size(257, 303);
            this.lstDupeOccurences.TabIndex = 4;
            // 
            // picDupe1
            // 
            this.picDupe1.Location = new System.Drawing.Point(330, 21);
            this.picDupe1.Name = "picDupe1";
            this.picDupe1.Size = new System.Drawing.Size(451, 185);
            this.picDupe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDupe1.TabIndex = 5;
            this.picDupe1.TabStop = false;
            // 
            // picDupe2
            // 
            this.picDupe2.Location = new System.Drawing.Point(330, 254);
            this.picDupe2.Name = "picDupe2";
            this.picDupe2.Size = new System.Drawing.Size(451, 185);
            this.picDupe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDupe2.TabIndex = 6;
            this.picDupe2.TabStop = false;
            // 
            // btnIgnore
            // 
            this.btnIgnore.Location = new System.Drawing.Point(452, 212);
            this.btnIgnore.Name = "btnIgnore";
            this.btnIgnore.Size = new System.Drawing.Size(75, 35);
            this.btnIgnore.TabIndex = 7;
            this.btnIgnore.Text = "Ignore";
            this.btnIgnore.UseVisualStyleBackColor = true;
            this.btnIgnore.Click += new System.EventHandler(this.btnIgnore_Click);
            // 
            // btnDeleteTop
            // 
            this.btnDeleteTop.Location = new System.Drawing.Point(533, 212);
            this.btnDeleteTop.Name = "btnDeleteTop";
            this.btnDeleteTop.Size = new System.Drawing.Size(75, 35);
            this.btnDeleteTop.TabIndex = 8;
            this.btnDeleteTop.Text = "Delete Top";
            this.btnDeleteTop.UseVisualStyleBackColor = true;
            this.btnDeleteTop.Click += new System.EventHandler(this.btnDeleteTop_Click);
            // 
            // btnDeleteBottom
            // 
            this.btnDeleteBottom.Location = new System.Drawing.Point(614, 212);
            this.btnDeleteBottom.Name = "btnDeleteBottom";
            this.btnDeleteBottom.Size = new System.Drawing.Size(75, 35);
            this.btnDeleteBottom.TabIndex = 9;
            this.btnDeleteBottom.Text = "Delete Bottom";
            this.btnDeleteBottom.UseVisualStyleBackColor = true;
            this.btnDeleteBottom.Click += new System.EventHandler(this.btnDeleteBottom_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.btnDeleteBottom);
            this.Controls.Add(this.btnDeleteTop);
            this.Controls.Add(this.btnIgnore);
            this.Controls.Add(this.picDupe2);
            this.Controls.Add(this.picDupe1);
            this.Controls.Add(this.lstDupeOccurences);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblFolderPrompt);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Duplicate Image Seeker";
            ((System.ComponentModel.ISupportInitialize)(this.picDupe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDupe2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFolderPrompt;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstDupeOccurences;
        private System.Windows.Forms.PictureBox picDupe1;
        private System.Windows.Forms.PictureBox picDupe2;
        private System.Windows.Forms.Button btnIgnore;
        private System.Windows.Forms.Button btnDeleteTop;
        private System.Windows.Forms.Button btnDeleteBottom;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

