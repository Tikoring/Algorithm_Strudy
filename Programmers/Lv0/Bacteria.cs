using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class Bacteria
    {
        public int Solution (int n, int t)
        {
            int answer = n * (int) Math.Pow (2, t);
            return answer;
        }
    }
}