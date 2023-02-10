using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_lesson_inheritance
{
    class Teacher:Employee
    {
        public Teacher(string firstName, string lastName, int salary, string schoolNumber) : base(firstName, lastName, salary)
        {
            SchoolNumber = schoolNumber;
            Console.WriteLine("Сработал конструктор класса Teacher ->");
        }
        public string SchoolNumber { get; set; }
        public void Teach()
        {
            Console.WriteLine("Я учу!");
        }
        public override void GetFullName()
        {
            Console.WriteLine($"Имя: {FirstName} \tФамилия: {LastName} \tСтавка: {Salary}$ \tШкола №:{SchoolNumber}");
        }
        
    }
}
