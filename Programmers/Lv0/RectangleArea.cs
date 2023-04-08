using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class RectangleArea
    {
        public int Solution(int[,] dots) 
        {
            int answer = 0;
            int x = dots[0, 0];
            int y = dots[0, 1];
            int[] lines = {0, 0, 0};
            for (int i = 1; i < 4; i++)
            {
                lines[i - 1] = (int) Math.Sqrt (Math.Pow (x - dots[i, 0], 2) + Math.Pow (y - dots[i, 1], 2));
            }
            Array.Sort (lines);

            answer = lines[0] * lines[1];

            return answer;
        }
    }
}