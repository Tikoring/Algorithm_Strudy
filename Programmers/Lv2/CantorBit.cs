using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Programmers.Lv2.Problem
{
    public class CantorBit
    {
        public int Solution(int n, long l, long r) 
        {
            int answer = 0;
            answer  = (int) MakeCantor (n, l - 1, r - 1);
            return answer;
        }

        private long MakeCantor (int n, long l, long r)
        {
            long part = (long) Math.Pow (5, n - 1);
            long val = (long) Math.Pow (4, n - 1);
            long re  = 0;
            int s = (int) (l / part);
            int e = (int) (r / part);
            if (part == 1)
            {
                for (int i = s; i <= e; i++)
                {
                    if (i == 2) continue;
                    re += val;
                }
            }
            else 
            {
                for (int i = s; i <= e; i++)
                {
                    if (i == 2) continue;
                    re += val;
                }
                if (l % part != 0 && s != 2)
                {
                    re -= MakeCantor (n - 1, 0, l - part * s - 1);
                }
                if (r % part != part - 1 && e != 2)
                {
                    re -= MakeCantor (n - 1, r - part * e + 1, part - 1);
                }
            }

            return re;
        }
    }
}