using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class DrinkService
    {
        public int Solution(int n, int k) 
        {
            int answer = 0;
            k -= n / 10;
            answer += n * 12000 + k * 2000;
            return answer;
        }
    }
}