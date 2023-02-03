namespace SC_lesson_enum
{
    internal class Program
    {
        enum Weekdays : byte
        {
            Monday = 1,
            Thuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        /// <summary>
        /// Метод позволяет зациклить выбор дня недели из Enum и отловить ошибки если ввод был некоректным
        /// </summary>
        static void Loop()
        {
            try
            {
                Console.Write("Выберите день недели (введите имя или порядковый номер дня): ");

                string str = Console.ReadLine()!;

                Weekdays weekdays = (Weekdays)Enum.Parse(typeof(Weekdays), str ?? "", ignoreCase: true);

                switch (weekdays)
                {
                    case Weekdays.Monday:
                        Console.WriteLine("вы выбрали Monday");
                        break;
                    case Weekdays.Thuesday:
                        Console.WriteLine("вы выбрали Thuesday");
                        break;
                    case Weekdays.Wednesday:
                        Console.WriteLine("вы выбрали Wednesday");
                        break;
                    case Weekdays.Thursday:
                        Console.WriteLine("вы выбрали Thursday");
                        break;
                    case Weekdays.Friday:
                        Console.WriteLine("вы выбрали Friday");
                        break;
                    case Weekdays.Saturday:
                        Console.WriteLine("вы выбрали Saturday");
                        break;
                    case Weekdays.Sunday:
                        Console.WriteLine("вы выбрали Sunday");
                        break;
                    default:
                        Console.WriteLine("вы не выбрали день");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        /// <summary>
        /// Выводит значения Enum в консоль
        /// </summary>
        static void Print()
        {
            var weekdays = Enum.GetNames(typeof(Weekdays));

            Console.WriteLine("  Enum:");

            foreach (var item in weekdays)
                Console.WriteLine(item);
        }
        static void Main(string[] args)
        {
            Print();

            while (true)
                Loop();
        }
    }
}