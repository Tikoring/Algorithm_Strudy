using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class SplitArray
    {
        public int[] Solution(int[] numbers, int num1, int num2) 
        {
            int[] answer = new int[] {};
            Array.Resize (ref answer, num2 - num1 + 1);
            for (int i = num1; i <= num2; i++)
                answer[i - num1] = numbers[i];
            return answer;
        }
    }
}