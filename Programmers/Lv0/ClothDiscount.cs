using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class ClothDiscount
    {
        public int Solution(int price) 
        {
            int answer = 0;
            if (price < 100000) answer = price;
            else if(price < 300000) answer = price * 19 / 20;
            else if(price < 500000) answer = price * 9 / 10;
            else answer = price * 4 / 5;
            return answer;
        }
    }
}