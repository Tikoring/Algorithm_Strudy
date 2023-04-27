using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class IntegerSqrt
    {
        public long Solution(long n) 
        {
            long answer = 0;
            long s = (long) Math.Sqrt (n);
            if (s * s == n) s += 1;
            else s = -1;
            answer = s < 0 ? s : s * s;
            return answer;
        }
    }
}