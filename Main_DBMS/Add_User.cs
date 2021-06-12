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
    public partial class Add_User : Form
    {
        private string privileges;
        public Add_User(string _privileges)
        {
            InitializeComponent();
            privileges = _privileges;
            btnOKUser.Enabled = false;
            txtRepeatPassword.Enabled = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool success = true;
            success = Queries.CreateUser(txtFirstName.Text, txtLastName.Text, txtUsername.Text, txtPassword.Text, privileges);

            if (success)
            {
                MessageBox.Show("The user was created Sucessfully", "User Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("The user can't be created at this moment \nPlease try again later!", "User Creation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if(txtFirstName.Text == "First Name")
            {
                txtFirstName.Text = "";
                txtFirstName.ForeColor = Color.Black;
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if(txtFirstName.Text == "")
            {
                btnOKUser.Enabled = false;
                txtFirstName.Text = "First Name";
                txtFirstName.ForeColor = Color.Gray;
            }
            else
            {
                if (txtRepeatPassword.Text == txtPassword.Text)
                {
                    btnOKUser.Enabled = true;
                }
            }

        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if(txtLastName.Text == "Last Name")
            {
                txtLastName.Text = "";
                txtLastName.ForeColor = Color.Black;
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if(txtLastName.Text == "")
            {
                btnOKUser.Enabled = false;
                txtLastName.Text = "Last Name";
                txtLastName.ForeColor = Color.Gray;
            }
            else
            {
                if(txtRepeatPassword.Text == txtPassword.Text)
                {
                    btnOKUser.Enabled = true;
                }
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                btnOKUser.Enabled = false;
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }
            else
            {
                if (txtRepeatPassword.Text == txtPassword.Text)
                {
                    btnOKUser.Enabled = true;
                }
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if(txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void txtRepeatPassword_Enter(object sender, EventArgs e)
        {
            if(txtRepeatPassword.Text == "Repeat Password")
            {
                txtRepeatPassword.Text = "";
                txtRepeatPassword.UseSystemPasswordChar = true;
                txtRepeatPassword.ForeColor = Color.Black;
            }
        }

        private void txtRepeatPassword_Leave(object sender, EventArgs e)
        {
            if(txtRepeatPassword.Text == "")
            {
                txtRepeatPassword.Text = "Repeat Password";
                txtRepeatPassword.UseSystemPasswordChar = false;
                txtRepeatPassword.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text != "")
            {
                txtRepeatPassword.Enabled = true;
            }
            else
            {
                txtRepeatPassword.Enabled = false;
            }
        }

        private void txtRepeatPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtRepeatPassword.Text == txtPassword.Text)
            {
                if(txtFirstName.Text != "" || txtLastName.Text != "" || txtUsername.Text != "" || txtPassword.Text != "")
                {
                    btnOKUser.Enabled = true;
                }
                else
                {
                    btnOKUser.Enabled = false;
                }
            }
            else
            {
                btnOKUser.Enabled = false;
            }
        }
    }
}
