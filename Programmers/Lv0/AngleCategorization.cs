using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class AngleCategorization
    {
        public int Solution(int angle) 
        {
            int answer = 0;
            if (angle < 90) answer = 1;
            else if (angle == 90) answer = 2;
            else if (angle < 180) answer = 3;
            else answer = 4;
            return answer;
        }
    }
}