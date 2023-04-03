using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class TSNgame
    {
        public int Solution(int order)
        {
            int answer = 0;
            while (order > 0)
            {
                if (order % 10 % 3 == 0 && order % 10 / 3 > 0) answer++;
                order /= 10;
            }
            return answer;
        }   
    }
}