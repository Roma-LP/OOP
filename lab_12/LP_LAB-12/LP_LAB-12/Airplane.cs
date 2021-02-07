using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_12
{
    class Airplane
    {
        public static short count;
        private int pole;
        public string Name;
        public int Speed;
        public string From;
        public string To;
        private string smtprv;

        private int proppriv { get; set; }
        public int proppubl { get; set; }

        public void methodpublic() { }
        private void methodprivate() { }

        public Airplane(string name,int speed, string from, string to)
        {
            Name = name;
            Speed = speed;
            From = from;
            To = to;
            count++;
        }

        public Airplane()  
        {
            count++;
        }

        static Airplane()  //без параметров и доступа
        {
            Console.WriteLine("Поздравляю!!! Был создан первый самолет\n");
        }

        public void PrintData()
        {
           // Console.WriteLine("\nКоличесвто экземпляров:\t"+count);
            Console.WriteLine("Имя самолета:\t\t"+Name);
            Console.WriteLine("Скорость:\t\t"+ Speed+"\n");
            Console.WriteLine("Летит из:\t\t"+ From+"\n");
            Console.WriteLine("Летит в:\t\t"+ To+"\n");
        }

        public Airplane(Airplane plane)
        {
            Name = plane.Name;
            Speed = plane.Speed;
            From = plane.From;
            To = plane.To;
            count++;
        }

        public override string ToString()
        {
            return Name+" Мой метод";
        }

        ~Airplane()
        {
            count--;
            Console.WriteLine("Деструктор был активирован. Осталось:\t"+count);
        }
    }
}
