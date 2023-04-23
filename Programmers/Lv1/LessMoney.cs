using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class LessMoney
    {
        public long Solution(int price, int money, int count)
        {
            long answer = -money;
            for (int i = 1; i <= count; i++)
            {
                answer += i * price;
            }
            return answer < 0 ? 0 : answer;
        }
    }
}