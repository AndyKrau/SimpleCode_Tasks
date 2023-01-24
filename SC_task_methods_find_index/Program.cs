using System;

//Найти индекс первого вхождения элемента, аналогично методу IndexOf

namespace SC_task_methods_find_index
{
    internal class Program
    {
        static int FindFirstIndex(int[] array, int index)
        {
            int firstIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == index)
                {
                    firstIndex = i;
                    break;
                }
                else
                    firstIndex = -1;
            }
            return firstIndex;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 56, -4, 34, -1, 56, 101 };

            Console.WriteLine("{ 1, 2, 56, -4, 34, -1, 56, 101 }");
            Console.Write("Введите число для поиска его индекса в массиве: ");

            int number = int.Parse(Console.ReadLine());

            Console.Write("Первое вхождение выбранного числа в массиве под индексом: " + FindFirstIndex(arr, number));
            Console.ReadKey();
        }
    }
}
