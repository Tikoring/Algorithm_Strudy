using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class FoodFightCompetition
    {
        public String Solution(int[] food) 
        {
            String answer = "";
            String[] deployment = new String[food.Length];
            deployment[0] = "0";
            for (int i = 1; i < food.Length; i++)
            {
                deployment[i] = "";
                int size = food[i] / 2;
                for (int j = 0; j < size; j++)
                    deployment[i] += i.ToString ();
            }
            for (int i = 1; i < food.Length; i++) {
                answer += deployment[i];
            }
            answer += deployment[0];
            for (int i = food.Length - 1; i >= 1; i--) {
                answer += deployment[i];
            }
            return answer;
        }
    }
}