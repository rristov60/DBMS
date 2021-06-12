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
    public partial class Delete_user : Form
    {
        public Delete_user(DataTable dtb)
        {
            InitializeComponent();

            foreach (DataRow row in dtb.Rows)
            {
                if (row["Username"].ToString() == Current_User.GetUserName())
                    continue;
                comboDeleteUsers.Items.Add(row["Username"] + ", " + row["FirstName"] + " " + row["LastName"] + " " + row["Privilege"]);
            }
        }

        private void btnCancelDeleteUser_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOKDeleteUser_Click(object sender, EventArgs e)
        {
            string[] userToDelete = comboDeleteUsers.SelectedItem.ToString().Split(',');
            if(MessageBox.Show("Are you sure you want to delete" + userToDelete[1] + " ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool success = Queries.DeleteUser(userToDelete[0].Trim());
                if (success)
                {
                    MessageBox.Show("The User was delete sucessfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The User couldn't be deleted at this time", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.DialogResult = DialogResult.OK;
            }
            
        }
    }
}
