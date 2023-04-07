using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class TriangleComplete2
    {
        public int Solution(int[] sides)
        {
            int answer = 0;
            int maximum = sides.Max ();
            int minimum = sides.Min ();
            answer += 2 * minimum - 1;
            return answer;
        }
    }
}

