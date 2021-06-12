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
        DataTable emptyData = new DataTable();
        public frmDBMS()
        {
            InitializeComponent();

            bmp = Screenshot.takeSnapshot(panel1); // Правиме screenshot од panel1 
            pb = new PictureBox(); // Правиме нова PictureBox користена во функцијата за замаглување на позадината
            panel1.Controls.Add(pb); // Го додаваме PictureBox во адекватиниот панел
            pb.Dock = DockStyle.Fill; // PictureBox-от го

            viewToolStripMenuItem.Visible = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            btnApplyFilters.Enabled = false;
            changePasswordToolStripMenuItem.Visible = false;

            if(Current_User.GetPrivileges() == "Regular")
            {
                addUserToolStripMenuItem.Visible = false;
                administratorToolStripMenuItem.Visible = false;
                removeUserToolStripMenuItem.Visible = false;
            }else if(Current_User.GetPrivileges() == "ReadOnly")
            {
                addUserToolStripMenuItem.Visible = false;
                administratorToolStripMenuItem.Visible = false;
                removeUserToolStripMenuItem.Visible = false;
                saveChangesToolStripMenuItem1.Visible = false;
                discardChangesToolStripMenuItem1.Visible = false;
            }
        }

        private void saveChangesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if((CurrentTable.tableKind == "FilteredTitles") || (CurrentTable.tableKind == "FilteredTitleAuthors") || (CurrentTable.tableKind == "FilteredStores")
               || (CurrentTable.tableKind == "FilteredRoyalties") || (CurrentTable.tableKind == "FilteredPublishers") || (CurrentTable.tableKind == "FilteredJobs")
               || (CurrentTable.tableKind == "FilteredEmployee") || (CurrentTable.tableKind == "FilteredDiscounts") || (CurrentTable.tableKind == "FilteredAuthors")
               || (CurrentTable.tableKind == "FilteredSales"))
            {
                MessageBox.Show("Please choose valid table to make changes", "Invalid Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool sucess = Queries.SaveChanges();

                if (sucess)
                {
                    MessageBox.Show("The changes have been saved !!", "Save Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The changes couldn't be saved at this moment !!", "Save Changes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
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

        private void administratorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Add_User addUsrForm = new Add_User("Administrator");
            BlurFunctions.blur(panel1, pb, bmp);
            addUsrForm.ShowDialog();
            BlurFunctions.removeBlur(pb);
        }

        private void regularUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_User addUsrForm = new Add_User("Regular");
            BlurFunctions.blur(panel1, pb, bmp);
            addUsrForm.ShowDialog();
            BlurFunctions.removeBlur(pb);
        }

        private void readOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_User addUsrForm = new Add_User("ReadOnly");
            BlurFunctions.blur(panel1, pb, bmp);
            addUsrForm.ShowDialog();
            BlurFunctions.removeBlur(pb);
        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            DataTable previous = new DataTable();
            previous = CurrentTable.dtb;
            CurrentTable.dtb = emptyData;

            switch (CurrentTable.tableKind)
            {
                case "sales":
                    if (radioAnd.Checked)
                        if (Queries.SalesFilter(txtBoxFilters.Text, "AND"))
                            table.DataSource = CurrentTable.dtb;
                        else
                            table.DataSource = previous;
                    else
                        if (Queries.SalesFilter(txtBoxFilters.Text, "OR"))
                            table.DataSource = CurrentTable.dtb;
                        else
                            table.DataSource = previous;

                    txtBoxFilters.Clear();
                    break;

                case "authors":
                    if (radioAnd.Checked)
                        if (Queries.AuthorsFilter(txtBoxFilters.Text, "AND"))
                            table.DataSource = CurrentTable.dtb;
                        else
                            table.DataSource = previous;
                    else
                        if (Queries.AuthorsFilter(txtBoxFilters.Text, "OR"))
                            table.DataSource = CurrentTable.dtb;
                        else
                            table.DataSource = previous;

                    txtBoxFilters.Clear();
                    break;

                case "discounts":
                    if (radioAnd.Checked)
                        if (Queries.DiscountsFilter(txtBoxFilters.Text, "AND"))
                            table.DataSource = CurrentTable.dtb;
                        else
                            table.DataSource = previous;
                    else
                        if (Queries.DiscountsFilter(txtBoxFilters.Text, "OR"))
                            table.DataSource = CurrentTable.dtb;
                        else
                            table.DataSource = previous;

                    txtBoxFilters.Clear();
                    break;

                case "employee":
                    if (radioAnd.Checked)
                        if (Queries.EmployeeFilter(txtBoxFilters.Text, "AND"))
                            table.DataSource = CurrentTable.dtb;
                        else
                            table.DataSource = previous;
                    else
                       if (Queries.EmployeeFilter(txtBoxFilters.Text, "OR"))
                            table.DataSource = CurrentTable.dtb;
                        else
                            table.DataSource = previous;

                    txtBoxFilters.Clear();
                    break;

                case "jobs":
                    if (radioAnd.Checked)
                        if (Queries.EmployeeFilter(txtBoxFilters.Text, "AND"))
                            table.DataSource = CurrentTable.dtb;
                        else
                            table.DataSource = previous;
                    else
                      if (Queries.EmployeeFilter(txtBoxFilters.Text, "OR"))
                        table.DataSource = CurrentTable.dtb;
                      else
                        table.DataSource = previous;

                    txtBoxFilters.Clear();
                    break;

                case "publishers":
                    if (radioAnd.Checked)
                        if (Queries.PublishersFilter(txtBoxFilters.Text, "AND"))
                            table.DataSource = CurrentTable.dtb;
                        else
                            table.DataSource = previous;
                    else
                        if (Queries.PublishersFilter(txtBoxFilters.Text, "OR"))
                            table.DataSource = CurrentTable.dtb;
                        else
                            table.DataSource = previous;

                    txtBoxFilters.Clear();
                    break;

                case "royalties":
                    if (radioAnd.Checked)
                        if (Queries.RoyaltiesFilter(txtBoxFilters.Text, "AND"))
                            table.DataSource = CurrentTable.dtb;
                        else
                            table.DataSource = previous;
                    else
                        if (Queries.RoyaltiesFilter(txtBoxFilters.Text, "OR"))
                            table.DataSource = CurrentTable.dtb;
                        else
                            table.DataSource = previous;

                    txtBoxFilters.Clear();
                    break;

                case "stores":
                    if (radioAnd.Checked)
                        if (Queries.StoresFilter(txtBoxFilters.Text, "AND"))
                            table.DataSource = CurrentTable.dtb;
                        else
                            table.DataSource = previous;
                    else
                        if (Queries.StoresFilter(txtBoxFilters.Text, "OR"))
                            table.DataSource = CurrentTable.dtb;
                        else
                            table.DataSource = previous;

                    txtBoxFilters.Clear();
                    break;

                case "titleAuthors":
                    if (radioAnd.Checked)
                        if (Queries.TitleAuthorsFilter(txtBoxFilters.Text, "AND"))
                            table.DataSource = CurrentTable.dtb;
                        else
                            table.DataSource = previous;
                    else
                        if (Queries.TitleAuthorsFilter(txtBoxFilters.Text, "OR"))
                            table.DataSource = CurrentTable.dtb;
                        else
                            table.DataSource = previous;
                    
                    txtBoxFilters.Clear();
                    break;

                case "titles":
                    if (radioAnd.Checked)
                        if (Queries.TitlesFilter(txtBoxFilters.Text, "AND"))
                            table.DataSource = CurrentTable.dtb;
                        else
                            table.DataSource = previous;
                    else
                        if (Queries.TitlesFilter(txtBoxFilters.Text, "OR"))
                        table.DataSource = CurrentTable.dtb;
                    else
                        table.DataSource = previous;
                    
                    txtBoxFilters.Clear();
                    break;

                default:
                    MessageBox.Show("Please select a valid table !", "Valid Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

        }

        private void txtBoxFilters_TextChanged(object sender, EventArgs e)
        {
            if(txtBoxFilters.Text.Trim() == "")
            {
                btnApplyFilters.Enabled = false;
            }
            else
            {
                btnApplyFilters.Enabled = true;
            }
        }

        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable users = new DataTable();
            Queries.GetUsers(users);
            Delete_user rmUser = new Delete_user(users);
            BlurFunctions.blur(panel1, pb, bmp);
            rmUser.ShowDialog();
            BlurFunctions.removeBlur(pb);
            rmUser.Dispose();
        }
    }
}
