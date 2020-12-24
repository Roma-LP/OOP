using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_05
{
    abstract class Organization    // Организация
    {
        public string Name { get; set; } = "NoName";
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

        public void example()
        {
            Console.WriteLine($"Document IFunk.example() пример реализации интерфейса");
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
        public override void info()
        {
            //Console.WriteLine($"info() Waybill ->  Name: \t{Name}" +
            //    $"\n\t Product: \t{Product}\n" +
            //    $"\t CountProduct: {CountProduct}");
            Console.WriteLine($"info() " + ToString());
        }

        public override string ToString()
        {
            return $"Waybill ->  Name: \t{Name}\n\t Product: \t{Product}\n\t CountProduct: {CountProduct}";
        }
    }


    sealed class Receipt : Waybill, IFunk   // Квитанция
    {
        public int ID;
        public Receipt(string Name, string Product, int CountProduct, int ID) : base(Name,Product,CountProduct)
        {
            this.ID = ID;
        }
        public override int GetHashCode()
        {
            Console.Write("Receipt -> GetHashCode() ");
            return ID.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Receipt pr = obj as Receipt;  // попытка преобразования к определенному типу
            if (pr == null)
                return false;

            return pr.ID == this.ID;
        }
        public override string ToString()
        {
            return $"Receipt ->  Name: \t{Name}\n\t Product: \t{Product}\n\t CountProduct: {CountProduct}" +
                $"\n\t ID: \t{ID}";
        }
    }


    class Printer
    {
        public void IAmPrinting(Organization obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
