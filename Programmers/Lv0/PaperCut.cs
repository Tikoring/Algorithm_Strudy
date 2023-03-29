using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class PaperCut
    {
        public int Solution(int M, int N)
        {
            int answer = 0;
            int size = M * N;
            answer = size - 1;
            return answer;
        }
    }
}