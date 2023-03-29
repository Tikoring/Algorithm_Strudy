using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class Continuous
    {
        public int[] Solution (int num, int total)
        {
            int[] answer = new int[] {};
            int d = (num - 1) * (num) / 2;
            int s = (total - d) / num;
            for (int i = 0; i < num; i++) {
                Array.Resize(ref answer, answer.Length + 1);
                answer[i] = s + i;
            }
            return answer;
        }
    }
}