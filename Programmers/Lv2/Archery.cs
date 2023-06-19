using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class Archery
    {
        private int[] lHit = new int[11];
        public int[] Solution(int n, int[] info)
        {
            int[] hit = new int[11];
            int diff = 0;
            int AS = 0;
            for (int i = 0; i < 10; i++)
            {
                if (info[i] > 0)
                {
                    AS += 10 - i;
                }
            }
            DFS (n, 10, AS, 0, ref diff, hit, info);
            if (diff == 0)
            {
                hit = new int[] {-1};
                return hit;
            }
            return lHit;
        }

        private void DFS (int n, int score, int AS, int LS, ref int diff, int[] hit, int[] info)
        {
            if (n == 0 || score == 0)
            {
                hit[10] = n;
                if ((LS - AS) > diff)
                {
                    Array.Copy (hit, lHit, 11);
                    diff = LS - AS;
                }
                else if ((LS - AS) == diff && diff > 0)
                {
                    if (CompareEqualScore (hit, lHit))
                    {
                        Array.Copy (hit, lHit, 11);
                    }
                }
            }
            else
            {
                for (int i = score; i > 0; i--)
                {
                    if (n > info[10 - i])
                    {
                        hit[10 - i] = info[10 - i] + 1;
                        if (info[10 - i] > 0)
                        {
                            DFS (n - (info[10 - i] + 1), i - 1, AS - i, LS + i, ref diff, hit, info);
                        }
                        else 
                        {
                            DFS (n - (info[10 - i] + 1), i - 1, AS, LS + i, ref diff, hit, info);
                        }
                        hit[10 - i] = 0;
                    }
                    else
                    {
                        DFS (n, i - 1, AS, LS, ref diff, hit, info);
                    }
                }
            }
        }

        private bool CompareEqualScore (int[] a, int[] b)
        {
            for (int i = 10; i >= 0; i--)
            {
                if (a[i] > 0 || b[i] > 0)
                {
                    if (a[i] > b[i])
                    {
                        return true;
                    }
                    break;
                }
            }
            return false;
        }
    }
}