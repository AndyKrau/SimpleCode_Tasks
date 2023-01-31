using System;

// Песочница для лекций

namespace SimpleCode
{
    internal class Program
    {
        static int Summ(string str, params int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return result;
        }

        static void InfoObject(bool enableMetod = false, params object[] arg)
        {
            if (enableMetod)
                Console.WriteLine("Метод передачи значения по-умолчанию включен");
            else
                Console.WriteLine("Метод передачи значения по-умолчанию отключен");

            string message = "Тип данных: {0}, значение: {1}";
            foreach (var item in arg)
            {
                Console.WriteLine(message, item.GetType(), item);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Summ("Пример метода с ключевым словом params:",3,54,56));

            InfoObject( true, "Hello!", 'F', 45, 65.4F, 94.94, 0.345M, true);
            Console.ReadKey();
        }
    }
}
