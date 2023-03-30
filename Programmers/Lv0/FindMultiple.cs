using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Solve
{
    public class FindMultiple
    {
        public int[] Solution(int n, int[] numlist)
        {
            int[] answer;
            answer = Array.FindAll (numlist, i => i % n == 0);
            return answer;
        }
    }
}