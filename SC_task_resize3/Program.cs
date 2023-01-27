// Написать методы удаляющие элемент в массиве в начале, конеце и по индексу.

namespace SC_task_resize3
{
    internal class Program
    {
        static void Delete(ref int[] array, int index) // удаление элемента по индексу 
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            for (int i = index; i < array.Length - 1; i++)
                newArray[i] = array[i + 1];

            array = newArray;
        }

        static void DeleteStart(ref int[] array) // удаление первого элемента массива
        {
            Delete(ref array, 0);
        }

        static void DeleteEnd(ref int[] array) // удаление последнего элемента массива
        {
            Delete(ref array, array.Length-1);
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
            int[] myArray = { 1, 2, 3, 4, 5 };

            //Delete(ref myArray, 2);
            //DeleteStart(ref myArray);
            DeleteEnd(ref myArray);

            OutputArray(myArray);
            Console.ReadKey();
        }
    }
}