using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class Hashard
    {
        public bool Solution(int x) 
        {
            bool answer = true;
            int n = 0; 
            int copy = x;
            while (copy > 0)
            {
                n += copy % 10;
                copy /= 10;
            }
            answer = x % n == 0;
            return answer;
        }
    }
}