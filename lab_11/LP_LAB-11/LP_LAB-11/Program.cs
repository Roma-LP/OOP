using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_11
{
    class Program
    {

        static void Main(string[] args)
        {
            Airplane a1 = new Airplane("aa", 850, "Минск", "Пекин");
            Airplane b2 = new Airplane("bb", 890, "Гродно", "Каир");
            Airplane c3 = new Airplane("cc", 810, "Москва", "Минск");
            Airplane d4 = new Airplane("dd", 900, "Париж", "Антананариву");
            Airplane e5 = new Airplane("ee", 600, "Минск", "Париж");
            Airplane f6 = new Airplane("ff", 740, "Минск", "Гродно");
            Airplane g7 = new Airplane("gg", 940, "Антананариву", "Анкара");
            Airplane h8 = new Airplane("hh", 830, "Каир", "Могилев");
            Airplane i9 = new Airplane("ii", 490, "Анкара", "Минск");
            Airplane k10 = new Airplane("kk", 660, "Минск", "Каир");
            Airplane l11 = new Airplane("ll", 760, "Минск", "Каир");
            Airplane m12 = new Airplane("mm", 870, "Минск", "Каир");
            Airplane n13 = new Airplane("nn", 690, "Минск", "Каир");
            List<Airplane> myList = new List<Airplane>() { a1, b2, c3, d4, e5, f6, g7, h8, i9, k10, l11, m12, n13 };

            //var otv = myList.Where(x => x.Speed > 1).OrderByDescending(x=>x.Wheels).Select(x => x.Wheels).Max();

            Console.ForegroundColor = ConsoleColor.DarkGreen; // устанавливаем цвет
            var MS = myList.Select(x => x.Speed).Max();
            Console.WriteLine("Максимальная скорость - " + MS);

            Airplane MaxSpeedPlane = myList.OrderByDescending(n => n.Speed).First();
            Console.WriteLine($"Имя самолета:\t{ MaxSpeedPlane.Name} ( {MaxSpeedPlane.Speed} ) {MaxSpeedPlane.From}-{MaxSpeedPlane.To}");

            var MS2 = (from msp in myList
                       select msp.Speed).Max();
            Console.WriteLine("Максимальная скорость - " + MS2);

            var MaxSpeedPlane2 = (from msp in myList // Использование синтаксиса выражения запроса 
                                  orderby msp.Speed descending
                                  select msp).First();
            Console.WriteLine($"Имя самолета:\t{ MaxSpeedPlane2.Name} ( {MaxSpeedPlane2.Speed} ) {MaxSpeedPlane2.From}-{MaxSpeedPlane2.To}");
            Console.ResetColor(); // сбрасываем в стандартный

            //---------------------------------------------------------------------------------------------------------------------------------

            Console.ForegroundColor = ConsoleColor.DarkMagenta; // устанавливаем цвет
            var MinSP5 = myList.OrderBy(x => x.Speed).Take(5);
            foreach (var i in MinSP5)
                Console.WriteLine($"Имя самолета:\t{ i.Name} ( {i.Speed} ) {i.From}-{i.To}");

            var MinSP52 = (from msp in myList
                           orderby msp.Speed
                           select msp).Take(5);
            foreach (var i in MinSP52)
                Console.WriteLine($"Имя самолета:\t{ i.Name} ( {i.Speed} ) {i.From}-{i.To}");
            Console.ResetColor(); // сбрасываем в стандартный

            //---------------------------------------------------------------------------------------------------------------------------------
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow; // устанавливаем цвет
            var NFM = myList.Where(x => x.From.Contains("Минск")).OrderBy(x => x.Speed);
            foreach (var i in NFM)
                i.PrintData();

            var NFM2 = from msp in myList // Использование синтаксиса выражения запроса
                       where msp.From.Contains("Минск")
                       orderby msp.Speed
                       select msp;
            foreach (var i in NFM2)
                i.PrintData();
            Console.ResetColor(); // сбрасываем в стандартный

            //---------------------------------------------------------------------------------------------------------------------------------

            Console.ForegroundColor = ConsoleColor.DarkCyan; // устанавливаем цвет
            var MMTB = myList.Where(x => x.Speed > 700 && x.From.Contains("Минск"));
            foreach (var i in MMTB)
                Console.WriteLine($"Имя самолета:\t{ i.Name} ( {i.Speed} ) {i.From}-{i.To}");

            var MMTB2 = from msp in myList
                        where msp.Speed > 700 && msp.From.Contains("Минск")
                        select msp;
            foreach (var i in MMTB2)
                Console.WriteLine($"Имя самолета:\t{ i.Name} ( {i.Speed} ) {i.From}-{i.To}");
            Console.ResetColor(); // сбрасываем в стандартный

        }
    }
}
