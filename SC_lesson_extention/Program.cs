using Microsoft.VisualBasic;
using Date_Extension; //добавленное пространство имён для работы с изолированным методом    ext
using Student_extention;

namespace SC_lesson_extention
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            currentTime.Print();//добавленный ext метод 
            currentTime.IsDayOfWeek(DayOfWeek.Wednesday);//проверка является ли день из параметра cегодняшним днём

            Student student = new Student() { FirstName = "Анатолий", LastName = "Карпов" };
            
            string fullName = student.GetFullName();
            Console.WriteLine("Полное имя студента: " + fullName);
            Console.ReadLine();
        }
    }
}