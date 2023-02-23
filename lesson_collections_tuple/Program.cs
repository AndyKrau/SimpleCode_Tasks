using System.Security.Cryptography.X509Certificates;

namespace lesson_collections_tuple
{
    internal class Program
    {
        // Пример реализации кортежа.
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 5, 6, 7, 9, 3, 3, 4, 4 };
            var tuple = GetTuple(array);
            Console.WriteLine("Sum: " + tuple.sum);
            Console.WriteLine("Count: " + tuple.count);

            var result = GetMultiplyTuple((5, "Allo"));
            Console.WriteLine(result.Item1);
            Console.WriteLine(result.Item2);

            Console.ReadLine();
        }

        /// <summary>
        /// Функция получает массив и возвращет кортеж с количесвтом элеметов в массиве и их суммой
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static public (int sum, int count) GetTuple(int[] array)
        {
            var result = (sum: 0, count: array.Length);
            foreach (var item in array)
            {
                result.sum += item;
            }
            return result;
        }

        static public (int, string) GetMultiplyTuple((int x, string y) tuple)
        {
            int _x = tuple.x * 2;
            string _y = tuple.y + tuple.y;
            return (_x, _y);
        }


    }
}