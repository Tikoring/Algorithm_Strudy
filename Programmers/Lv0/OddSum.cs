using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class OddSum
    {
        public int Solution(int n) 
        {
            int answer = 0;
            for (int i = 2; i <= n; i ++)
                if (i % 2 == 0) answer += i;
            return answer;
        }
    }
}