using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_08
{
    class Collection<T> where T:Tovar
    {
        public List<T> AL = new List<T>();
        //ArrayList AL = new ArrayList();
        public void Add(T tv)
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
            foreach(T tv in AL)
            {
                tv.Display();
            }
        }
        public T FirstOrDefault(Func<T, bool> predicate)
        {
            return AL.FirstOrDefault(predicate);
        }
    } 
}
