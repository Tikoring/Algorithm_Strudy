using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class ArrayRotate
    {
        public int[] Solution(int[] numbers, String direction) 
        {
            int[] answer = new int[] {};
            Array.Resize (ref answer, numbers.Length);
            if (direction.Equals ("right"))
            {
                int n = numbers.Last ();
                answer[0] = n;
                for (int i = 1; i < numbers.Length; i++)
                    answer[i] = numbers[i - 1];
            } else 
            {
                int n = numbers.First ();
                answer[answer.Length - 1] = n;
                for (int i = 1; i < numbers.Length; i++)
                    answer[i - 1] = numbers[i];
            }
            return answer;
        }
    }
}