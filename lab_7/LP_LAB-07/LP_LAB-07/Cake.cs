using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_07
{
    class Cake : Tovar , ISpecification
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

        public void Information()
        {
            Console.WriteLine("Торт: большой и вкусный");
        }
        public void Color()
        {
            Console.WriteLine("Цвет: шоколадный");
        }
        public int Something(int x)
        {
            Console.WriteLine($"Произошло что-то, {x} + 2 = {x+2}");
            return x;
        }
    }
}
