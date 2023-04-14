using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class DrawRightAngle
    {
        public String Solution(int n) 
        {
            String answer = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                    answer = answer.Insert (answer.Length, "*");
                answer = answer.Insert (answer.Length, "\n");
            }
            answer = answer.Remove (answer.Length - 1, 1);
            return answer;
        }
    }
}