using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Date_Extension
{
    /// <summary>
    /// Extension методы для класса DateTime. Вывод текущей даты и проверка является ли день из параметра текущим днём
    /// </summary>
    static class CurrentTime_Extension
    {
        public static void Print(this DateTime dateTime)
        {
            Console.WriteLine("Текущая дава и время:" + dateTime);
        }

        public static bool IsDayOfWeek(this DateTime dateTime, DayOfWeek yourDay)
        {
           if (dateTime.DayOfWeek == yourDay)
            {
                Console.WriteLine("Да, сегодня " + yourDay);
                return true;
            }
           else
            {
                Console.WriteLine("Нет, сегодня " + dateTime.DayOfWeek);
                return false;
            }
        }
    }
}

