using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class AntCorps
    {
        public int Solution(int hp) 
        {
            int answer = 0;
            answer += hp / 5;
            hp %= 5;
            answer += hp / 3;
            hp %= 3;
            answer += hp;
            return answer;
        }
    }
}