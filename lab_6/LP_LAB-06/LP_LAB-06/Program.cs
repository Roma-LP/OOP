using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_06
{
    class Program
    {
        enum Slovesno
        {
            Ras = 1,
            Dvas,
            Tris,
            Chetirers,
            Desyatis = 10,
            Odinatiris
        }

        static void Main(string[] args)
        {
            Slovesno sl;
            sl = Slovesno.Ras;
            Console.WriteLine(sl + " : " + (int)sl);
            int ex = 10;
            sl = (Slovesno)ex;
            Console.WriteLine(sl.GetType().Name + "." + sl.ToString().ToUpper());
            Console.WriteLine(sl + " : " + (int)sl);
            WriteEnum(Slovesno.Ras);
            WriteEnum(Slovesno.Dvas);
            WriteEnum(Slovesno.Odinatiris);
            Console.WriteLine("----------------------------------------------------------");

            CollectionController CL = new CollectionController("Vasa");
            Toy t1 = new Toy(54, "Машинка", 6);
            CL.Add(t1);
            Cake c1 = new Cake(2400, "Наполеон", 58);
            CL.Add(c1);
            Strawberry s1 = new Strawberry(25, "Большая клубника", 100);
            CL.Add(s1);
            NotTovar er = new NotTovar();
            //CL.Add(er);
            CL.Print();
            Console.WriteLine("Количесвто:\t" + CL.Count());
            CL.DeleteLast();
            CL.Print();
            Console.WriteLine("Количесвто:\t" + CL.Count());
            CL.DeleteLast();
            CL.Print();
            Console.WriteLine("Количесвто:\t" + CL.Count());

            Predicate<Tovar> Tov = SortMoreThan50;
            Func<Tovar, bool> Tov2 = FindLargeName;
            CL.Add(CL.FirstOrDefault(Tov2));
            List<Tovar> list = CL.FindAll(Tov);
            foreach (var it in list)
            {
                CL.Add(it);
            }
            CL.PrintAuthor();


            // CollectionController CL2 = new CollectionController();
            // CL2 =CL.FindAll();
        }
        static public bool FindLargeName(Tovar tovar)
        {
            return tovar.Name.Length > 5;
        }
        static public bool SortMoreThan50(Tovar tv)
        {
            return tv.Count >= 50;
        }

        static void WriteEnum(Slovesno sl)
        {
            switch (sl)
            {
                case Slovesno.Ras:
                    {
                        Console.WriteLine($"Вывели первое {Slovesno.Ras} и его номер {(int)Slovesno.Ras}");
                    }
                    break;
                case Slovesno.Dvas:
                    {
                        Console.WriteLine($"Вывели второе {Slovesno.Dvas} и его номер {(int)Slovesno.Dvas}");
                    }
                    break;
                case Slovesno.Tris:
                    {
                        Console.WriteLine($"Вывели третье {Slovesno.Tris} и его номер {(int)Slovesno.Tris}");
                    }
                    break;
                case Slovesno.Chetirers:
                    {
                        Console.WriteLine($"Вывели четвертое {Slovesno.Chetirers} и его номер {(int)Slovesno.Chetirers}");
                    }
                    break;
                case Slovesno.Desyatis:
                    {
                        Console.WriteLine($"Вывели десятое {Slovesno.Desyatis} и его номер {(int)Slovesno.Desyatis}");
                    }
                    break;
                case Slovesno.Odinatiris:
                    {
                        Console.WriteLine($"Вывели одинадцатое {Slovesno.Odinatiris} и его номер {(int)Slovesno.Odinatiris}");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
