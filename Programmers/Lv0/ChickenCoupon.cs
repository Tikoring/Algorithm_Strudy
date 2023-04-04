using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class ChickenCoupon
    {
        public int Solution(int chicken)
        {
            int answer = 0;
            while (chicken / 10 > 0) 
            {
                int tmp = chicken % 10;
                chicken /= 10;
                answer += chicken;
                chicken += tmp;
            }

            return answer;
        }
    }
}