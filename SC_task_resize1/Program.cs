// Написать метод Resize изменяющий кол-во элементов массива,
// метод должен иметь возможность увеличить или уменьшить кол-во элементов

// дополнительно методы были расширены до generic.

namespace SC_task_resize1
{
    internal class Program
    {
        static void Resize<T>(ref T[] arr, int arrSize)// реализация метода array.resize
        {
            T[] newArr = new T[arrSize];

            for (int i = 0; i < newArr.Length && i < arr.Length; i++)
                newArr[i] = arr[i];

            arr = newArr;
        }
        
        static void OutputArray<T>(T[] array) // вывод массива в консоль
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 6, 8 };
            string[] strArray = { "sdf", "sdfr", "klflf", "rttrt" };

            Resize(ref myArray, 4);
            Resize(ref strArray, 3);
            OutputArray(myArray);
            Console.WriteLine();
            OutputArray(strArray);
            Console.ReadKey();
        }
    }
}