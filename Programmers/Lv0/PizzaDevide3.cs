using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class PizzaDevide3
    {
        public int Solution(int n) 
        {
            int answer = n % 7 != 0 ? n / 7 + 1 : n / 7;
            return answer;
        }
    }
}