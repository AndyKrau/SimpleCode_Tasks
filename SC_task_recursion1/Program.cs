//реализовать вывод массива с помощью рекурсии
//реализовать сложение всех элементов массива с помощью рекурсии
//найти сумму цифр числа с помощью рекурсии

using System;

namespace SC_task_recursion1
{
    internal class Program
    {
        static void OutputArray(int[] array, int index = 0)
        {
            if (index < array.Length)
            {
                Console.Write($"{array[index]} ");
                OutputArray(array, index+1);
            }
            else
                return;
        }//реализовать вывод массива с помощью рекурсии

        static int SumArray(int[] array, int index = 0, int sum = 0)
        {
            if (index < array.Length)
            {
                sum += array[index];
                return SumArray(array, index + 1, sum);
            }
            else
                return sum;
        }//реализовать сложение всех элементов массива с помощью рекурсии

        static int SumNumbers(int number, int index = 10)//найти сумму цифр числа с помощью рекурсии
        {
            if (number % index == 0 )
                return 0;

            int x = number % index;
            int result = number / index;

            return x + SumNumbers(result);
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 2 };
            int number = 567;

            Console.Write("Массив выведенный с помощью рекурсии: ");
            OutputArray(arr);
            Console.WriteLine();

            Console.WriteLine("Сумма элементов массива: " + SumArray(arr));

            Console.WriteLine($"Сумма элементов числа {number}: {SumNumbers(number)}");
            Console.ReadKey();
        }
    }
}