using System.Reflection.PortableExecutable;

namespace SC_lesson_OOP_classes
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student("Иванов", "Иван", "Михайлович", 23, "ЙЦУКЕН-65");

            firstStudent.Print();

            string fullName = firstStudent.GetFullName();

            Console.WriteLine($"Полное имя студента:{fullName}");
            Console.ReadLine();
        }
    }
}