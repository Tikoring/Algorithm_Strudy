using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class ArrayDouble
    {
        public int[] Solution(int[] numbers) 
        {
            int[] answer = new int[] {};
            Array.Resize (ref answer, numbers.Length);
            for (int i = 0; i < numbers.Length; i++)
                answer[i] = numbers[i] * 2;
            return answer;
        }
    }
}