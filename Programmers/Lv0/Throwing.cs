using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class Throwing
    {
        public int Solution(int[] numbers, int k) 
        {
            int answer = 0;
            int idx = k * 2 - 2;
            idx %= numbers.Length;
            answer = numbers[idx];
            return answer;
        }
    }
}