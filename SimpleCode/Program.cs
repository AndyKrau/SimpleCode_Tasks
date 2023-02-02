﻿using System;
using System.Collections.Generic;

// Песочница для лекций

namespace SimpleCode
{
    internal class Program
    {
        enum Weekdays : byte
        {
            Monday = 1 ,
            Thuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Loop()
        {
            try
            {
                Console.Write("enter day: ");
                string str = Console.ReadLine();

                Weekdays arr2 = (Weekdays)Enum.Parse(typeof(Weekdays), str, ignoreCase: true);

                switch (arr2)
                {
                    case Weekdays.Monday:
                        Console.WriteLine("вы выбрали Monday");
                        break;
                    case Weekdays.Thuesday:
                        Console.WriteLine("вы выбрали Thuesday");
                        break;
                    case Weekdays.Wednesday:
                        Console.WriteLine("вы выбрали Wednesday");
                        break;
                    case Weekdays.Thursday:
                        Console.WriteLine("вы выбрали Thursday");
                        break;
                    case Weekdays.Friday:
                        Console.WriteLine("вы выбрали Friday");
                        break;
                    case Weekdays.Saturday:
                        Console.WriteLine("вы выбрали Saturday");
                        break;
                    case Weekdays.Sunday:
                        Console.WriteLine("вы выбрали Sunday");
                        break;
                    default:
                        Console.WriteLine("вы не выбрали день");
                        break;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine($"Error: {e.Message}");
            }
            
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Loop();
            }
           
        }
    }
}
