using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_08
{
    sealed class Toy:Tovar
    {
        int Price { get; set; }  
        Toy(int price) : base("Unknow", 1)
        {
            Price = price;
        }
        public Toy(int price, string name, int count) : base(name, count)
        {
            Price = price;
        }

        public override void Display()
        {
            base.Display();
            Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
            Console.WriteLine($"Количесвто цены:\t{Price}$");
            Console.ResetColor(); // сбрасываем в стандартный
        }
    }
}
