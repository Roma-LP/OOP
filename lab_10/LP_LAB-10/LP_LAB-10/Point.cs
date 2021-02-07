using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_10
{
    class Point
    {
        public int X, Y, Z;
        public string Name;
        static int count = 1;
        public Point(int x, int y,int z, string name)
        {
            X = x;
            Y = y;
            Z = z;
            Name = name;
            count++;
        }

        public Point()
        {
            Name = "Defult"+count;
            count++;
        }

        public void DisplayInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // устанавливаем цвет
            Console.WriteLine($"Name Point:\t{Name}");
            Console.ResetColor(); // сбрасываем в стандартный
            Console.WriteLine($"X Point:\t{X}");
            Console.WriteLine($"Y Point:\t{Y}");
            Console.WriteLine($"Z Point:\t{Z}");
        }
    }
}
