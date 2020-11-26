using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_LAB_02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string str1 = "1.9";

            NumberFormatInfo NFI = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            NumberFormatInfo NFI2 = new NumberFormatInfo();
            NFI2.NumberDecimalSeparator = ".";
            NFI2.CurrencyDecimalDigits = 5;
            Console.WriteLine(NFI2.CurrencyDecimalDigits);

            Console.WriteLine(Convert.ToDouble(str1,NFI));
            double a = Convert.ToDouble(str1, NFI2);
            Console.WriteLine(a);
            


            Airplane Boeing = new Airplane();
            Console.WriteLine(Boeing.Name);
            Boeing.Name = "A-254";
            Boeing.PrintData();

            Airplane Boeing2 = new Airplane("B-984",-7);
            Boeing2.PrintData();

            Airplane Boeing3 = new Airplane();
            Boeing3.Wheels = 9;
            Boeing3.PrintData();

            Console.WriteLine("Количесвто экземпляров:\t"+Airplane.count);
            

            Airplane Boeing4 = new Airplane(Boeing);
            Boeing4.PrintData();

            Console.WriteLine(Boeing2.ToString());

            Console.WriteLine("\nМетоды расширения");
            string str = "Привет, мой дорогой и однополый друг!!!";
            char c = 'о';
            int pr = str.CountSimbol(c);
            Console.WriteLine(pr);
            double dp = 3;
            double dp2;
            dp2 = dp.Exponent(4);
            Console.WriteLine(dp2);
            dp2 = dp.Exponent(-6);
            Console.WriteLine(dp2);
            dp2 = dp.Exponent(0);
            Console.WriteLine(dp2);

        }

    }
}
