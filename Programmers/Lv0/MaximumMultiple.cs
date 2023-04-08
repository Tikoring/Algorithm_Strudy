using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class MaximumMultiple
    {
        public int Solution(int[] numbers)
        {
            int answer = 0;
            Array.Sort (numbers);
            int minimum = numbers.First ();
            int maximum = numbers.Last ();
            if (maximum <= 0) answer = numbers[0] * numbers[1];
            else if (minimum >= 0) answer = numbers[numbers.Length - 2] * numbers[numbers.Length - 1];
            else
            {
                int m1 = numbers[0] * numbers[1];
                int m2 = numbers[numbers.Length - 2] * numbers[numbers.Length - 1];
                answer = m1 > m2 ? m1 : m2;
            }
            return answer;
        }
    }
}