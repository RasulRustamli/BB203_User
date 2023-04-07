using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal interface IAccount
    {
        public void ShowInfo();
        public bool PasswordChecker(string password);

    }
}
