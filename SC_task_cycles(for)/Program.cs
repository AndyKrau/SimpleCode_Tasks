using System;
using System.Runtime.Versioning;

namespace SC_task_cycles_for_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ширину треугольника:");
            int height = int.Parse(Console.ReadLine());

            // вывод первого треугольника
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // вывод второго треугольника
            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            // вывод третьего треугольника
            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // вывод четвертого треугольника
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = height; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
