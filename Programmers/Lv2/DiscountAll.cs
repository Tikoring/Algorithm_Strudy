using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class DiscountAll
    {
        public int Solution(String[] want, int[] number, String[] discount) 
        {
            int answer = 0;
            Dictionary<String, int> can = new Dictionary<String, int> ();
            Queue<String> dc = new Queue<string> ();
            for (int i = 0; i < discount.Length; i++)
            {
                String p = discount[i];
                dc.Enqueue (p);
                if (can.ContainsKey (p))
                {
                    can[p] += 1;
                }
                else
                {
                    can.Add (p, 1);
                }

                if (i >= 10)
                {
                    String first = dc.Dequeue ();
                    can[first]--;
                    if (can[first] == 0)
                    {
                        can.Remove (first);
                    }
                }

                if (i >= 9)
                {
                    bool purchase = true;
                    for (int j = 0; j < number.Length; j++)
                    {
                        if (!(can.ContainsKey (want[j]) && can[want[j]] == number[j]))
                        {
                            purchase = false;
                            break;
                        }
                    }

                    if (purchase)
                    {
                        answer += 1;
                    }
                }
            }

            return answer;
        }
    }
}