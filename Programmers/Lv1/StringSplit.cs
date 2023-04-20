using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class StringSplit
    {
        public int Solution(String s) 
        {
            int answer = 0;
            int[] counter = {0, 0};
            char first = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (first == s[i]) counter[0] += 1;
                else counter[1] += 1;
                if (counter[0] == counter[1]) 
                {
                    answer += 1;
                    counter[0] = 0;
                    counter[1] = 0;
                    if (i != s.Length - 1) first = s[i + 1];
                }
            }
            if (counter[0] != 0) answer += 1;

            return answer;
        }
    }
}   