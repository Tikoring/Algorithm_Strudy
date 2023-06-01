using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class DefenceGame
    {
        List<int> MaxHeap = new List<int> ();
        public int Solution(int n, int k, int[] enemy) 
        {
            int answer = 0;
            for (int i = 0; i < enemy.Length && (n >= enemy[i] || k > 0); i++)
            {
                int e = enemy[i];
                if (n >= e)
                {
                    n -= e;
                    AddHeap (e);
                    answer++;
                }
                else if (k > 0)
                {
                    if (MaxHeap.Count > 0 && e < MaxHeap[0])
                    {
                        n += MaxHeap[0];
                        DeleteHeap ();
                        i--;
                    }
                    else
                    {
                        answer++;
                    }
                    k--;
                }
            }

            return answer;
        }

        private void AddHeap (int n)
        {
            MaxHeap.Add (n);
            int idx = MaxHeap.Count - 1;
            while (idx > 0)
            {
                int p = (idx - 1) / 2;
                if (MaxHeap[p] < MaxHeap[idx])
                {
                    int tmp = MaxHeap[idx];
                    MaxHeap[idx] = MaxHeap[p];
                    MaxHeap[p] = tmp;
                    idx = p;
                }
                else 
                {
                    break;
                }
            }
        }

        private void DeleteHeap ()
        {
            int idx = 0;
            int tmp = MaxHeap[idx];
            MaxHeap[idx] = MaxHeap[MaxHeap.Count - 1];;
            MaxHeap[MaxHeap.Count - 1] = tmp;
            MaxHeap.RemoveAt (MaxHeap.Count - 1);
            int last = MaxHeap.Count - 1;

            while (idx < last)
            {
                int c = idx * 2 + 1;
                if (c < last && MaxHeap[c] < MaxHeap[c + 1])
                {
                    c += 1;
                }

                if (c > last || MaxHeap[c] < MaxHeap[idx])
                {
                    break;
                }

                tmp = MaxHeap[idx];
                MaxHeap[idx] = MaxHeap[c];
                MaxHeap[c] = tmp;
                idx = c;
            }
        }
    }
}