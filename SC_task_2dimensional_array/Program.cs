using System;

// Вывод двумерного массива в консоль ввиде таблицы
// Заполнение массива рандомными числами
// Зубчатый массив

namespace SC_task_2dimensional_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            int height = array.GetLength(0);
            int width = array.GetLength(1);

            // Заполнение массива рандомными числами
            Random random = new Random();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    array[i, j] = random.Next(100);
                }
            }

            // Вывод двумерного массива в консоль ввиде таблицы
            Console.WriteLine("Рандомное заполнение двумерного прямоугольного массива:");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(array[i,j] + "\t");
                }
                Console.WriteLine();
            }

            // Зубчатый массив
            Console.WriteLine("Рандомное заполнение двумерного зубчатого массива:");
            int[][] ints = new int[5][];
            ints[0] = new int[5];
            ints[1] = new int[3];
            ints[2] = new int[6];
            ints[3] = new int[4];
            ints[4] = new int[9];

            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < ints[i].Length; j++)
                {
                    ints[i][j] = random.Next(100);
                }
            }

            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < ints[i].Length; j++)
                {
                    Console.Write(ints[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
