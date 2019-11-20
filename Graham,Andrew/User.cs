using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Graham_Andrew
{
    class User
    {
        private string _userName;
        private string _passWord;
        private string _firstName;
        private string _lastName;
        private int _avatar;
        private string _error = "  ";

        public User()
        {
            _userName = "  ";
            _passWord = "  ";
            _firstName = "  ";
            _lastName = "  ";
            _avatar =0;
        }

        public User(string userName, string passWord, string lastName, int avatar, string firstName)
        {
            UserName = userName;
            PassWord = passWord;
            LastName = lastName;
            Avatar = avatar;
            FirstName = firstName;
        }

        public string UserName
        {
            get { return _userName; }
            set
            {
                if (value.Length > 3 || value.Length < 16)
                {
                    _userName = value;
                }
                else
                {
                    _error = _error + "Invalid Username";
                }
            }
        }

        public string PassWord
        {
            get { return _passWord; }
            set
            {
                if (value.Any(char.IsUpper) && value.Any(char.IsLower))
                {
                    if (value.Any(char.IsNumber))
                    {
                        _passWord = value;
                        
                    }
                    else
                    {
                        _error = _error + "\nPassword must contain at least 1 Number";
                    }
                }
                else
                {
                    _error = _error + "\nPassword must contain at least 1 upper and lowercase letter";
                }
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value.Length > 3 && value.Length < 16)
                {
                    _firstName = value;
                }
                else
                {
                    _error = _error + "\n First Names must be between 3 and 16 digits long";
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value.Length > 3 && value.Length < 16)
                {
                    _lastName = value;
                }
                else
                {
                    _error = _error + "\n Last Names must be between 3 and 16 digits long";
                }
            }
        }

        public int Avatar
        {
            get { return _avatar; }
            set
            {
                _avatar = value;
            }
        }

        public void RegisterUser()
        {
            if (_error == "  ")
            {
                string filepath = @"users.txt";
                FileStream afile;
                StreamWriter sw;
                if (!File.Exists(filepath))
                {
                    afile = new FileStream(filepath, FileMode.Create, FileAccess.Write);
                }
                else
                {
                    afile = new FileStream(filepath, FileMode.Append, FileAccess.Write);
                }
                sw = new StreamWriter(afile);
                sw.WriteLine(string.Format("\n{0}|{1}|{2}|{3}|{4}", _userName, _passWord, _firstName, _lastName, _avatar));
                sw.Close();
                afile.Close();
                System.Windows.Forms.MessageBox.Show("Details Successfully added to the system");

            }
            else
            {
                System.Windows.Forms.MessageBox.Show(_error);
            }
        }
    }
}
