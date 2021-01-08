using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_06
{
    class ClassContainer
    {
        List<Organization> Collect = new List<Organization>();

        public ClassContainer()
        {
        }
        public ClassContainer(params Organization[] org)
        {
            for(int i=0;i<org.Length;i++)
            {
                Collect.Add(org[i]);
            }
        }

        public void Add(Organization org)
        {
            Collect.Add(org);
        }
        public void Add(Organization[] org)
        {
            for (int i = 0; i < org.Length; i++)
            {
                Collect.Add(org[i]);
            }
        }
        public void Remove(Organization org)
        {
            Collect.RemoveAt(Collect.Count);
        }
        public void PrintAll()
        {
            foreach (Organization i in Collect)
                Console.WriteLine(i);
        }
        public void PrintAt(int i)
        {
            if (i <= Collect.Count && i>0)
                Console.WriteLine(Collect[i - 1]);
            else
                Console.WriteLine("Выход за пределы коллекции");
        }



    }
}
