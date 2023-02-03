using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SC_lesson_OOP_classes
{
    class Student
    {
        /// <summary>
        /// Конструктор для создания экземпляра класса Student.
        /// </summary>
        /// <param name="lastname">Фамилия</param>
        /// <param name="firstname">Имя</param>
        /// <param name="middlename">Отчество</param>
        /// <param name="age">возраст</param>
        /// <param name="group">группа</param>
        public Student(string lastname, string firstname,  string middlename, int age, string group)
        {
            id = Guid.NewGuid();
            this.firstname = firstname;
            this.lastname = lastname;
            this.middlename = middlename;
            this.age = age;
            this.group = group;
            Console.WriteLine($"Создана карточка студента: {lastname} {firstname[0]}.{middlename[0]}");
        }

        public Student(string lastname, string group)
        {
            id = Guid.NewGuid();
            this.lastname = lastname;
            this.group = group;
            Console.WriteLine($"Создана карточка студента: {lastname}");
        }

        public Student(Student student)
        {
            id = Guid.NewGuid();
            firstname = student.firstname;
            lastname = student.lastname;
            middlename = student.middlename;
            age = student.age;
            group = student.group;
            Console.WriteLine($"Выполенено копирование карточки стдента {lastname} {firstname[0]}.{middlename[0]}");
        }

        private Guid id;
        private string firstname;
        private string lastname;
        private string middlename;
        private int age;
        private string group;

        /// <summary>
        /// Выводит в консоль информацию о студенте
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Информация о студенте: {lastname} {firstname[0]}.{middlename[0]}.");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Имя: {firstname}");
            Console.WriteLine($"Фамилия: {lastname}");
            Console.WriteLine($"Отчество: {middlename}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Группа: {group}");
        }
        /// <summary>
        /// Меняет фамилию студента
        /// </summary>
        /// <param name="newLastname">Новая фамилия студента</param>
        public void ChangeLastname(string newLastname)
        {
            lastname = newLastname;

            Console.WriteLine($"Фамилия была изменена на: {newLastname}");
        }

        /// <summary>
        /// Выводит в консоль ФИО студента
        /// </summary>
        public string GetFullName()
        {
            return $"{lastname} {firstname} {middlename}";
        }
    }
}
