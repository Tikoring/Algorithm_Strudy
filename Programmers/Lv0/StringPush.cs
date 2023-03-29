using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class StringPush
    {
        public int Solution(String A, String B)
        {
            int answer = -1;
            for (int i = 0; i < A.Length; i++)
            {
                String sub1 = A.Substring (0, A.Length - i);
                String sub2 = A.Substring (A.Length - i);
                String move = String.Concat (sub2, sub1);
                if (String.Compare (move, B) == 0)
                {
                    answer = i;
                    break;
                }
            }
            return answer;
        }
    }
}