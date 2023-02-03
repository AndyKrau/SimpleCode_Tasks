using System.Reflection.PortableExecutable;
using System.Security.AccessControl;
//Пример ООП на примере создания карточек студента,
//реализованы public методы вывода информации в консоль, 
// метод изменения поля фамилии,
// метод вывода полной ФИО в констоль.
// Также инкапсулированны локальные переменные класса и
// созданы 3 перегрузки конструктора для различных методов добавления карточек.
// Данный пример реализован с целью ознакомления некоторых тем.

namespace SC_lesson_OOP_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student("Иванов", "Иван", "Михайлович", 23, "ЙЦУКЕН-65");
            firstStudent.Print();
            firstStudent.ChangeLastname("########");
            Console.WriteLine($"Полное имя студента:{firstStudent.GetFullName()}");

            Console.WriteLine();

            Student secondStudent = new Student(firstStudent);
            secondStudent.ChangeLastname("Петросян");
            secondStudent.Print();
            Console.WriteLine($"Полное имя студента:{secondStudent.GetFullName()}");

            Console.ReadLine();
        }
    }
}