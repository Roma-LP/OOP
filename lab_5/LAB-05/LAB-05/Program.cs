using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_05
{

    //public interface ICan
    //{
    //    void info();
    //}

    //abstract class candyBox
    //{
    //    public virtual int weight { get; set; } = 1500;
    //    public abstract void info();
    //    public override string ToString()
    //    {
    //        return $"total weight: {weight}";
    //    }
    //}

    //class pastry : candyBox, ICan
    //{
    //    public pastry(int weight)
    //    {
    //        this.weight = weight;
    //    }

    //    public override void info()
    //    {
    //        Console.WriteLine($"info: weight - {weight}");
    //    }

    //    void ICan.info()
    //    {
    //        Console.WriteLine($"weight - {weight}");
    //    }

    //    public override string ToString()
    //    {
    //        return $"pastry weight: {weight}";
    //    }
    //}

    //class cookie : pastry, ICan
    //{
    //    public int amountSugar;
    //    public cookie(int weight, int amountSugar) : base(weight)
    //    {
    //        this.weight = weight;
    //        this.amountSugar = amountSugar;
    //    }
    //    public void info()
    //    {
    //        Console.WriteLine($"\ninfo: weight - {weight}, sugar amount - {amountSugar}");
    //    }

    //    public override string ToString()
    //    {
    //        return $"cookie weight: {weight}, cookie sugar amount: {amountSugar}";
    //    }
    //}

    //class candy : pastry
    //{
    //    public candy(int weight) : base(weight)
    //    {
    //        this.weight = weight;
    //    }
    //    public override int GetHashCode()
    //    {
    //        return weight.GetHashCode();
    //    }
    //    public override string ToString()
    //    {
    //        return $"{weight}\n";
    //    }
    //    public override bool Equals(object obj)
    //    {
    //        if (obj == null)
    //            return false;
      
    //        candy m = obj as candy;
    //        if (m as candy == null)
    //            return false;

    //        return m.weight == this.weight;
    //    }
    //}

    //sealed class chocolateCandy : candy, ICan
    //{
    //    public int amountSugar;
    //    public chocolateCandy(int weight, int amountSugar) : base(weight)
    //    {
    //        this.weight = weight;
    //        this.amountSugar = amountSugar;
    //    }

    //    public void info()
    //    {
    //        Console.WriteLine($"\ninfo: weight - {weight}, sugar amount - {amountSugar}");
    //    }

    //    public override string ToString()
    //    {
    //        return $"chocolateCandy weight: {weight}, chocolateCandy sugar amount: {amountSugar}";
    //    }
    //}
    //sealed class caramel : candy, ICan
    //{
    //    public int amountSugar;
    //    public caramel(int weight, int amountSugar) : base(weight)
    //    {
    //        this.weight = weight;
    //        this.amountSugar = amountSugar;
    //    }
    //    public void info()
    //    {
    //        Console.WriteLine($"\ninfo: weight - {weight}, sugar amount - {amountSugar}");
    //    }

    //    public override string ToString()
    //    {
    //        return $"caramel weight: {weight}, caramel sugar amount: {amountSugar}";
    //    }
    //}

    //class Printer
    //{
    //    public virtual void IAmPrinting(candyBox obj)
    //    {
    //        Console.WriteLine(obj.ToString());
    //    }
    //}

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
