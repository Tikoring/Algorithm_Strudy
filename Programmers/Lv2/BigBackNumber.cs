using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class BigBackNumber
    {
        public int[] Solution(int[] numbers) 
        {
            int[] answer = new int[numbers.Length];
            int backBig = numbers.Last ();
            int idx = numbers.Length;
            answer[numbers.Length - 1] = -1;

            for (int i = numbers.Length - 2; i >= 0; i--) 
            {
                if (numbers[i] >= backBig)
                {
                    answer[i] = -1;
                    backBig = numbers[i];
                    idx = i + 1;
                    continue;
                }
                for (int j = i + 1; j < idx; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        answer[i] = numbers[j];
                        break;
                    }
                    else if (numbers[i] < answer[j]) 
                    {
                        answer[i] = answer[j];
                        break;
                    }
                }
            }
            

            return answer;
        }
    }
}