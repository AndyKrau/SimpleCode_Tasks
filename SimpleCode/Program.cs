using System;
using System.Collections.Generic;

// Песочница для лекций

namespace SimpleCode
{
    class Person
    {
        public static int retirementAge = 60;
        int _age;
        static Person()
        {
            Console.WriteLine($"Начальный пенсионный возраст: {retirementAge}");
        }
        public Person(int age)
        {
            _age = age;
        }
        public void Display()
        {
            if (_age >= retirementAge) Console.WriteLine("Вы уже на пенсии");
            else Console.WriteLine($"До пенсии осталось {retirementAge - _age} лет");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person tom;
            tom = new Person(34);
            Person.retirementAge = 65;
            tom.Display();

            Console.ReadKey();
        }
    }
}
