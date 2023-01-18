using System;

namespace SimpleCode_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double number1, number2, result;

                Console.WriteLine("SimpleCode: task - calculator");
                try
                {
                    Console.WriteLine("Введите первое число:");
                    number1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    number2 = double.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Выберите операцию '+' '-' '*' '/':");
                ConsoleKey consoleKey = Console.ReadKey().Key;

                switch (consoleKey)
                {
                    case ConsoleKey.Multiply:
                        result = number1 * number2;
                        Console.WriteLine($"\nРезультат: {result}");
                        break;
                    case ConsoleKey.Divide:
                        if (number2 == 0)
                            Console.WriteLine("На ноль делить нельзя!");
                        else
                        {
                            result = number1 / number2;
                            Console.WriteLine($"\nРезультат: {result}");
                        }
                        break;
                    case ConsoleKey.Add:
                        result = number1 + number2;
                        Console.WriteLine($"\nРезультат: {result}");
                        break;
                    case ConsoleKey.Subtract:
                        result = number1 - number2;
                        Console.WriteLine($"\nРезультат: {result}");
                        break;

                    default:
                        Console.WriteLine("\nОперация неизвесна!");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
