using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_09
{
    class Program
    {
        public delegate void DoSomoeone(string str);
        static void Main(string[] args)
        {
            // DoSomoeone DS1 = MethodOne;
            // var DS2 = new DoSomoeone(MethodOne);
            Collection<Tovar> CL = new Collection<Tovar>();
            Toy t1 = new Toy(54, "Машинка", 6);
            CL.Add(t1);
            Cake c1 = new Cake(2400, "Наполеон", 58);
            CL.Add(c1);
            Strawberry s1 = new Strawberry(25, "Большая клубника", 100);
            CL.Add(s1);
            CL.Print();
            Console.WriteLine("Количесвто:\t" + CL.Count());

            CL.DeleteLast();
            CL.Print();
            Console.WriteLine("Количесвто:\t" + CL.Count());
            //CL.FirstOrDefault();

            EventArgs EA = new EventArgs("re", 4);
            EA.DO += MethodTwo;
            EA.DO += MethodOne;
            EA.AddSum(50);
            EA.RemoveSum(23);

            Func<Tovar, string> condition = MethodFunk;
            IEnumerable<string> items = CL.FunctionFunc(condition);
            foreach (var it in items)
                Console.WriteLine(it);
            Predicate<Tovar> Tov = MethodPredicate;
            List<Tovar> list = CL.FindAll(Tov);
            foreach (var it in list)
            {
                CL.Add(it);
            }
            CL.Print();
            Action<Tovar> act = MethodAction;
            CL.FunctionAction(act);



        }
        public static void MethodOne(string message, int sum)
        {
            int x = 1, y = 6;
            Console.ForegroundColor = ConsoleColor.DarkGreen; // устанавливаем цвет
            Console.WriteLine($"Опа, выполнился MethodOne. Произошел {message + sum}. И числа {x} + {y} = {x + y}");
            Console.WriteLine(message + sum);
            Console.ResetColor(); // сбрасываем в стандартный
        }
        public static void MethodTwo(string message, int sum)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen; // устанавливаем цвет
            Console.WriteLine(message + sum);
            Console.ResetColor(); // сбрасываем в стандартный
        }
        public static string MethodFunk(Tovar tovar)
        {
            return tovar.Name;
        }
        static public bool MethodPredicate(Tovar tovar)
        {
            return tovar.Count >= 50;
        }
        static public void MethodAction(Tovar tovar)
        {
            if (tovar.Count >= 3)
                Console.WriteLine($"У товара {tovar.Name} >= {tovar.Count} количества товаров");
        }
    }
}
