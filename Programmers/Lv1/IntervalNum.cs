using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class IntervalNum
    {
        public long[] Solution(int x, int n) 
        {
            long[] answer = new long[n];
            for (int i = 0; i < n; i++)
                answer[i] = i - 1 < 0 ? x : answer[i - 1] + x;
            return answer;
        }
    }
}