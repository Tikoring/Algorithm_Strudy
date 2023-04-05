using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class FiniteDecimal
    {
        public int Solution(int a, int b)
        {
            int answer = 2;
            int gcd = Euclidean (a, b);
            b /= gcd;
            while (b % 2 == 0) b /= 2;
            while (b % 5 == 0) b /= 5;
            if (b == 1) answer = 1;
            return answer;
        }

        private int Euclidean (int a, int b)
        {
            int n = a % b;
            if (n != 0) return Euclidean (b, n);
            return b;
        }
    }
}