using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class FruitSeller
    {
        public int Solution(int k, int m, int[] score) 
        {
            int answer = 0;
            Array.Sort (score);
            int min = Int32.MaxValue;
            int count = 0;
            for (int i = score.Length - 1; i >= 0; i--)
            {
                if (min > score[i]) min = score[i];
                count++;
                if (count == m)
                {
                    answer += min * m;
                    min = Int32.MaxValue;
                    count = 0;
                }
            }
            return answer;
        }
    }
}