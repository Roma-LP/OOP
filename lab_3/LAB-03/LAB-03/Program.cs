using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_03
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Product[] PRDCT = new Product[8];
            PRDCT[0] = new Product("Сыр");
            PRDCT[1] = new Product("Сметана");
            PRDCT[2] = new Product("45");
            PRDCT[3] = new Product("Молоко",14231,"Савушкин продукт", 23,67,2);
            PRDCT[4] = new Product("Сыр",-39,"ОЛ",-87,0,-1);
            PRDCT[5] = new Product("Сыр",4781,"Молочное",15,8,30);
            PRDCT[6] = new Product("Сыр",3489,"Вкусное",36,3,41);
            PRDCT[7] = new Product();
            short count = 0;
            foreach(Product i in PRDCT)
            {
                Console.WriteLine($"PRDCT[{count}]");
                i.Info();
                count++;
            }
            Product.InfoArray(); // вызов static метода

            Console.WriteLine("\nСписок товаров для заданного наименования:");
            for(int i=0;i<PRDCT.Count();i++)
            {
                if (PRDCT[i].NAME == "Сыр")
                    PRDCT[i].Info();
            }
            Console.WriteLine("\nСписок товаров для заданного наименования, цена которых не превосходит заданную:");
            for (int i = 0; i < PRDCT.Count(); i++)
            {
                if (PRDCT[i].NAME == "Сыр" && PRDCT[i].PRICE<=20)
                    PRDCT[i].Info();
            }

            Product.RefChangeProduct(ref PRDCT[7],ref PRDCT[3]);    // использование модификатора ref
            Console.WriteLine($"\nPRDCT[7]");
            PRDCT[7].Info();
            Console.WriteLine($"\nPRDCT[3]");
            PRDCT[3].Info();
            for (int i = 0; i < Product.CountArray; i++)
            {
                Product.PriceAllConut(out string namfe, PRDCT[i], out int sum);           // использование модификатора out
                Console.WriteLine($"{i}) {namfe} - {sum}");
            }

            var AnonymousType = new { id = 548, name = "хлеб" };    // анонимный тип
            Console.WriteLine($"Анонимный тип: {AnonymousType.id} - {AnonymousType.name}");

        }
        
        
    }

   
}
