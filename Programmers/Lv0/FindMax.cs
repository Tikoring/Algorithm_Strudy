using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class FindMax
    {
        public int[] Solution(int[] array) 
        {
            int[] answer = new int[2];
            int max = array.Max ();
            int idx = Array.FindIndex (array, i => i == max);
            answer[0] = max;
            answer[1] = idx;
            return answer;
        }
    }
}