using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class MinimumSquare
    {
        public int Solution(int[,] sizes) 
        {
            int answer = 0;
            int x = 0;
            int y = 0;
            for (int i = 0; i < sizes.GetLength (0); i++)
            {
                int m = Math.Max (sizes[i, 0], sizes[i, 1]);
                int n = Math.Min (sizes[i, 0], sizes[i, 1]);
                x = x < m ? m : x;
                y = y < n ? n : y;
            }
            answer = x * y;
            return answer;
        }
    }
}