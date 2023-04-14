using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class ArrayMean
    {
        public double Solution(int[] numbers) 
        {
            double answer = numbers.Average ();
            return answer;
        }
    }
}