using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Graham_Andrew
{
    public partial class Logon : Form
    {
        public static string firstNameLastName;
        public static int avatar;
        public Logon()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private string Login(string username, string password)
        {
            string message = "  ";
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                if (File.Exists("users.txt"))
                {
                    List<string> users = File.ReadLines("users.txt").ToList();
                    foreach (string element in users)
                    {
                        List<string> userDetails = element.Split('|').ToList();
                        for (int i = 0; i < userDetails.Count; i++)
                        {
                            if (userDetails[0] == username)
                            {
                                if (userDetails[1] == password)
                                {
                                    Program._userName = userDetails[0];
                                    Program._passWord = userDetails[1];
                                    Program._avatar = Convert.ToInt32(userDetails[4]);
                                    string firstName = userDetails[2];
                                    Program._firstName = userDetails[2];
                                    string Lastname = userDetails[3];
                                    Program._lastName = userDetails[3];
                                    message = "Log on Successfull";
                                   // avatar = Avatar;
                                    firstNameLastName = firstName + Lastname;
                                    this.Hide();
                                    Form movetoNext = new MainMenu();
                                    
                                    movetoNext.Show();
                                    break;
                                }
                                else
                                {                                                           
                                    
                                     message = "Log on details are incorrect, please try again";                                       
                                    tbxUserName.Clear();                                        
                                    tbxPassword.Clear();                                   

                                }
                            }
                            else
                            {

                                 message = "Log on details are incorrect, please try again";   
                                tbxUserName.Clear();
                                tbxPassword.Clear();
                                

                            }

                        }
                    }
                }
                else
                {
                     message = "No users file exists, please try again";
                }
            }
            else
            {
                 message = "Username and Password fields cannot be left blank";
            }
            return message;
        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Login(tbxUserName.Text, tbxPassword.Text), "Login");
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form MovetoRegistration = new Registration();
            MovetoRegistration.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void Logon_Load(object sender, EventArgs e)
        {
            Program.logOutConfirm = false;
        }

        
    }
}
