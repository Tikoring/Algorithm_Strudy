using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class SumAliquot 
    {
        public int Solution(int n) 
        {
            int answer = 0;
            int k = (int) Math.Sqrt (n);
            for (int i = 1; i <= k; i++)
            {
                if (n % i == 0)
                {
                    answer += i;
                    answer += n / i;
                }
            }
            if (k * k == n) answer -= k;
            return answer;
        }
    }
}