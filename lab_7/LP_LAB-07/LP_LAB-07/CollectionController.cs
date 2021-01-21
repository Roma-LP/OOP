using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_07
{
    class CollectionController: Collection<Tovar> , IEnumerable<Tovar>
    {
        /*public static bool operator < (Tovar RT1, Tovar RT2)
        {
            return RT1.Count < RT2.Count;
        }
        public static bool operator > (Tovar RT1, Tovar RT2)
        {
            return RT1.Count > RT2.Count;
        }*/
        public Tovar FirstOrDefault(Func<Tovar, bool> predicate)
        {
            return AL.FirstOrDefault(predicate);
        }

        Predicate<Tovar> pred = delegate (Tovar tv)
        {
            if (tv.Count >= 50)
                return true;
            else
                return false;
        };
        public List<Tovar> FindAll(Predicate<Tovar> pred)
        {
            List<Tovar> lt = AL.ToList();
            return lt.FindAll(pred);
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
            try
            {
                if (name.Length < 4)
                {
                    throw new Exception("Длина строки меньше 4 символов");
                }
            }
            catch
            {
                Console.WriteLine("Возникло исключение в CollectionController");
                throw;
            }
            NameData ND=new NameData(name);
        }
        public struct NameData
        {
            public NameData(string _name)
            {
                name = _name;
                dateTime = new DateTime();
            }
            private static string name;
            private readonly DateTime dateTime;
        }
    }
}
