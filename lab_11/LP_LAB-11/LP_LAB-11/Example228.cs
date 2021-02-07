using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_11
{
    class Example228
    {
        public class Point
        {
            public int x = 10;
            public int y = 20;
            public int Sum()
            { return x + y; }
        }
        public class ColorPoint : Point
        {
            public int color = 78;
            public new int Sum()
            {
                return x * y * color;
            } 
}
        private static void Main(string[] args)
        {
            Point a12 = new Point();
            Console.WriteLine(a12.Sum()); //30
            ColorPoint ca100 = new ColorPoint();
           a12 = ca100;
            Console.WriteLine(a12.Sum());//30 //  вызов методов по типу ссылки
        }

    }
}
