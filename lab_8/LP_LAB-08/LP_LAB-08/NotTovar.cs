using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_08
{
    class NotTovar<T>
    {
        T umolchaniu = default(T);
        T somth;
        public void Display()
        {
            Console.WriteLine($"Umolchaniu: {umolchaniu} ");
            Console.WriteLine($"Somth: {somth} ");
        }
        public T Somth
        {
            get { return somth; }
            set { somth = value; }
        }
    }
}
