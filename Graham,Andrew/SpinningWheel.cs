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
    public partial class SpinningWheel : Form
    {
        public SpinningWheel()
        {
           //lblFirstLastName.Text = Logon.firstNameLastName;
            //switch (Logon.avatar)
            //{
                //case 1:
                    //pbxAvatar.Image = Properties.Resources.AlbertEinstienTP;
                    //break;
                //case 2:
                    //pbxAvatar.Image = Properties.Resources.nielesBohrTP;
                    //break;
                //case 3:
                    //pbxAvatar.Image = Properties.Resources.MarieCurieTP;
                    //break;
                //case 4:
                    //pbxAvatar.Image = Properties.Resources.StephenHawkingsTP;
                    //break;
            //}
            
            InitializeComponent();            
            Random RandomQ1 = new Random();
            questions.Add(RandomQ1.Next(1, 2));
            Random RandomQ2 = new Random();
            questions.Add(RandomQ2.Next(3, 4));
            Random RandomQ3 = new Random();
            questions.Add(RandomQ3.Next(5, 6));
            Random RandomQ4 = new Random();
            questions.Add(RandomQ4.Next(7, 8));
            
        }
        public int _ticksColour;
        public string _currentColour;
        public int _CurrentTick;
        public int _tickQuestionLimit;
        public int currentQuestion = 1;
        public List<int> questions = new List<int>();
        public int questionIndex = 0;

        


        private void generalHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Click on spin to begin the game.
Once the game begins you will have 5 seconds to choose an answer.
There are four question which need answered before you move on to the next game,
if you are unsure of the answer select,'Hint with current Questions' or 
select the 'skip' which will allow you to spin again but forfit the points the question that you didnt answer");

        }

        private void pbxPointer_Click(object sender, EventArgs e)
        {

        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            if (lblCurrentScore.Text == " ")
            {
                lblCurrentScore.Text = "0";
            }
            tmrChngClr.Start();
            tmrStop.Start();
            
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            tmrChngClr.Stop();
            
            
        }

        private void tmrChngClr_Tick(object sender, EventArgs e)
        {
            _ticksColour++;
            if (_ticksColour > 8)
            {
                _ticksColour = 1;
            }
            switch (_ticksColour)
            {
                case 1:
                    pbxSpinningWheel.Image = Properties.Resources.Frame1;
                    _currentColour = "Pink";
                    break;
                case 2:
                    pbxSpinningWheel.Image = Properties.Resources.Frame2;
                    _currentColour = "Orange";
                    break;
                case 3:
                    pbxSpinningWheel.Image = Properties.Resources.Frame3;
                    _currentColour = "Yellow";
                    break;
                case 4:
                    pbxSpinningWheel.Image = Properties.Resources.Frame4;
                    _currentColour = "Lblue";
                    break;
                case 5:
                    pbxSpinningWheel.Image = Properties.Resources.Frame5;
                    _currentColour = "Red";
                    break;
                case 6:
                    pbxSpinningWheel.Image = Properties.Resources.Frame6;
                    _currentColour = "Green";
                    break;
                case 7:
                    pbxSpinningWheel.Image = Properties.Resources.Frame7;
                    _currentColour = "Dblue";
                    break;
                case 8:
                    pbxSpinningWheel.Image = Properties.Resources.Frame8;
                    _currentColour = "Lblue";
                    break;
            }
            
        }

        private void tmrStop_Tick(object sender, EventArgs e)
        {
            _CurrentTick++;
            if (_CurrentTick == RandomStop() || _CurrentTick >= RandomStop())
            {
                tmrChngClr.Stop();
                tmrStop.Stop();
                _CurrentTick = 0;
                ApplyQuestion(currentQuestion);
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnSpin.Enabled = false;
                tmrQestionLimit.Start();
                lblQuestionON.Text = Convert.ToString(currentQuestion);
                pbLimit.Value = 0;
            }

        }

        public static int RandomStop()
        {
            var random = new Random();
            int stop = random.Next(1, 8);
            return stop;
            
        }

        private void tmrQestionLimit_Tick(object sender, EventArgs e)
        {
            _tickQuestionLimit++;
            pbLimit.Value += 10;
            switch (_tickQuestionLimit)
            {
                case 1:
                    lblTimeLeft.Text = "9";
                    break;
                case 2:
                    lblTimeLeft.Text = "8";
                    break;
                case 3:
                    lblTimeLeft.Text = "7";
                    break;
                case 4:
                    lblTimeLeft.Text = "6";
                    break;
                case 5:
                    lblTimeLeft.Text = "5";
                    break;
                case 6:
                    lblTimeLeft.Text = "4";
                    break;
                case 7:
                    lblTimeLeft.Text = "3";
                    break;
                case 8:
                    lblTimeLeft.Text = "2";
                    break;
                case 9:
                    lblTimeLeft.Text = "1";
                    break;
                case 10:
                    lblTimeLeft.Text = "Times Up!";
                    break;
            }
            if (_tickQuestionLimit == 10)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                tmrQestionLimit.Stop();
                _tickQuestionLimit = 0;
                currentQuestion++;
                MessageBox.Show("Remember to choose an answer before the timer is up!","Unlucky, out of time");
                btnSpin.Enabled = true;
            }
        }


        public void ApplyQuestion(int question)
        {
            if (File.Exists("QuestionOne.txt"))
            {
                questionIndex = question;
                List<string> questions = File.ReadLines("QuestionOne.txt").ToList();
                List<string> questionDetails = new List<string>();
               questionDetails= questions[question].Split('|').ToList();
                lblQuestion.Text = questionDetails[0];
                btnA.Text = questionDetails[1];
                btnB.Text = questionDetails[2];
                btnC.Text = questionDetails[3];
                btnD.Text = questionDetails[4];  
               
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (File.Exists("QuestionOne.txt"))
            {
                List<string> questions = File.ReadLines("QuestionOne.txt").ToList();
                List<string> questionDetails = new List<string>();
                questionDetails = questions[questionIndex].Split('|').ToList();
                if (questionDetails[5] == btnA.Text)
                {
                    
                    _tickQuestionLimit = 0;
                    pbLimit.Value = 0;
                    tmrQestionLimit.Stop();
                    lblTimeLeft.Text = "0";
                    lblCurrentScore.Text = Convert.ToString(Convert.ToInt16(lblCurrentScore.Text) + 1);
                    MessageBox.Show("Correct");
                }
                else
                {
                   
                    _tickQuestionLimit = 0;
                    pbLimit.Value = 0;
                    tmrQestionLimit.Stop();
                    MessageBox.Show("Not Correct");
                }
                
            }
            currentQuestion = currentQuestion + 1;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSpin.Enabled = true;
            if (currentQuestion == 4)
            {
                MessageBox.Show(string.Format("You got {0} out of 3 correct. \n Now you will be completeing an excersie in reading scales",lblCurrentScore.Text));
                Form MoveToNext = new MeasuringCylinder();
                MoveToNext.Show();
                this.Close();


            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (File.Exists("QuestionOne.txt"))
            {
                List<string> questions = File.ReadLines("QuestionOne.txt").ToList();
                List<string> questionDetails = new List<string>();
                questionDetails = questions[questionIndex].Split('|').ToList();
                if (questionDetails[5] == btnB.Text)
                {
                    
                    tmrQestionLimit.Stop();
                    _tickQuestionLimit = 0;
                    pbLimit.Value = 0;
                    lblTimeLeft.Text = "0";
                    lblCurrentScore.Text = Convert.ToString(Convert.ToInt16(lblCurrentScore.Text) + 1);
                    MessageBox.Show("Correct");
                }
                else
                {
                    
                    _tickQuestionLimit = 0;
                    pbLimit.Value = 0;
                    tmrQestionLimit.Stop();
                    MessageBox.Show("Not Correct");
                }
            }
            currentQuestion = currentQuestion + 1;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSpin.Enabled = true;
            if (currentQuestion == 4)
            {
                MessageBox.Show(string.Format("You got {0} out of 3 correct. \n Now you will be completeing an excersie in reading scales", lblCurrentScore.Text));
                Form MoveToNext = new MeasuringCylinder();
                MoveToNext.Show();
                this.Close();


            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (File.Exists("QuestionOne.txt"))
            {
                List<string> questions = File.ReadLines("QuestionOne.txt").ToList();
                List<string> questionDetails = new List<string>();
                questionDetails = questions[questionIndex].Split('|').ToList();
                if (questionDetails[5] == btnC.Text)
                {
                    
                    tmrQestionLimit.Stop();
                    lblCurrentScore.Text = Convert.ToString(Convert.ToInt16(lblCurrentScore.Text) + 1);
                    _tickQuestionLimit = 0;
                    pbLimit.Value = 0;
                    lblTimeLeft.Text = "0";
                    tmrQestionLimit.Stop();
                    MessageBox.Show("Correct");

                }
                else
                {
                    
                    _tickQuestionLimit = 0;
                    pbLimit.Value = 0;
                    tmrQestionLimit.Stop();
                    MessageBox.Show("Not Correct");
                }
            }
            currentQuestion = currentQuestion + 1;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSpin.Enabled = true;
            if (currentQuestion == 4)
            {
                MessageBox.Show(string.Format("You got {0} out of 3 correct. \n Now you will be completeing an excersie in reading scales", lblCurrentScore.Text));
                Form MoveToNext = new MeasuringCylinder();
                MoveToNext.Show();
                this.Close();


            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (File.Exists("QuestionOne.txt"))
            {
                List<string> questions = File.ReadLines("QuestionOne.txt").ToList();
                List<string> questionDetails = new List<string>();
                questionDetails = questions[questionIndex].Split('|').ToList();
                if (questionDetails[5] == btnD.Text)
                {
                    MessageBox.Show("Correct");
                    _tickQuestionLimit = 0;
                    pbLimit.Value = 0;
                    tmrQestionLimit.Stop();
                    lblTimeLeft.Text = "0";
                    lblCurrentScore.Text = Convert.ToString(Convert.ToInt16(lblCurrentScore.Text) + 1);
                    
                }
                else
                {
                    MessageBox.Show("Not Correct");
                    _tickQuestionLimit = 0;
                    pbLimit.Value = 0;
                    tmrQestionLimit.Stop();
                    
                }
            }
            currentQuestion = currentQuestion + 1;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSpin.Enabled = true;
            if (currentQuestion == 4)
            {
                MessageBox.Show(string.Format("You got {0} out of 3 correct. \n Now you will be completeing an excersie in reading scales", lblCurrentScore.Text));
                Form MoveToNext = new MeasuringCylinder();
                MoveToNext.Show();
                this.Close();


            }
        }

        private void hintWithTheCurrentQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (questionIndex)
            {
                case 0:
                    MessageBox.Show("Remember the unit is named after the man who discovered it");
                    break;
                case 1:
                    MessageBox.Show("Remeber that in general how far you have travelled needs to be divided by how long it took to travel that distance");
                    break;
                case 2:
                    MessageBox.Show("He was a British scientist that was originally born in New Zeland");
                    break;
                case 3:
                    MessageBox.Show("The neutron was discovered just before the beginning of the second world war");
                    break;
                case 4:
                    MessageBox.Show("Remeber back to Module One that you completed in fourth year");
                    break;
                case 5:
                    MessageBox.Show("This is a German Physicist");
                    break;
                case 6:
                    MessageBox.Show("This is a unit derived from youngs modus");
                    break;
            }
                
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrQestionLimit.Stop();
            lblQuestion.Visible = false;
            lblPaused.Visible = true;
            btnA.Visible = false;
            btnB.Visible = false;
            btnC.Visible = false;
            btnD.Visible = false;

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPaused.Visible = false;
            lblQuestion.Visible = true;
            tmrQestionLimit.Start();
            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrQestionLimit.Stop();
            lblQuestion.Visible = false;
            lblPaused.Visible = true;
            Form ConfirmLogOut = new LogOut();
            ConfirmLogOut.Show();
            tmrLogOut.Start();
            
        }

        private void tmrLogOut_Tick(object sender, EventArgs e)
        {
            if (Program.logOutConfirm == true)
            {
                tmrLogOut.Stop();
                Form LogOnMenu = new Logon();
                LogOnMenu.Show();
                this.Close();
            }
        }

        private void lblQuestionON_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrentScore_Click(object sender, EventArgs e)
        {

        }

        private void SpinningWheel_Load(object sender, EventArgs e)
        {
            User CurrentUser = new User(Program._userName, Program._passWord, Program._lastName, Program._avatar, Program._firstName);
            switch (CurrentUser.Avatar)
            {
                case 0:
                    pbxAvatar.Image = Properties.Resources.AlbertEinstienTP;
                    break;
                case 1:
                    pbxAvatar.Image = Properties.Resources.nielesBohrTP;
                    break;
                case 2:
                    pbxAvatar.Image = Properties.Resources.MarieCurieTP;
                    break;
                case 3:
                    pbxAvatar.Image = Properties.Resources.StephenHawkingsTP;
                    break;
                    
            }
            lblFirstLastName.Text = string.Format(@"Welcome {0} {1},",CurrentUser.FirstName,CurrentUser.LastName);
        }
    }
}
