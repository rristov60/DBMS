using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_DBMS
{
    public partial class frmDBMS : Form
    {
        public frmDBMS()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void saveChangesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The changes have been saved !!", "Save Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
