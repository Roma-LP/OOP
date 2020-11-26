using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_03
{
    partial class Product
    {
        public void Info()
        {
            Console.WriteLine("ID:\t" + ID);
            Console.WriteLine("NAME:\t" + NAME);
            Console.WriteLine("UPC:\t" + UPC);
            Console.WriteLine("FACTORY:\t" + FACTORY);
            Console.WriteLine("PRICE:\t" + PRICE);
            Console.WriteLine("DATA:\t" + DATA);
            Console.WriteLine("COUNT:\t" + COUNT);
            Console.WriteLine("-------------------------");
        }
        public static void RefChangeProduct(ref Product pr1, ref Product pr2)
        {
            Product buf = pr1;
            pr1 = pr2;
            pr2 = buf;
        }
        public static void PriceAllConut(out string name, Product pr, out int sum)
        {
            sum = pr.COUNT * pr.PRICE;
            name = pr.NAME;
        }
    }
}
