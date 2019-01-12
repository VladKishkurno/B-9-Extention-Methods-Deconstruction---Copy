using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Lesson_9
{
        public static class DateTimeExtention
        {
            public static void Deconstruct(this DateTime d, out int year, out int month, out int day, out int hour, out int minute, out int seconds)
            {
                year = d.Year;
                month = d.Month;
                day = d.Day;
                hour = d.Hour;
                minute = d.Minute;
                seconds = d.Second;
            }
        }
}
