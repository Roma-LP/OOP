using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_05
{
    class Collection 
    {
        ArrayList AL = new ArrayList();
        public void Add(object tv)
        {
            if (tv is Tovar)
            {
                AL.Add(tv);
            }
            else
            {
                Console.WriteLine("Error:  Нельзя добавить  "+tv.GetType().Name);
            }
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
            foreach (Tovar tv in AL)
            {
                tv.Display();
                Console.WriteLine();
            }
        }
        public void PrintAt(int index)
        {
            int i =1;
            foreach (Tovar tv in AL)
            {
                if (i == index)
                {
                    tv.Display();
                    Console.WriteLine();
                    break;
                }
                i++;
            }
        }
        


    } 
   
}
