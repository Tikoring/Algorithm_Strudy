using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class BallDivide
    {
        public long solution(int balls, int share) 
        {
            long answer = 1;
            for (int i = 1; i <= share; i++)
            {
                answer *= (balls - share + i);
                answer /= i;
            }
            return answer;
        }
    }
}