using System;

// Песочница для лекций

namespace SimpleCode
{
    internal class Program
    {
        static void Foo(ref int a)
        {
            a = -5;
        }
        static void Main(string[] args)
        {
            int a = 3;
            Foo(ref a);

            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
