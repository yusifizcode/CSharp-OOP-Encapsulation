using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP_Encapsulation
{
    internal class User
    {
        public User(string username)
        {
            this.UserName = username;
        }
        public string _userName;
        private string _password;

        public string UserName { get { return this._userName; }  set 
            {
                if (value.Length>6 && value.Length<25)
                {
                    _userName = value;
                }
                else
                {
                    Console.WriteLine("Istifadeci adinin uzunlugu 6-dan boyuk 25-den kicik olmalidir.");
                }
            
            
            } }
        public string Password
        {
            get { return _password; }
            set
            {

                if (value.Length > 8 && value.Length < 25 && HasDigit(value) && HasLower(value) && HasUpper(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Parolun uzunlugu 8-den boyuk 25-den kicik olmalidir, icerisinde boyuk herf kicik herf ve reqem olmalidir.");
                }

            }
        }

        public bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasUpper(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasLower(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLower(str[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
