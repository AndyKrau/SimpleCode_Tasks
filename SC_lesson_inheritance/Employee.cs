using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_lesson_inheritance
{
    class Employee: Person
    {
        public Employee(string firstName, string lastName, int salary):base(firstName, lastName)
        {
            Salary= salary;
            Console.WriteLine("Сработал конструктор класса Employee");
        }
        public int Salary { get; set; }

       
    }
}
