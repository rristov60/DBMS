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
        List<Image> opacity = new List<Image>();
        PictureBox arrow = new PictureBox();
        PictureBox underscore = new PictureBox();
        int increment = 0;
        int decrement = 0;
        public Log_In_Form()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            opacity.Add(Properties.Resources.Underscore_thin_5);
            opacity.Add(Properties.Resources.Underscore_thin_10);
            opacity.Add(Properties.Resources.Underscore_thin_15);
            opacity.Add(Properties.Resources.Underscore_thin_20);
            opacity.Add(Properties.Resources.Underscore_thin_25);
            opacity.Add(Properties.Resources.Underscore_thin_30);
            opacity.Add(Properties.Resources.Underscore_thin_35);
            opacity.Add(Properties.Resources.Underscore_thin_40);
            opacity.Add(Properties.Resources.Underscore_thin_45);
            opacity.Add(Properties.Resources.Underscore_thin_50);
            opacity.Add(Properties.Resources.Underscore_thin_55);
            opacity.Add(Properties.Resources.Underscore_thin_60);
            opacity.Add(Properties.Resources.Underscore_thin_65);
            opacity.Add(Properties.Resources.Underscore_thin_70);
            opacity.Add(Properties.Resources.Underscore_thin_75);
            opacity.Add(Properties.Resources.Underscore_thin_80);
            opacity.Add(Properties.Resources.Underscore_thin_85);
            opacity.Add(Properties.Resources.Underscore_thin_90);
            opacity.Add(Properties.Resources.Underscore_thin_95);

            underscore.Image = Properties.Resources.Underscore_thin;
            underscore.SizeMode = PictureBoxSizeMode.StretchImage;
            underscore.Height = 5;
            underscore.Width = 10;

            btnLogIn.Controls.Add(underscore);
            
            underscore.Top += 21;
            underscore.Left += 23;

            arrow.Image = Properties.Resources.Greater_thin;
            arrow.SizeMode = PictureBoxSizeMode.StretchImage;
            arrow.Height = 20;
            arrow.Width = 10;
            arrow.Top += 8;
            arrow.Left += 11;

            btnLogIn.Controls.Add(arrow);
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
            timerBlink.Stop();
            timerBlink2.Stop();

            underscore.Image = Properties.Resources.Underscore_thin;
        }

        private void btnLogIn_MouseEnter(object sender, EventArgs e)
        {
            //btnLogIn.ForeColor = Color.Black;
            //btnLogIn.FlatAppearance.BorderColor = Color.Black;
            timerBlink.Start();
        }

        private void timerBlink_Tick(object sender, EventArgs e)
        {
            if(increment == opacity.Count)
            {
                increment = 0;
                decrement = opacity.Count;
                timerBlink2.Start();
                timerBlink.Stop();
            }

            underscore.Image = opacity[increment];
            increment++;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

        }

        private void timerBlink2_Tick(object sender, EventArgs e)
        {
            decrement--;
            underscore.Image = opacity[decrement];

            if (decrement == 0)
            {
                increment = 0;
                timerBlink.Start();
                timerBlink2.Stop();
            }
        }
    }
}