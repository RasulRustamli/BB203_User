using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal abstract class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(int age,string name,string surname)
        {
            Age = age;
            Name = name;
            Surname = surname;
        }
        public abstract void SayFullname();
        public abstract void ShowFullData();


    }


   
}
