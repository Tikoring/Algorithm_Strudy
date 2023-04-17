using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class NumsDup
    {
        public int Solution(int[] array, int n) 
        {
            int answer = 0;
            foreach (int i in array)
                if (n == i) answer++;
            return answer;
        }
    }
}