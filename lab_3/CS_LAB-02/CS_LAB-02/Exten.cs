using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_LAB_02
{
    static class Exten
    {
        public static int CountSimbol(this string str, char c)
        {
            int count =0;
            for (int i=0;i<str.Length;i++)
            {
                if (str[i] == c)
                    count++;
            }
            return count;
        }

        public static double Exponent(this double side,int n)
        {
            double arg = side;
            if (n > 0)
            {
                for (int i = 1; i < n; i++)
                {
                    side = side * arg;
                }
                return side;
            }
            else
            {
                if (n < 0)
                {
                    for (int i = 1; i < -n; i++)
                    {
                        side = side * arg;
                    }
                    return 1 / side;
                }
                else
                    return 1;
            }
        }
    }
}
