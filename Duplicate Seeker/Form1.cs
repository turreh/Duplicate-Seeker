using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Duplicate_Seeker
{
    public partial class frmMain : Form
    {
        Size ExpandedSize = new Size(820, 490);
        Size CompactSize = new Size(320, 160);
        public frmMain()
        {
            InitializeComponent();
        }

        #region Button Events
        /// <summary>
        /// Open the form to its expanded size, make the outer controls visible and begin scanning the folder.
        /// </summary>
        private void btnScan_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Exits the form and the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Ignore this occurrence of duplicate pictures.
        /// </summary>
        private void btnIgnore_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Deletes the picture file located in picDupe1 deletes the occurrence from the duplicate list boxes.
        /// </summary>
        private void btnDeleteTop_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Deletes the picture file located in picDupe2 deletes the occurrence from the duplicate list boxes.
        /// </summary>
        private void btnDeleteBottom_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Custom Functions
        /// <summary>
        /// Changes the form size to ExpandedSize and makes the outer controls visible.
        /// </summary>
        private void ToExpanded()
        {
            this.Size = ExpandedSize;
            ToggleControls(MakeVisible: true);
        }

        /// <summary>
        /// Changes the form size to CompactSize and hides the outer controls.
        /// </summary>
        private void ToCompact()
        {
            this.Size = CompactSize;
            ToggleControls(MakeVisible: false);
        }

        /// <summary>
        /// Hides or unhides the following controls.
        /// </summary>
        /// <param name="MakeVisible">Boolean to tell whether the </param>
        private void ToggleControls(bool MakeVisible)
        {
            lstDupeOccurences.Visible = MakeVisible;
            picDupe1.Visible = MakeVisible;
            picDupe2.Visible = MakeVisible;
            btnIgnore.Visible = MakeVisible;
            btnDeleteTop.Visible = MakeVisible;
            btnDeleteBottom.Visible = MakeVisible;
        }

        /// <summary>
        /// Clear the instances of duplicates recorded on the form, returning to a blank slate.
        /// </summary>
        private void ClearInstances()
        {
            lstDupeOccurences.Items.Clear();
            picDupe1.Image = null;
            picDupe2.Image = null;
        }

        /// <summary>
        /// Scan though all images within the provided folder and any subfolders. Recursive statement.
        /// </summary>
        private void BeginScanning(string strPath)
        {
            // Ensure a filepath is entered:
            if (strPath == string.Empty)
            {
                MessageBox.Show("A folder path has not been provided. Please enter a directory and try again.", "Invalid Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Since strPath isn't empty, test to see if the provided path works.
            DirectoryInfo folder = new DirectoryInfo(strPath);
            if(!folder.Exists)
            {
                MessageBox.Show("The provided folder path wasn't found or may have been entered incorrectly. Please check your input " +
                    "and try again.", "Folder Not Found");
                return;
            }

            // 
        }

        
        #endregion
    }
}
