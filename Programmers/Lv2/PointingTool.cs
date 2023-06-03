using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class PointingTool
    {
        public long Solution(int k, int d) 
        {
            long answer = 0;
            for (int i = 0; i <= d; i += k)
            {
                int n = (int) Math.Floor (Math.Sqrt (Math.Pow (d, 2) - Math.Pow (i, 2))) / k + 1;
                answer += n;
            }
            return answer;
        }
    }
}