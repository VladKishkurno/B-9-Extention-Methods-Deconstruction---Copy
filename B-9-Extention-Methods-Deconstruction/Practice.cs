using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Lesson_9.Practice
{
    public static class Practice
    {
        struct Coordinate
        {
            public int x;
            public int y;
            public int z;

            public void Deconstruct(out int x, out int y, out int z, out double vector)
            {
                x = this.x;
                y = this.y;
                z = this.z;
                vector = Math.Sqrt(x*x+y*y+z*z);
            }
        }


        /// <summary>
        /// L9-P-EX-1/2
        /// Создать структуру Coordinates (трехмерных). 
        /// Добавить экземплярный метод деконструкции значений координат.
        /// Вывести на консоль длину вектора по координатам.
        /// </summary>
        public static void L9_P_EX_1_from_2()
        {
            var coordinate1 = new Coordinate() { y = 1, x = 7, z = 9};
            var (_, _, _, result) = coordinate1;
            Console.WriteLine(result);
            
        }

        /// <summary>
        /// L9-P-EX-2/2. 
        /// Создать деконструктор для обьекта DateTime 
        /// (год, месяц, день, час, минуты, секунды). 
        /// Получить и вывести на консоль текущее время.
        /// Использовать пустые параметры.
        /// </summary>
        public static void L9_P_EX_2_from_2()
        {
            var dayTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour , DateTime.Now.Minute, DateTime.Now.Second );
            var (_, _, _, hour, minute, seconds) = dayTime;
            Console.WriteLine($" {hour} : {minute} : {seconds}");
        }
    }
}
