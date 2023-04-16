using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class PizzaDevide2
    {
        public int Solution(int n) 
        {
            int answer = 0;
            if (n % 2 == 0 && n % 3 == 0) answer = n / 6;
            else if (n % 2 == 0) answer = n / 2;
            else if (n % 3 == 0) answer = n / 3;
            else answer = n;

            return answer;
        }
    }
}