using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_06
{
    class CollectionController: Collection , IEnumerable<Tovar>
    {
        /*public static bool operator < (Tovar RT1, Tovar RT2)
        {
            return RT1.Count < RT2.Count;
        }
        public static bool operator > (Tovar RT1, Tovar RT2)
        {
            return RT1.Count > RT2.Count;
        }
        */
        NameData ND;
        public Tovar FirstOrDefault(Func<Tovar, bool> func)
        {
            return AL.FirstOrDefault(func);
        }
        public List<Tovar> FindAll(Predicate<Tovar> pred)
        {
            return AL.FindAll(pred);
        }

        public IEnumerator<Tovar> GetEnumerator()
        {
            throw new NotImplementedException();
        }
       
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


        public CollectionController(string name)
        {
            ND=new NameData(name);
        }
        public struct NameData
        {
            public NameData(string _name)
            {
                name = _name;
                dateTime = DateTime.Now;
            }
            public string name;
            public  DateTime dateTime;
        }

        public void PrintAuthor()
        {
            string date = ND.dateTime.ToString();
            string name = ND.name;
            Console.WriteLine(name +"  "+ date);
            Print();
        }
    }
}
