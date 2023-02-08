using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SC_lesson_extention;

namespace Student_extention
{
    /// <summary>
    /// Extention метод для класса Student 
    /// </summary>
    static class StudentExtention
    {
        public static string GetFullName(this Student student)
        {
            return student.LastName + " " + student.FirstName;
        }
    }
}
