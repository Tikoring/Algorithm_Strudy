using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class TriangleComplete
    {
        public int Solution(int[] sides)
        {
            int answer = 2;
            Array.Sort (sides);
            if (sides[0] + sides[1] > sides[2]) answer = 2;
            return answer;
        }
    }
}