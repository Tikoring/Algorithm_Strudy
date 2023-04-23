using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class BeNotNumber
    {
        public int Solution(int[] numbers) 
        {
            int answer = 45;
            foreach (int n in numbers)
                answer -= n;

            return answer;
        }
    }
}