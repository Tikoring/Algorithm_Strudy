using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class MaximumMultiple2
    {
        public int Solution(int[] numbers) 
        {
            int answer = 0;
            Array.Sort (numbers);
            answer = numbers[numbers.Length - 2] * numbers.Last ();
            return answer;
        }
    }
}