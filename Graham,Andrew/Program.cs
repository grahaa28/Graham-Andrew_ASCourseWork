using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graham_Andrew
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Logon());
        }
        public static bool logOutConfirm = false;
        public static int _avatar;
        public static string _firstName;
        public static string _lastName;
        public static string _userName;
        public static string _passWord;
       
        
    }

}
