using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class PizzaDevide1
    {
        public int Solution(int slice, int n) 
        {
            int answer = n % slice != 0 ? n / slice + 1 : n / slice;
            return answer;
        }
    }
}