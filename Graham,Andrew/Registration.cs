using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graham_Andrew
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbxAvatar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAvatar.SelectedIndex == 0)
            {
                pbxAvatar.ImageLocation = "AlbertEinstienTP.png";
            }
            if (cbxAvatar.SelectedIndex == 1)
            {
                pbxAvatar.ImageLocation = "nielesBohrTP.png";
            }
            if (cbxAvatar.SelectedIndex == 2)
            {
                pbxAvatar.ImageLocation = "MarieCurieTP.png";
            }
            if (cbxAvatar.SelectedIndex == 3)
            {
                pbxAvatar.ImageLocation = "StephenHawkingsTP.png";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                var CurrentUser = new User(tbxUserName.Text, tbxPassword.Text, tbxLastName.Text, cbxAvatar.SelectedIndex,tbxFirstName.Text);
                CurrentUser.RegisterUser();
                tbxFirstName.Clear();
                tbxLastName.Clear();
                tbxUserName.Clear();
                tbxPassword.Clear();
                cbxAvatar.ResetText();
                MessageBox.Show("You will now be redirected to the logon form, to register another user simply click on the register button again","Login");
                Form MovetoLogin = new Logon();
                MovetoLogin.Show();
                this.Close();
                
            }
                
            catch
            {
                MessageBox.Show("Sorry there has been a problem registering yuor account, Please Try Again", "Registration Unsecessfull");
            }
        }
    }
}
