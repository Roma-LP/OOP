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
            if(char.IsUpper(str[0])) result++;
            for (int i=1;i<str.Length;i++)
            {
                if(char.IsUpper(str[i]) )
                {
                    if(str[i-1].Equals(' '))
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}
