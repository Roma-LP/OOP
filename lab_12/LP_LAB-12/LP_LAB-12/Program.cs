using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LP_LAB_12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Airplane a1 = new Airplane("aa", 850, "Минск", "Пекин");
                Reflector.Analyse(a1, @"C:\БГТУ\ООТП\lab_12\LP_LAB-12\Infornation.json");
                object[] param = { "bb", 600, "Минск", "Париж" };
                object[] param2 = { };
                var test = Reflector.Create<Airplane>(a1, param);
                Console.WriteLine(test);
                Reflector.Invoke(a1, "PrintData", param2);
                Reflector.Invoke(a1, "PrintData", param2, param);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
        }
    }
}
