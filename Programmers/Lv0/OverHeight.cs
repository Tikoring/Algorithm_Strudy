using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class OverHeight
    {
        public int Solution(int[] array, int height) 
        {
            int answer = 0;
            foreach (int h in array)
                if (h > height) answer++;
            return answer;
        }
    }
}