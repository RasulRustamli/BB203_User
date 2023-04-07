using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal interface ICodeAcademy
    {
        public string CodeEmail { get; set; }
        public void GenerateEmail();
    }
}
