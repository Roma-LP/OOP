using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_09
{
    class Cake : Tovar
    {
        int Kkal{ get; set; }
        Cake(int kkal) : base("Unknow",1)
        {
            Kkal = kkal;
        }
        public Cake(int kkal, string name, int count) : base(name,count)
        {
            Kkal = kkal;
        }

        public override void Display()
        {
            base.Display();
            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
            Console.WriteLine("Количество килокалорий:\t"+Kkal);
            Console.ResetColor(); // сбрасываем в стандартный
        }
    }
}
