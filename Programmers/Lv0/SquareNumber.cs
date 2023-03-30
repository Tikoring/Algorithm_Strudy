using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class SquareNumber
    {
        public int Solution (int n)
        {
            int answer = 2;
            int d = (int) Math.Sqrt (n);
            if (Math.Pow (d, 2) == n) answer = 1;
            return answer;
        }
    }
}