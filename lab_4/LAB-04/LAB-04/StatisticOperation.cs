using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_04
{
    public static class StatisticOperation
    {
        public static int CountUpperWords(this string str)  //  количества слов с заглавной буквы
        {
            int result = 0;
            if (char.IsUpper(str[0])) result++;
            for (int i = 1; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    if (str[i - 1].Equals(' '))
                    {
                        result++;
                    }
                }
            }
            return result;
        }
        public static bool CheckRepeat(this List st) //  проверка на повторяющиеся элементы в списке
        {
            List pr = new List();
            pr.Add(st);
            for (int i = 0; i < pr.count; i++)
            {
                for (int j = i+1; j < pr.count; j++)
                {
                    if (CutDate(pr[i]).Equals(CutDate(pr[j])))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static int LengthList(this List st)  //  подсчет количества элементов(длина всего списка)
        {
            List pr = new List();
            pr.Add(st);
            int sum = 0;
            for (int i = 0; i < pr.count; i++)
            {
                sum+=CutDate(pr[i]).Length;
            }
            return sum;
        }

        static string CutDate(string str)
        {
            for (int j = 0; j < 3; j++)
            {
                int i = str.LastIndexOf(':');
                str=str.Remove(i - 1);
            }
            return str;
        }
    }
}
