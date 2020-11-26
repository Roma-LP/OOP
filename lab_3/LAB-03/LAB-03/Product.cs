using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_03
{
    partial class Product
    {
        private int id;         // ID
        private string name;    // Наименование
        private short upc;      // UPC (штрихкод)
        private string factory; // Производитель
        private int price;      // Цена
        private int data;       // Срок хранения (дней)
        private short count;    // Количество
        public static int CountArray = 0;
        public Product()
        {
            CountArray++;
        }
        public Product(int id, string name, short upc = 1549, string factory = "LOBIN", int price = 600, int data = 90, short count = 14)
        {
            ID = id;
            NAME = name;
            UPC = upc;
            FACTORY = factory;
            PRICE = price;
            DATA = data;
            COUNT = count;
            CountArray++;
        }
        static Product()
        {
            Console.WriteLine("Был вызван static конструктор");
        }
        public static void InfoArray()
        {
            Console.WriteLine($"Было создано {CountArray} продуктов класса Product");
        }
       
        public int ID           // ID
        {
            get
            {
                return id;
            }
            set
            {
                if (value > 0)
                    id = value;
                else id = -1;
            }
        }
        public string NAME         // Наименование
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length >= 3)
                    name = value;
                else name = "Сомнительно: " + value;
            }
        }
        public short UPC           // UPC (штрихкод)
        {
            get
            {
                return upc;
            }
            set
            {
                if (value > 0)
                    upc = value;
                else upc = -1;
            }
        }
        public string FACTORY         // производитель
        {
            get
            {
                return factory;
            }
            set
            {
                if (value.Length >= 3)
                    factory = value;
                else factory = "Сомнительно: " + value;
            }
        }
        public int PRICE           // Цена
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                    price = value;
                else price = -1;
            }
        }
        public int DATA           // Срок хранения (дней)
        {
            get
            {
                return data;
            }
            set
            {
                if (value > 0)
                    data = value;
                else data = -1;
            }
        }
        public short COUNT         // Количество
        {
            get
            {
                return count;
            }
            set
            {
                if (value >= 0)
                    count = value;
                else count = -1;
            }
        }

        

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
