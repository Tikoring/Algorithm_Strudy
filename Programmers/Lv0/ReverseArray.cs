using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class ReverseArray
    {
        public int[] solution(int[] numList) 
        {
            int[] answer = numList.Reverse ().ToArray ();
            return answer;
        }
    }
}