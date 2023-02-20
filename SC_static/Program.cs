namespace SC_static
{
    internal class Program
    {
        static class MyClass
        {
            static MyClass()
            {
                Console.WriteLine("Конструктор static!");
            }

            static public void test()
            {
                Console.WriteLine("метод static");
            }
        }

        class MyClass2
        {
            static MyClass2()
            {
                Console.WriteLine("static ctor");
            }

            public MyClass2()
            {
                Console.WriteLine("Usual ctor");
            }
            
            public void Method()
            {
                Console.WriteLine("Method");
            }
        }
        static void Main(string[] args)
        {
            new MyClass2().Method();
            new MyClass2().Method();
            Console.ReadKey();
        }
    }
}