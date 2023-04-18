using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class CardStack
    {
        public String Solution(String[] cards1, String[] cards2, String[] goal) 
        {
            String answer = "";
            int idx1 = 0;
            int idx2 = 0;
            foreach (String word in goal)
            {
                if (word.CompareTo (cards1[idx1]) == 0 && idx1 < cards1.Length) idx1++;
                else if (word.CompareTo (cards2[idx2]) == 0 && idx2 < cards2.Length) idx2++;
                else break;
            }
            answer = idx1 + idx2 == goal.Length ? "Yes" : "No";
            return answer;
        }
    }
}