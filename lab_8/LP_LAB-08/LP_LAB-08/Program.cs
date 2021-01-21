using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection<Tovar> CL = new Collection<Tovar>();
            Toy t1 = new Toy(54,"Машинка",6);
            CL.Add(t1);
            Cake c1 = new Cake(2400, "Наполеон", 58);
            CL.Add(c1);
            Strawberry s1 = new Strawberry(25,"Большая клубника",100);
            CL.Add(s1);

            NotTovar<int> er = new NotTovar<int>();
            er.Somth = 5;
            er.Display();
            int x = 1, y = 2;
            string xx = "one", yy = "two";
            Swap<int>(ref x, ref y);
            Swap<string>(ref xx, ref yy);
            Console.WriteLine($"x={x} y={y}");
            Console.WriteLine($"xx={xx} yy={yy}");

            //CL.Add(er);
            CL.Print();
            Console.WriteLine("Количесвто:\t"+CL.Count());
            CL.DeleteLast();
            CL.Print();
            Console.WriteLine("Количесвто:\t" + CL.Count());
            CL.DeleteLast();
            CL.Print();
            Console.WriteLine("Количесвто:\t" + CL.Count());

            Func<Tovar, bool> condition = SortMoreThanFiveName;
            CL.FirstOrDefault(condition);

           // CollectionController CL2 = new CollectionController();
           // CL2 =CL.FindAll();
        }

        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        static public bool SortMoreThanFiveName(Tovar tovar)
        {
            return tovar.Name.Length > 5;
        }
    }
}
