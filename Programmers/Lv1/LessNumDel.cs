using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class LessNumDel
    {
        public int[] Solution(int[] arr) 
        {
            int[] answer = new int[arr.Length == 1 ? 1 : arr.Length - 1];
            int m = arr.Min ();
            int idx = 0;
            foreach (int n in arr)
            {
                if (n == m) continue;
                answer[idx++] = n;
            }
            if (arr.Length == 1) answer[0] = -1;
            return answer;
        }
    }
}