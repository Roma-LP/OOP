using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------ 1 -------------------");
            List.Owner Exa = new List.Owner();
            Exa.Print(); 
            List.Owner Exa2 = new List.Owner(4,"go");
            Exa2.Print();
            List.Owner Exa3 = new List.Owner("for",7);
            Exa3.Print();

            Console.WriteLine("------------------ 2 -------------------");
            List example = new List("Первое слово", "Второе слово","efef ef e", "Первое слово");
            List example2 = new List("Первое слово", "Второе слово","Третье слово");
            if (example.CheckRepeat()) Console.WriteLine("Есть повторы");
            else Console.WriteLine("Нет повторов");
            if (example2.CheckRepeat()) Console.WriteLine("Есть повторы");
            else Console.WriteLine("Нет повторов");

            Console.WriteLine("------------------ 3 -------------------");
            List exa1 = new List("Первое", "слово","Три");  // 14 
            Console.WriteLine(exa1.LengthList());
            List exa2 = new List("Дом", "слово","Машина"); 
            if (exa1 == exa2) Console.WriteLine("ravni"); // по количеству элементов 
            exa2.Add("deed");
            if (exa1 != exa2) Console.WriteLine("ne ravni");

            Console.WriteLine("------------------ 4 -------------------");
            exa1--;
            exa1.print();
            Console.WriteLine("----");
            exa2 = exa2 + "плюс";
            exa2.print();
            Console.WriteLine("----");
            exa1 = exa1 * exa2;
            exa1.print();

            Console.WriteLine("------------------ 5 -------------------");
            List exa5 = new List("Первое cdcd DDC d CDD", " d DD TGслово","Три"); 
            Console.WriteLine(exa5[0]); // индексатор
            Console.WriteLine(exa5[0].CountUpperWords());
                                             
        }
    }
}
