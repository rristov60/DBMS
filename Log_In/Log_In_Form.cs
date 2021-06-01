using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Log_In
{
    public partial class Log_In_Form : Form
    {

        public Log_In_Form()
        {
            InitializeComponent();
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
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
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
                txtPassword.Text = "Password";
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void btnLogIn_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnLogIn_MouseLeave(object sender, EventArgs e)
        {
            //btnLogIn.ForeColor = Color.Gray;
            //btnLogIn.FlatAppearance.BorderColor = Color.Gray;
        }

        private void btnLogIn_MouseEnter(object sender, EventArgs e)
        {
            //btnLogIn.ForeColor = Color.Black;
            //btnLogIn.FlatAppearance.BorderColor = Color.Black;
        }

        private void timerBlink_Tick(object sender, EventArgs e)
        {
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

        }
    }
}