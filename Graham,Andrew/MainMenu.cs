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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnLeaderBoard_Click(object sender, EventArgs e)
        {
            Form MoveToLeaderboard = new LeaderBoard();
            MoveToLeaderboard.Show();
            this.Close();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            Form ChangePassword = new ChangePassword();
            ChangePassword.Show();
            this.Close();        
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When your ready click on 'Ok' to continue on to the first question. \n Good Luck","Start the Quiz");
            Form MoveToQuestionOne = new SpinningWheel();
            MoveToQuestionOne.Show();
            this.Close();
        }
        
    }
}
