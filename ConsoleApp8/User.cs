using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class User:IAccount
    {
        private static int _id;
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string fullName,string email,string password)
        {
            _id++;
            Id = _id;
            FullName = fullName;
            Email = email;
            if(PasswordChecker(password))
            {
                Password = password;
            }
            else
            {
                Console.WriteLine("Duzgun sifre daxil edin");
            }
        }
        public bool PasswordChecker(string password)
        {
            if(password.Length>=8)
            {

                bool chekisUpper = false;
                bool checkIsLower = false;
                bool checkIsDigit = false;


                foreach (var letter in password)
                {
                    if(char.IsUpper(letter))
                    {
                        chekisUpper = true;
                    }
                    else if(char.IsLower(letter))
                    {

                        checkIsLower = true;
                    }
                    else if(char.IsDigit(letter))
                    {
                        checkIsDigit = true;
                    }

                }
                return chekisUpper&& checkIsLower && checkIsDigit;
            }
            return false;

        }

        public void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
