using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class EvenOrOdd
    {
        public string Solution(int num) 
        {
            String[] answer = {"Even", "Odd"};
            return answer[Math.Abs(num % 2)];
        }
    }
}