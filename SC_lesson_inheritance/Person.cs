using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SC_lesson_inheritance
{
    internal class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName= firstName;
            LastName= lastName;
            Console.WriteLine("Сработал конструктор класса Person");
        }

        public string FirstName { get; set; } = "Unknown";
        public string LastName { get; set; } = "Unknown";

        public virtual void GetFullName()
        {
            Console.WriteLine($"Имя: {FirstName} \t Фамилия: {LastName}");
        }
    }
}
