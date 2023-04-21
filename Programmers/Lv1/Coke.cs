using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class Coke
    {
        public int Solution(int a, int b, int n) 
        {
            int answer = 0;
            while (n >= a)
            {
                int tmp = n / a;
                tmp *= b;
                answer += tmp;
                n %= a;
                n += tmp;
            }
            return answer;
        }
    }
}