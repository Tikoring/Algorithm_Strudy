using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class OrderedPair
    {
        public int Solution(int n) 
        {
            int answer = 0;
            for (int i = 1; i < Math.Sqrt (n); i++)
                if (n % i == 0) answer += 2;
            int sqr = (int) Math.Sqrt (n);
            if (sqr * sqr == n) answer--;
            return answer;
        }
    }
}