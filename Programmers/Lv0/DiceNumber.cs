using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class DiceNumber
    {
        public int Solution(int[] box, int n) 
        {
            int answer = 0;
            answer = (box[0] / n) * (box[1] / n) * (box[2] / n);
            return answer;
        }
    }
}