using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Waybill wb = new Waybill("odin", "House", 3);
            Console.WriteLine(wb.ToString());
            wb.info();
            Document dc = new Document("Secret");
            ((IFunk)dc).info();
            dc.info();

            Console.WriteLine("-------------------------------------------------");
            Document doc1 = new Document("Car");
            Waybill wb1 = new Waybill("Plane", "FlexAir", 3);
            Receipt rec1 = new Receipt("Bike","BMX",6,14587);
            Receipt rec2 = new Receipt("Table","KL-521",4, 14587);
            Organization[] organ = new Organization[] { doc1, wb1, rec1,rec2 };
            Printer printer = new Printer();
            for (int i = 0; i < organ.Length; i++)
            {
                Console.Write($"{i+1}) ");
                printer.IAmPrinting(organ[i]);
            }
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine( rec1.GetHashCode() );
            Console.WriteLine( rec1.ToString() );
            if(rec1.Equals(rec2))
            {
                Console.WriteLine($"{rec1.ID} == {rec2.ID}");
            }
            else
            {
                Console.WriteLine($"{rec1.ID} != {rec2.ID}");
            }

            Console.WriteLine("-------------------------------------------------");
            IFunk interf = printer as IFunk;  // привдение экзепляра к интрефейсу
          //IFunk interf = wb1 as IFunk;
            if (interf != null)
            {
                Console.WriteLine("Поддерживается IFunk");
            }
            else
            {
                Console.WriteLine("IFunk не поддерживается");
            }

            if (wb1 is IFunk)
                Console.WriteLine("IFunk реализован");
            else
                Console.WriteLine("IFunk не реализован");

        }
    }
}
