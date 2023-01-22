using System;

// Заполнить массив с клавиатуры
// Вывод масива в обратном порядке
// Сумма четных чисел в массиве
// Найти наименьшее число в массиве

namespace SC_task_array
{
    internal class enter_from_keyboard
    {
        static void Main(string[] args)
        {   
            // ввод массива с клавиатуры
            int[] arr;
            Console.WriteLine("Введите размер массива:");
            int arrSize = int.Parse(Console.ReadLine());
            arr = new int[arrSize];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Введите {i} элемент массива:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Вывод введённого масива в консоль
            Console.WriteLine("Ваш массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            // Вывод масива в обратном порядке
            Console.WriteLine("Массив в обратном порядке:");
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            //Возвращаю нормальный порядок массиву 
            Array.Reverse(arr);
            Console.WriteLine();


            //Сумма четных чисел в массиве
            Console.WriteLine("Сумма четных чисел в массиве:");
            int summEven = 0;
            foreach (var item in arr)
            {
                if (item % 2 == 0)
                    summEven = summEven + item;
                else 
                    continue;
            }
            Console.WriteLine(summEven);

            //Найти наименьшее число в массиве
            int minValue = arr[0];
            Console.WriteLine("Наименьшее число в массиве:");
            for (int i = 1; i < arr.Length; i++)
            {
                if(minValue > arr[i])
                    minValue = arr[i];
                else
                    continue;
            }
            Console.WriteLine(minValue);
            Console.ReadKey();
        }
    }
}
