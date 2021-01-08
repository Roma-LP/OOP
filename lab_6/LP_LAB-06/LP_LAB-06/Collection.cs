using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_06
{
    class Collection
    {
        public List<Tovar> AL = new List<Tovar>();
        //ArrayList AL = new ArrayList();
        public void Add(Tovar tv)
        {
            AL.Add(tv);
        }
        public int Count()
        {
            return AL.Count;
        }
        public void DeleteLast()
        {
            AL.RemoveAt(AL.Count - 1);
        }
        public void Print()
        {
            foreach(var tv in AL)
            {
               tv.Display();
            }
        }
    
    } 
}
