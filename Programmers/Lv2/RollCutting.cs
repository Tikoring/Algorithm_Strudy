using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class RollCutting
    {
        public int Solution(int[] topping) 
        {
            int answer = 0;
            HashSet<int> categories = new HashSet<int> ();
            int[] left = new int[topping.Length];
            int[] right = new int[topping.Length];
            categories.Clear ();
            for (int i = 0; i < topping.Length; i++)
            {
                categories.Add (topping[i]);
                left[i] = categories.Count;
            }
            categories.Clear ();
            for (int i = topping.Length - 1; i >= 0; i--)
            {
                categories.Add (topping[i]);
                right[i] = categories.Count;
            }
            
            for (int i = 0; i < topping.Length - 1; i++)
            {
                if (left[i] == right[i])
                {
                    answer++;
                }
            }


            return answer;
        }
    }
}