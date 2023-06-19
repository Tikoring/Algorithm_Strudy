using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class QueueMerge
    {
        public int Solution(int[] queue1, int[] queue2) 
        {
            int answer = int.MaxValue;
            long sum = 0;
            long half = 0;
            int start = 0;
            int l = queue1.Length;
            int[] comb12 = new int[l * 2];
            int[] comb21 = new int[l * 2];
            for (int i = 0; i < l * 2; i++)
            {
                if (i / l == 0)
                {
                    comb12[i] = queue1[i];
                    comb21[i] = queue2[i];
                    half += (long)queue1[i];
                }
                else
                {
                    comb12[i] = queue2[i % l];
                    comb21[i] = queue1[i % l];
                    half += (long)queue2[i % l];
                }
            }
            if (half / 2 == 1)
            {
                return -1;
            }
            half /= 2;

            for (int i = 0; i < l * 2; i++)
            {
                sum += comb12[i];
                if (sum == half)
                {
                    int n = 0;
                    if (i < l - 1)
                    {
                        n += (i + 1) + l + start;
                    }
                    else 
                    {
                        n += (i - l + 1) + start;
                    }
                    answer = Math.Min (answer, n);
                }
                else if (sum > half)
                {
                    sum -= comb12[i];
                    if (start != i)
                    {
                        sum -= comb12[start];
                        i -= 1;
                    }
                    start += 1;
                }
            }

            sum = 0;
            start = 0;
            for (int i = 0; i < l * 2; i++)
            {
                sum += comb21[i];
                if (sum == half)
                {
                    int n = 0;
                    if (i < l - 1)
                    {
                        n += (i + 1) + l + start;
                    }
                    else 
                    {
                        n += (i - l + 1) + start;
                    }
                    answer = Math.Min (answer, n);
                }
                else if (sum > half)
                {
                    sum -= comb21[i];
                    if (start != i)
                    {
                        sum -= comb21[start];
                        i -= 1;
                    }
                    start += 1;
                }
            }

            if (answer == int.MaxValue)
            {
                return -1;
            }
            
            return answer;
        }
    }
}