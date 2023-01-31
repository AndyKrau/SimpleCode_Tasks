namespace SC_lesson_ref_out_in
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Foo(ref int a)
            {
                a = -5;
            }

            static void Bar(out int value)
            {
                value = 55;

            }

            static void GetRectangleData(int widht, int height, out int rectangleArea, out int perimetr)
            {
                rectangleArea = widht * height;
                perimetr = (widht + height) * 2;
            }

            static void Main(string[] args)
            {
                GetRectangleData(35, 45, out int area, out int perim);
                Console.WriteLine($"area: {area}");
                Console.WriteLine($"perimetr: {perim}");
                Console.ReadKey();
            }
        }
    }
}