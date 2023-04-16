using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class FindMiddle
    {
        public int Solution(int[] array) 
        {
            int answer = 0;
            Array.Sort (array);
            answer = array[array.Length / 2];
            return answer;
        }
    }
}