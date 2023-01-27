using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_lesson_overload
{
    internal class Program
    {
        /// <summary>
        /// Возвращает сумму двух элементов типа int
        /// </summary>
        /// <param name="x">первый элемент</param>
        /// <param name="y">второй элемент</param>
        /// <returns>int</returns>
        static int Sum(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        ///  Возвращает сумму трёх элементов типа int
        /// </summary>
        /// <param name="x">первый элемент</param>
        /// <param name="y">второй элемент</param>
        /// <param name="z">третий элемент</param>
        /// <returns></returns>
        static int Sum(int x, int y, int z)
        {
           
            return x + y + z;
        }

        /// <summary>
        /// Возвращает сумму двух элементов типа double
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static double Sum(double x, double y) 
        {
            return x + y; 
        }


        static void Main(string[] args)
        {

        }
    }
}
