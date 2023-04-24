using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class YinYangAddition
    {
        public int Solution(int[] absolutes, bool[] signs) 
        {
            int answer = 0;
            for (int i = 0; i < signs.Length; i++)
            {
                if (signs[i])
                {
                    answer += absolutes[i];
                }
                else 
                {
                    answer -= absolutes[i];
                }
            }
            return answer;
        }
    }
}