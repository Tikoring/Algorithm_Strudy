using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class CirclesIntervalIntPair
    {
        public long Solution(int r1, int r2) 
        {
            long answer = 0;
            for (long i = 1; i <= r2; i++)
            {
                long s = 0;
                long e = 0;
                if (i < r1)
                {
                    s = (long) Math.Ceiling (Math.Sqrt (Math.Pow (r1, 2) - i * i));
                    e = (long) Math.Floor (Math.Sqrt (Math.Pow (r2, 2) - i * i));
                }
                else 
                {
                    s = 0;
                    e = (long) Math.Floor (Math.Sqrt (Math.Pow (r2, 2) - i * i));
                }
                answer += e - s + 1;
            }
            answer *= 4;
            return answer;
        }
    }
}
