using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_09
{
    class EventArgs
    {
        public delegate void DoOperation(string _name,int _sum);
        public event DoOperation DO;


        public EventArgs(string Name, int Sum) 
        {
            sum = Sum;
            name = Name;
        }

        int sum;
        string name;
        public int ex;

        public void Info() => Console.WriteLine("Name:\t" + name+ "\nSum:\t"+sum);
        public void AddSum(int _sum)
        {
            DO?.Invoke($"На счет поступило + ",_sum);   // 2.Вызов события 
            sum = sum + _sum;
        }
        public void RemoveSum(int _sum)
        {
            if(_sum<=sum)
            {
                DO?.Invoke($"С счет сняли - ", _sum);   // 2.Вызов события
                sum = sum + _sum;
            }
        }
        public void ChangeName(string _name)
        {
            name = _name;
        }
    }
}
