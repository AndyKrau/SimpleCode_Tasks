using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_lesson_inheritance
{
    class Student:Person
    {
        public Student(string firstName, string lastName, string group) : base(firstName, lastName)
        {
            Group = group;
            Console.WriteLine("Сработал конструктор класса Student ->");
        }

        public string Group { get; set; }
        public void Learn()
        {
            Console.WriteLine("Я учусь!");
        }

        public override void GetFullName()
        {
            Console.WriteLine($"Имя: {FirstName} \tФамилия: {LastName} \tГруппа:{Group}");
        }
    }
}
