using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class BuyIceAmericano
    {
        public int[] Solution(int money) 
        {
            int[] answer = new int[2] {0, 0};
            answer[0] = money / 5500;
            answer[1] = money - answer[0] * 5500;
            return answer;
        }
    }
}