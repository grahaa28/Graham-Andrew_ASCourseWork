using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace Graham_Andrew
{
    public partial class MeasuringCylinder : Form
    {
        public int tries = 0;
        public List<int> Difference = new List<int> { };
        int tmrFilltick;
        
        public MeasuringCylinder()
        {
            InitializeComponent();
            

        }
        public bool isLooping = false;

        private void lblInstruction_Click(object sender, EventArgs e)
        {
            

        }

        private void btnStartFill_Click(object sender, EventArgs e)
        {
            tmrFill.Start();
            btnStartFill.Enabled = false;
        }

        private void tmrFill_Tick(object sender, EventArgs e)
        {
            tmrFilltick++;
            if (tmrFilltick > 30)
            {
                btnStopFill.Enabled = true;
                VerticalProgressBar.ForeColor = Color.Blue;
                VerticalProgressBar.BackColor = Color.White;
                
            }
            try
            {
                VerticalProgressBar.Value += 5;
                
            }
            catch
            {
                tmrFill.Stop();
                MessageBox.Show("Sorry Measuring cylinder can only read to 500ml. Please retry");
                VerticalProgressBar.Value = 0;
                btnStopFill.Enabled = false;
                btnSubmitAnswer.Enabled = false;
                btnStartFill.Enabled = true;
            }
        }

        private void btnStopFill_Click(object sender, EventArgs e)
        {
            tmrFill.Stop();
            btnStartFill.Enabled = false;
            tmrFill.Stop();
            btnStopFill.Enabled = false;
            btnSubmitAnswer.Enabled = true;
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            btnSubmitAnswer.Enabled = false;
            tmrFilltick = 0;
            int difference = 0;            
            try
            {
                difference = VerticalProgressBar.Value - Convert.ToInt32(tbxGuess.Text);
            }
            catch 
            {
                try
                {
                    difference = Convert.ToInt32(tbxGuess.Text) - VerticalProgressBar.Value;
                }
                catch
                {
                    MessageBox.Show("Please enter a integer number");                    
                }
                

            }
            MessageBox.Show(string.Format("Your guess was {0}ml, the actual value was {1}ml meaning the difference was {2}ml", tbxGuess.Text, VerticalProgressBar.Value,Convert.ToString(difference)));
            Difference.Add(difference);
            tbxGuess.Clear();
            tries++;
            if (tries < 3)
            {
                VerticalProgressBar.Value = 0;
                btnStartFill.Enabled = true;
                btnStopFill.Enabled = false;

            }
            else
            {
                int avgDifference = 0;
                for(int i = 0; i < Difference.Count; i++)
                {
                    avgDifference += Difference[i];
                }
                MessageBox.Show(string.Format("Your average difference for this activity was {0}ml",avgDifference));
                Form MoveToNext = new Hooke_s_Constant();
                MoveToNext.Show();
                this.Close();
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrFill.Stop();
            label5.Visible = true;
            gbxPause.Visible = true;
            ShowHide(false);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbxPause.Visible = false;
            ShowHide(true);
            label5.Visible = false;
            if (btnStartFill.Enabled == false)
            {
                tmrFill.Start();
            }
            
        }

        private void ShowHide(bool input)
        {
            lblFirstLastName.Visible = input;
            lblInstruction.Visible = input;
            lblSubmit.Visible = input;
            btnStartFill.Visible = input;
            btnStopFill.Visible = input;
            btnSubmitAnswer.Visible = input;
            VerticalProgressBar.Visible = input;
            pbxMeasuringCylinder.Visible = input;
            pbxAvatar.Visible = input;
            tbxGuess.Visible = input;
        }

        private void hintWithTheCurrentQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ensure that you are reading from the very bottom of the water line");
        }

        private void gbxPause_Enter(object sender, EventArgs e)
        {
            
        }

        private void MeasuringCylinder_Load(object sender, EventArgs e)
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
            lblFirstLastName.Text = string.Format(@"Welcome {0} {1},", CurrentUser.FirstName, CurrentUser.LastName);
        }
    }
}
