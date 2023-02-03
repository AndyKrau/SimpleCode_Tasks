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
            _id = Guid.NewGuid();
            _firstname = firstname;
            _lastname = lastname;
            _middlename = middlename;
            _age = age;
            _group = group;
            Console.WriteLine($"Создана карточка студента: {_lastname} {_firstname[0]}.{_middlename[0]}");
        }

        public Student(string lastname, string group)
        {
            _id = Guid.NewGuid();
            _lastname= lastname;
            _group = group;
            Console.WriteLine($"Создана карточка студента: {_lastname}");
        }

        public Student(Student student)
        {
            _id = Guid.NewGuid();
            _firstname = student._firstname;
            _lastname = student._lastname;
            _middlename = student._middlename;
            _age = student._age;
            _group = student._group;
            Console.WriteLine($"Выполенено копирование карточки стдента {_lastname} {_firstname[0]}.{_middlename[0]}");
        }

        private Guid _id;
        private string _firstname;
        private string _lastname;
        private string _middlename;
        private int _age;
        private string _group;

        /// <summary>
        /// Выводит в консоль информацию о студенте
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Информация о студенте: {_lastname} {_firstname[0]}.{_middlename[0]}.");
            Console.WriteLine($"ID: {_id}");
            Console.WriteLine($"Имя: {_firstname}");
            Console.WriteLine($"Фамилия: {_lastname}");
            Console.WriteLine($"Отчество: {_middlename}");
            Console.WriteLine($"Возраст: {_age}");
            Console.WriteLine($"Группа: {_group}");
        }
        /// <summary>
        /// Меняет фамилию студента
        /// </summary>
        /// <param name="newLastname">Новая фамилия студента</param>
        public void ChangeLastname(string newLastname)
        {
            _lastname = newLastname;

            Console.WriteLine($"Фамилия была изменена на: {newLastname}");
        }

        /// <summary>
        /// Выводит в консоль ФИО студента
        /// </summary>
        public string GetFullName()
        {
            return $"{_lastname} {_firstname} {_middlename}";
        }
    }
}
