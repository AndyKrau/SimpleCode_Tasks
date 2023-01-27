// Написать методы добавляющие элементы в массив в начало, конец и по индексу.

using System;
using System.Collections.Generic;
using System.Reflection;

namespace SC_task_resize2
{
    internal class Program
    {
        static void Insert(ref int[] array, int index , int value) // добавление элемента по индексу 
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            for (int i = index; i < array.Length; i++)
                newArray[i+1] = array[i];

            array = newArray;
        }

        static void InsertStart(ref int[] array, int value) // добавление элемента в начало массива
        {
            Insert(ref array, 0, value);
        }
        static void InsertEnd(ref int[] array, int value) // добавление элемента в конец массива
        {
            Insert(ref array, array.Length, value);
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

            InsertStart(ref myArray, 111); // добавление элемента в начало массива
            //InsertEnd(ref myArray, 111); // добавление элемента в конец массива
            //Insert(ref myArray, 2, 111 ); // добавление элемента по индексу

            OutputArray(myArray);
            Console.ReadKey();
        }
    }
}