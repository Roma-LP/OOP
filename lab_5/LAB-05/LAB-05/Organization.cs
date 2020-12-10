using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_05
{
    abstract class Organization    // Организация
    {
        public /*virtual*/ string Name { get; set; } = "NoName";
        public abstract void info();
        public override string ToString()
        {
            return $"abstract Organization -> Name: {Name}";
        }
    }


    class Document : Organization, IFunk   // Документ
    {
        public Document(string Name)
        {
            this.Name = Name;
        }

        public override void info()
        {
            Console.WriteLine($"info() Document -> {Name}");
        }

        void IFunk.info()
        {
            Console.WriteLine($"IFunk.info() Document -> {Name}");
        }

        public override string ToString()
        {
            return $"Document ->  Name: {Name}";
        }
    }


    class Waybill : Document, IFunk   // Накладная
    {
        public string Product;
        public int CountProduct;
        public Waybill(string Name, string Product, int CountProduct) : base(Name)
        {
            this.Name = Name;
            this.Product = Product;
            this.CountProduct = CountProduct;
        }
        public void info()
        {
            Console.WriteLine($"info() Waybill ->  Name: \t{Name}" +
                $"\n\t Product: \t{Product}\n" +
                $"\t CountProduct: {CountProduct}");
        }

        public override string ToString()
        {
            return $"Waybill ->  Name: \t{Name}\n\t Product: \t{Product}\n\t CountProduct: {CountProduct}";
        }
    }
}
