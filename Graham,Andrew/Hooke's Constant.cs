using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;


namespace Graham_Andrew
{
    public partial class Hooke_s_Constant : Form
    {
        public Hooke_s_Constant()
        {
            InitializeComponent();
        }        
        double calcOutput = 0.00;
        List<double> calcInput = new List<double>();
        List<string> calcOperator = new List<string>();
        Series series2 = new Series("Point2");
        Series series = new Series("Point1");
        int tries = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ConfirmLogOut = new LogOut();
            ConfirmLogOut.Show();
            tmrLogOut.Start();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Hooke_s_Constant_Load(object sender, EventArgs e)
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

        private void btnCalcOne_Click(object sender, EventArgs e)
        {
            if (tbxCalcAnswer.Text == "0" && tbxCalcAnswer.Text != null)
            {
                tbxCalcAnswer.Text = "1";
            }
            else
            {
                tbxCalcAnswer.Text = tbxCalcAnswer.Text + "1";
            }  
        }

        private void btnCalcTwo_Click(object sender, EventArgs e)
        {
            if (tbxCalcAnswer.Text == "0" && tbxCalcAnswer.Text != null)
            {
                tbxCalcAnswer.Text = "2";
            } 
            else
            {
                tbxCalcAnswer.Text = tbxCalcAnswer.Text + "2";
            }  
        }

        private void btnCalcThree_Click(object sender, EventArgs e)
        {
            if (tbxCalcAnswer.Text == "0" && tbxCalcAnswer.Text != null)
            {
                tbxCalcAnswer.Text = "3";
            }
            else
            {
                tbxCalcAnswer.Text = tbxCalcAnswer.Text + "3";
            }  
        }

        private void btnCalcFour_Click(object sender, EventArgs e)
        {
            if (tbxCalcAnswer.Text == "0" && tbxCalcAnswer.Text != null)
            {
                tbxCalcAnswer.Text = "4";
            }
            else
            {
                tbxCalcAnswer.Text = tbxCalcAnswer.Text + "4";
            }  
        }

        private void btnCalcFive_Click(object sender, EventArgs e)
        {
            if (tbxCalcAnswer.Text == "0" && tbxCalcAnswer.Text != null)
            {
                tbxCalcAnswer.Text = "5";
            }
            else
            {
                tbxCalcAnswer.Text = tbxCalcAnswer.Text + "5";
            }  
        }

        private void btnCalcSix_Click(object sender, EventArgs e)
        {
            if (tbxCalcAnswer.Text == "0" && tbxCalcAnswer.Text != null)
            {
                tbxCalcAnswer.Text = "6";
            }
            else
            {
                tbxCalcAnswer.Text = tbxCalcAnswer.Text + "6";
            }  
        }

        private void btnCalcSeven_Click(object sender, EventArgs e)
        {
            if (tbxCalcAnswer.Text == "0" && tbxCalcAnswer.Text != null)
            {
                tbxCalcAnswer.Text = "7";
            }
            else
            {
                tbxCalcAnswer.Text = tbxCalcAnswer.Text + "7";
            }  
        }

        private void btnCalcEight_Click(object sender, EventArgs e)
        {
            if (tbxCalcAnswer.Text == "0" && tbxCalcAnswer.Text != null)
            {
                tbxCalcAnswer.Text = "8";
            }
            else
            {
                tbxCalcAnswer.Text = tbxCalcAnswer.Text + "8";
            }  
        }

        private void btnCalcNine_Click(object sender, EventArgs e)
        {
            if (tbxCalcAnswer.Text == "0" && tbxCalcAnswer.Text != null)
            {
                tbxCalcAnswer.Text = "9";
            }
            else
            {
                tbxCalcAnswer.Text = tbxCalcAnswer.Text + "9";
            }  
        }

        private void btnCalcZero_Click(object sender, EventArgs e)
        {
            if (tbxCalcAnswer.Text == "0" && tbxCalcAnswer.Text != null)
            {
                tbxCalcAnswer.Text = "0";
            }
            else
            {
                tbxCalcAnswer.Text = tbxCalcAnswer.Text + "0";
            }  
        }

        private void btnCalcDecimal_Click(object sender, EventArgs e)
        {
            if (tbxCalcAnswer.Text == "0" && tbxCalcAnswer.Text != null)
            {
                tbxCalcAnswer.Text = "0.";
            }
            else
            {
                tbxCalcAnswer.Text = tbxCalcAnswer.Text + ".";
            }  
        }

        private void pbxHangerThree_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcAdd_Click(object sender, EventArgs e)
        {
            calcInput.Add(Convert.ToDouble(tbxCalcAnswer.Text));
            calcOperator.Add("+");
            tbxCalcAnswer.Text = "0";
        }

        private void btnCalcSubtract_Click(object sender, EventArgs e)
        {
            calcInput.Add(Convert.ToDouble(tbxCalcAnswer.Text));
            calcOperator.Add("-");
            tbxCalcAnswer.Text = "0";
        }

        private void btnCalcDevide_Click(object sender, EventArgs e)
        {
            calcInput.Add(Convert.ToDouble(tbxCalcAnswer.Text));
            calcOperator.Add("/");
            tbxCalcAnswer.Text = "0";
        }

        private void btnCalcMultiply_Click(object sender, EventArgs e)
        {
            calcInput.Add(Convert.ToDouble(tbxCalcAnswer.Text));
            calcOperator.Add("*");
            tbxCalcAnswer.Text = "0";
        }

        private void btnCalcEquals_Click(object sender, EventArgs e)
        {
            
            int x = 0;
            calcInput.Add(Convert.ToDouble(tbxCalcAnswer.Text));
            for (int i = 0; i < calcInput.Count; i+=2)
            {
                if (calcOperator[x] == "+")
                {
                    calcOutput += calcInput[i] + calcInput[i + 1];
                }
                if (calcOperator[x] == "-")
                {
                    calcOutput -= calcInput[i] - calcInput[i + 1];
                }
                if (calcOperator[x] == "/")
                {
                    calcOutput += (calcInput[i] / calcInput[i + 1]);
                }
                if (calcOperator[x] == "*")
                {
                    calcOutput += (calcInput[i] * calcInput[i + 1]);
                }
                x++;
            }
            tbxCalcAnswer.Text = Convert.ToString(calcOutput);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calcInput.Clear();
            calcOperator.Clear();
            calcOutput = 0.00;
            tbxCalcAnswer.Text = "0";
        }

        private void pbxSpring_Click(object sender, EventArgs e)
        {

        }

        private void tbcCalcAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void PbxMass_Click(object sender, EventArgs e)
        {
            if (pbxSpring1M.Visible == true)
            {
                pbxSpring1M.Visible = false;
                pbxSpring2M.Visible = true;
                CreateGraph(2);
            }
            if (pbxSpringNM.Visible == true)
            {
                pbxSpringNM.Visible = false;
                pbxSpring1M.Visible = true;
                CreateGraph(1);
            }
            
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if(tbxConstant.Text == "0.5")
            {
                MessageBox.Show("Correct");
            }
            else if(tries == 0)
            {
                MessageBox.Show("Not Quite have 1 last try!");
                tries++;
            }
            else
            {
                MessageBox.Show("Sorry incorrect again, Better luck in the next question");
            }
        }

        private void pbxMass_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void CreateGraph(int massApplied)
        {
           
                if (massApplied == 1)
                {
                   
                    series2.ChartType = SeriesChartType.Line;
                    series2.Points.AddXY(10, 20);
                    series2.Points.AddXY(0, 0);
                    chtHK.Series.Add(series2);
                    lblExtension.Text = "20";
                    lblForce.Text = "10";
                }

                if (massApplied == 2)
                {
                   
                    series.ChartType = SeriesChartType.Line;
                    series.Points.AddXY(20, 40);
                    series.Points.AddXY(10, 20);
                    series.Points.AddXY(0, 0);
                    series.Points.AddXY(15, 30);
                    chtHK.Series.Add(series);
                    lblExtension.Text = "40";
                    lblForce.Text = "20";
                }

                chtHK.ChartAreas[0].AxisX.Minimum = 0;
                chtHK.ChartAreas[0].AxisX.Maximum = 20;
                chtHK.ChartAreas[0].AxisY.Minimum = 0;
                chtHK.ChartAreas[0].AxisY.Maximum = 50;
                chtHK.ChartAreas[0].AxisX.Title = "Applied Force / N";
                chtHK.ChartAreas[0].AxisY.Title = "Extension / Cm";
            
            
            
        }

        private void pbxSpring2M_Click(object sender, EventArgs e)
        {
            pbxSpring2M.Visible = false;           
            pbxSpring1M.Visible = true;
            lblExtension.Text = "20";
            lblForce.Text = "10";
            chtHK.Series.Remove(series);
            
            
        }

        private void pbxSpring1M_Click(object sender, EventArgs e)
        {
            lblForce.Text = "0";
            lblExtension.Text = "0";
            pbxSpring1M.Visible = false;
            pbxSpringNM.Visible = true;
            chtHK.Series.Remove(series2);
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

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbxPause.Visible = true;

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbxPause.Visible = false;
            
        }

        private void gbxPause_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
