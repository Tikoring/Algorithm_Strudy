using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class RemainderOne
    {
        public int Solution(int n) 
        {
            int answer = 1;
            while (n % answer != 1) answer++;
            return answer;
        }
    }
}