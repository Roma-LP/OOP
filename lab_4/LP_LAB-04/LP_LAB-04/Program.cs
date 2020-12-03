using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_04
{
    class Program
    {
        static void Main(string[] args)
        {
            RightTriangle RT1 = new RightTriangle(5, 7, 3);
            RightTriangle RT2 = new RightTriangle(4, 9, 6);
            RightTriangle RT3 = new RightTriangle();
            Console.WriteLine(RT1.ToString());
            Console.WriteLine(RT2.ToString());
            Console.WriteLine(RT3.ToString());

            if (RT1 < RT2)
            {
                Console.WriteLine("RT1 < RT2 - true");
            }
            if (RT1 > RT2)
            {
                Console.WriteLine("RT1 > RT2 - true");
            }

           //int x1 = RT1;
            int x2 = (int)RT1;

            RightTriangle RT4 = RT1 + RT2;
            Console.WriteLine(RT4.ToString());

            Console.WriteLine("\n--------------------------------------\n");
            ListRightTriangles lrt = new ListRightTriangles();
            RightTriangle RT5 = new RightTriangle(2,3,-6);
            RightTriangle RT6 = new RightTriangle(7,-9,12);
            lrt.Add(RT5);
            lrt.Add(RT6,"Гоголь");
            lrt.Print();
            lrt.DeleteLast();
            lrt.Print();
        }   
    }
}
