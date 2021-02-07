using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_16
{
    class Eratosfen
    {
        List<int> simple;

        public Eratosfen(int MaxNumber)
        {
            simple = new List<int>();
            for (int i = 1; i < MaxNumber; i++)
                simple.Add(i);
            DoEratosfen();
        }

        int Step(int Prime, int startFrom)
        {
            int i = startFrom + 1;
            int Removed = 0;
            while (i < simple.Count)
                if (simple[i] % Prime == 0)
                {
                    simple.RemoveAt(i);
                    Removed++;
                }
                else
                    i++;
            return Removed;
        }

        void DoEratosfen()
        {
            int i = 1;
            while (i < simple.Count)
            {
                Step(simple[i], i);
                i++;
            }
        }

        public List<int> Simple
        {
            get
            {
                return simple;
            }
        }
    }
}
