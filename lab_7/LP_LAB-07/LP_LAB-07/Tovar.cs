using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_07
{
    public abstract class Tovar
    {
       public string Name { get; set; }
       public int Count { get; set; }

       public Tovar(string name, int count)
       {
            Name = name;
            Count = count;
       }

       public virtual void Display()
       {
           Console.WriteLine("Наименование товара:\t"+Name);
           Console.WriteLine("Количество товара:\t"+Count);
       }


    }
}
