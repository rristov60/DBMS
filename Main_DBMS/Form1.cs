using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL;

namespace Main_DBMS
{
    public partial class frmDBMS : Form
    {
        public frmDBMS()
        {
            InitializeComponent();
            Queries.TableTitles();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            viewToolStripMenuItem.Enabled = false;
        }

        private void saveChangesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The changes have been saved !!", "Save Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDBMS_Load(object sender, EventArgs e)
        {
            table.DataSource = CurrentTable.dtb;
        }

        private void frmDBMS_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        protected override void OnClosed(EventArgs e)
        {
            MessageBox.Show("The form is now closing.",
                "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Exit();
        }
    }
}
