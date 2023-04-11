using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class Factorial
    {
        public int Solution(int n) 
        {
            int answer = 1;
            int f = 1;
            while (f <= n)
            {
                f *= answer;
                answer++;
            }
            answer--;
            if (f > n) answer--;
            return answer;
        }
    }
}