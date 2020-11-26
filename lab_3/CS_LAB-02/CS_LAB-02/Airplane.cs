using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_LAB_02
{
    class  Airplane
    {
        public static short count;
        public int pole;
        string name;
        int wheels;

        public string Name
        {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public int Wheels
        {
            get
            {
                return wheels;
            }
            set
            {
                switch(value)
                {
                    case 1:
                    case 2:
                    case 3: { wheels = value; break; }
                    default:
                        {
                            Console.WriteLine("Слишком много колес. Урезано до 3. Использавн set");
                            wheels = 3;
                            break;
                        }
                }
            }
        }

        public Airplane()  
        {
            count++;
        }

        public Airplane(string name, int wheels)
        {
            Name = name;
            Wheels = wheels;
            count++;
        }

        static Airplane()  //без параметров и доступа
        {
            Console.WriteLine("Поздравляю!!! Был создан первый самолет");
        }

        public void PrintData()
        {
            Console.WriteLine("\nКоличесвто экземпляров:\t"+count);
            Console.WriteLine("Имя самолета:\t\t"+name);
            Console.WriteLine("Количесвто колес:\t"+ wheels+"\n");
        }

        public Airplane(Airplane plane)
        {
            Name = plane.name;
            Wheels = plane.wheels;
            count++;
        }

        public override string ToString()
        {
            return name+" Мой метод";
        }

        ~Airplane()
        {
            Console.WriteLine("Деструктор был активирован");
        }
    }
}
