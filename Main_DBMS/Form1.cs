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
        private PictureBox pb; 
        private Bitmap bmp;
        public frmDBMS()
        {
            InitializeComponent();

            bmp = Screenshot.takeSnapshot(panel1); // Правиме screenshot од panel1 
            pb = new PictureBox(); // Правиме нова PictureBox користена во функцијата за замаглување на позадината
            panel1.Controls.Add(pb); // Го додаваме PictureBox во адекватиниот панел
            pb.Dock = DockStyle.Fill; // PictureBox-от го

            viewToolStripMenuItem.Enabled = false;
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

        private void frmDBMS_Load(object sender, EventArgs e)
        {
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

        private void discardChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changeTableChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Select_Table_Form selectTable = new Select_Table_Form();
            BlurFunctions.blur(panel1, pb, bmp);

            if (selectTable.ShowDialog() == DialogResult.OK)
            {
                
                if (!CurrentTable.filled)
                    table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                else
                    table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                table.DataSource = CurrentTable.dtb;
            }
            BlurFunctions.removeBlur(pb);
            selectTable.Dispose();
        }

        private void applicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlurFunctions.blur(panel1, pb, bmp);
            MessageBox.Show("DBMSMS 1.0 (DBMS Management System) \nby Riste Ristov", "Application Info", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            BlurFunctions.removeBlur(pb);
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlurFunctions.blur(panel1, pb, bmp);
            MessageBox.Show("First Name: " + Current_User.GetFirstName() + "\nLast Name: " + Current_User.GetLastName() + "\nPrivileges: " + Current_User.GetPrivileges(), "User Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BlurFunctions.removeBlur(pb);
        }

        private void discardChangesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CurrentTable.dtb.RejectChanges();
            table.DataSource = CurrentTable.dtb;
        }
    }
}
