using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class DeliveryBox
    {
        public int Solution(int[] order) 
        {
            int answer = 0;
            Stack<int> sub = new Stack<int> ();
            int seq = 1;
            int idx = 0;
            while (idx < order.Length)
            {
                if (seq <= order.Length)
                {
                    if (seq == order[idx])
                    {
                        answer++;
                        idx++;
                        seq++;
                    }
                    else if (sub.Count > 0 && sub.Peek () == order[idx])
                    {
                        sub.Pop ();
                        answer++;
                        idx++;
                    }
                    else
                    {
                        sub.Push (seq);
                        seq++;
                    }
                }
                else if (sub.Count > 0)
                {
                    if (sub.Peek () == order[idx])
                    {
                        sub.Pop ();
                        answer++;
                        idx++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            return answer;
        }
    }
}