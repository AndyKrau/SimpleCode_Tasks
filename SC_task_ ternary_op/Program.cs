using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_task_ternary_op
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = number > 0 ? number : 0;
            Console.WriteLine(result);
            Console.ReadKey();
        }
        
    }
}
