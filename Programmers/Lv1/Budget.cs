using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class Budget
    {
        public int Solution(int[] d, int budget) 
        {
            int answer = 0;
            Array.Sort (d);
            foreach (int n in d)
            {
                budget -= n;
                if (budget < 0) break;
                answer++;
            }
            return answer;
        }
    }
}