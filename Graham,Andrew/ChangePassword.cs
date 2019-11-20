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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
            
            
        }
        private User CurrentUser = new User(Program._userName, Program._passWord, Program._lastName, Program._avatar, Program._firstName);
        private void ChangePassword_Load(object sender, EventArgs e)
        {
            
          
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (CurrentUser.PassWord == tbxCurrentPassword.Text)
            {
                if (tbxNewPassword.Text == tbxNewPasswordConFirm.Text)
                {
                    if (tbxNewPassword.Text != tbxCurrentPassword.Text)
                    {
                        CurrentUser.PassWord = tbxNewPassword.Text;
                        CurrentUser.RegisterUser();
                        Program._passWord = tbxNewPassword.Text;
                        Form MoveToMainMenu = new MainMenu();
                        MoveToMainMenu.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("New password can not be the same as your old password, Please Try Again");
                    }
                }
                else
                {
                    MessageBox.Show("New Password Fields do not Match, Please try Again");
                }
            }                
            else
            {
                MessageBox.Show("Current Password was not correct, Please try again");
            }
            tbxCurrentPassword.Clear();
            tbxNewPassword.Clear();
            tbxNewPasswordConFirm.Clear();
        }

        
        

    }
}
