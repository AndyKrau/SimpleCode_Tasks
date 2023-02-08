namespace SC_lesson_get_set
{
    internal class Program
    {
        class Point
        {
            public static int b;
            public static void Example(int value)
            {
                b = value;
                Console.WriteLine("Метод Example, производит операции над b: b = " + b);
            }

            public void SetB(int value)
            {
                Example(value);
            }
            public void Print()
            {
                Console.WriteLine("b = " + b);
            }


        }
        static void Main(string[] args)
        {
            Point point1 = new Point();
            Point point2 = new Point();

            Point.Example(4566);

            //point1.SetB(223);

            Console.WriteLine("point1:");
            point1.Print();
            Console.WriteLine("point2:");
            point2.Print();

            

            Console.ReadKey();
        }
    }
}