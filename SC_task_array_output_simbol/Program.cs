using System;

//Methods
//Вывод нужного количества символов в консоль

namespace SC_task_methods_output_simbol
{
    internal class Program
    {
        static string OutputSimbol(char simbol, int quantity)
        {
            string result = string.Empty;
            for (int i = 0; i < quantity; i++)
            {
                result += simbol;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите символ который нужно повторить:");
            char character = char.Parse(Console.ReadLine());
            Console.Write("Введите количество повторений:");
            int outputQuantity = int.Parse(Console.ReadLine());

            string str = OutputSimbol(character, outputQuantity);
            
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
