using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_lesson_extention
{
    /// <summary>
    /// Защищенный класс для наследования
    /// </summary>
    sealed class Student
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
    }
}
