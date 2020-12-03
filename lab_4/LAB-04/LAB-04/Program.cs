using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_04
{
    class Program
    {
        static void Main(string[] args)
        {


            List example = new List("Первое слово Vffv fvfv FVFV VFV", "Второе слово");
           
           
            List ex2 = new List("Tretee slovo", "4 slovo");

            if (example == ex2) Console.WriteLine("ravni");

            ex2.Add("deed");

            if (example != ex2) Console.WriteLine("ne ravni");

            Console.WriteLine(example[0]);
            Console.WriteLine(example[0].CountUpperWords());




        }
    }
}
