using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_14
{
    [Serializable]
    public class Point
    {
        public int X;
        public int Y;
        public int Z;
        public string Name;

        public Point(int x, int y,int z, string name)
        {
            X = x;
            Y = y;
            Z = z;
            Name = name;
        }

        public Point()
        {

        }
      


        public void DisplayInfo()
        {
            Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет
            Console.WriteLine($"Name Point:\t{Name}");
            Console.ResetColor(); // сбрасываем в стандартный
            Console.WriteLine($"X Point:\t{X}");
            Console.WriteLine($"Y Point:\t{Y}");
            Console.WriteLine($"Z Point:\t{Z}");
        }
    }
}
