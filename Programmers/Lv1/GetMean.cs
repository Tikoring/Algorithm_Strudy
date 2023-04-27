using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class GetMean
    {
        public double Solution(int[] arr) 
        {
            double answer = arr.Average ();
            return answer;
        }
    }
}