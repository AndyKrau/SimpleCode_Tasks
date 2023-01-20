using System;

namespace SC_task_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = 0;
                Console.WriteLine("Введите количество повторений:");
                int n = int.Parse(Console.ReadLine());
                while (i < n)
                {
                    Console.WriteLine($"Hello in {i + 1} time!");
                    i++;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally 
            {
                Console.WriteLine("Вывод закончен!");
            }
            Console.ReadKey();
        }
    }
}
