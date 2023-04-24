using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class DotProduct
    {
        public int Solution(int[] a, int[] b) 
        {
            int answer = 0;
            for (int i = 0; i < a.Length; i++)
            {
                answer += a[i] * b[i];
            }
            return answer;
        }
    }
}