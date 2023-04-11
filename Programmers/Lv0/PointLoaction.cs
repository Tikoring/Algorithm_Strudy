using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class PointLoaction
    {
        public int Solution(int[] dot) 
        {
            int answer = 0;
            if (dot[0] * dot[1] > 0)
            {
                if (dot[0] > 0) answer = 1;
                else answer = 3;
            } else 
            {
                if (dot[0] > 0) answer = 4;
                else answer = 2;
            }
            return answer;
        }
    }
}