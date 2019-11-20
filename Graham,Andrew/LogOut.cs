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
    public partial class LogOut : Form
    {
        public LogOut()
        {
            InitializeComponent();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.logOutConfirm = true;
            this.Close();
            Program._avatar = 3;
            Program._firstName = "Testing";
            Program._lastName = "Account";
            Program._passWord = "T3ester";
            Program._userName = "T3ster";
        }
    }
}
