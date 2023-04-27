using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class CollatzConjecture
    {
        public int Solution(int num) 
        {
            int answer = 0;
            long n = (long) num;
            while (n != 1)
            {
                if (n % 2 == 0) n /= 2;
                else n = n * 3 + 1;
                answer++;
                if (answer > 500) break;
            }
            return answer <= 500 ? answer : -1;
        }
    }
}