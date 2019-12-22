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
    public partial class frmScanning : Form
    {
        /// <summary>
        /// Loading/scanning screen.
        /// </summary>
        /// <param name="NumFolders">The number of main folders in the folder provided in frmMain, used for this form's progressbar object.</param>
        public frmScanning(int NumFolders)
        {
            InitializeComponent();
            progressBar1.Maximum = NumFolders;
        }
    }
}
