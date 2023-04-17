using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class NumCompare
    {
        public int Solution(int num1, int num2) 
        {
            int answer = num1 == num2 ? 1 : -1;
            return answer;
        }
    }
}