using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class LuckySeven
    {
        public int Solution(int[] array)
        {
            int answer = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                int n = array[i];
                while (n > 0)
                {
                    if (n % 10 == 7) answer++;
                    n /= 10;
                }
            }
            return answer;
        }
    }
}