using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private void btnScan_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
