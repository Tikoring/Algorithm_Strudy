using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class OddEvenNumbers
    {
        public int[] solution(int[] numList) 
        {
            int[] answer = new int[2] {0, 0};
            foreach (int n in numList)
                if (n % 2 == 0) answer[0]++;
                else answer[1]++;
            return answer;
        }
    }
}