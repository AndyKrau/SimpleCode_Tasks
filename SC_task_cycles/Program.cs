using System;

namespace SC_task_cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countFirst = 1;
            string symbol = "#";
            string str = "";

            Console.WriteLine();
            while (countFirst <= 10)
            {
                countFirst++;
                str = str + symbol;
                Console.WriteLine(str);
            }
            Console.WriteLine();
            Console.WriteLine();
            while (countFirst > 1)
            {
                Console.WriteLine(str);
                str = str.Substring(0, str.Length - 1);
                countFirst--;
            }
            Console.WriteLine();

            int countSecond = 1;
            string str2 = "          ";

            while (countSecond <= 10)
            {
                str2 = str2.Remove(0, 1);
                str2 = str2.Insert(str2.Length, symbol);
                countSecond++;
                Console.WriteLine(str2);
            }
            Console.WriteLine();
            Console.WriteLine();
            while (countSecond > 1)
            {
                Console.WriteLine(str2);
                countSecond--;
                str2 = str2.Remove(str2.Length-1 , 1);
                str2 = str2.Insert(0, " ");
            }
            Console.ReadKey();
        }
    }
}
