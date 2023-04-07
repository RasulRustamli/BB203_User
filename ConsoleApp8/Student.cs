using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Student:Person
    {

        public double Point { get; set; }

        public Student(int age, string name, string surname,double point) : base(age, name, surname)
        {
            Point = point;
        }
        public override void SayFullname()
        {
            Console.WriteLine(Name+" "+Surname);
        }

        public override void ShowFullData()
        {
            Console.WriteLine($"Name:{Name} Point {Point}");
        }
    }
}
