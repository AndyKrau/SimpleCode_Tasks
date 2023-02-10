using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_lesson_inheritance
{
    class Security:Employee
    {
        public Security(string firstName, string lastName, int salary, string agency):base(firstName, lastName, salary)
        {
            Agency = agency;
            Console.WriteLine("Сработал конструктор класса Security ->");
        }

        public string Agency { get; set; }

        public void Guard()
        {
            Console.WriteLine("Я охраняю!");
        }

        public override void GetFullName()
        {
            Console.WriteLine($"Имя: {FirstName} \tФамилия: {LastName} \tСтавка: {Salary}$ \tОхранное агенство:{Agency}");
        }
    }
}
