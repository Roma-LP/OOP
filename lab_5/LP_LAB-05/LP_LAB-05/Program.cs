using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection CL = new Collection();
            Toy t1 = new Toy(54,"Машинка",6);
            CL.Add(t1);
            Cake c1 = new Cake(2400, "Наполеон", 2);
            CL.Add(c1);
            Strawberry s1 = new Strawberry(25,"Большая клубника",100);
            CL.Add(s1);
            NotTovar er = new NotTovar();
            CL.Add(er);

            CL.Print();
            Console.WriteLine(CL.Count());
            CL.PrintAt(1);

            CL.DeleteLast();
            Console.WriteLine(CL.Count());
            CL.DeleteLast();
            Console.WriteLine(CL.Count());
            CL.Print();
            

        }
    }
}
