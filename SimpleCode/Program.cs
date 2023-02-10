using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

// Песочница для лекций

namespace SimpleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person
            {
               FirstName = "Oleg",
               LastName = "Petrov",
               Address = new Address
               {
                 Country = "Russia",
                 City = "Saint-Peterburg",
                 Street = "Lomonosova",
                 Building = 34,
                 Zipcode = 645077,
               }
            };

            Person person2 = new Person
            {
                FirstName = "sdasd",
                LastName = "sdfsd",
                Address = new Address
                {
                    Country = "Russia",
                    City = "Saint-Peterburg",
                    Street = "Lomonosova",
                    Building = 34,
                    Zipcode = 645077,
                }
            };

            Person[] people = { person1, person2 };

            PrintPeople(people);

            Console.ReadKey();
        }

        static void PrintPeople(Person[] people)
        {
            foreach (Person person in people)
            {
                person.GetFillInfo();
            }
        }
    }
}
