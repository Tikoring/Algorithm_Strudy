using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class EvenFalse
    {
        public int[] Solution(int n) 
        {
            int[] answer = new int[] {};
            int size = n % 2 == 0 ? n / 2 : n / 2 + 1;
            Array.Resize(ref answer, size);
            for (int i = 0; i < size; i++)
                answer[i] = i * 2 + 1;
            return answer;
        }
    }
}