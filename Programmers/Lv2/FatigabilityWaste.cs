using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class FatigabilityWaste
    {
        public int Solution(int k, int[,] dungeons) 
        {
            int answer = 0;
                        
            DFS (dungeons, k, new List<int> (), 0, ref answer);

            return answer;
        }
        public void DFS (int[,] ds, int k, List<int> idx, int count, ref int answer)
        {
            if (k == 0 || idx.Count == ds.GetLength (0))
            {
                if (count > answer)
                {
                    answer = count;
                }
            }
            else 
            {
                for (int i = 0; i < ds.GetLength (0); i++)
                {
                    if (idx.Contains (i))
                    {
                        continue;
                    }
                    idx.Add (i);
                    if (k >= ds[i, 0])
                    {
                        DFS (ds, k - ds[i, 1], idx, count + 1, ref answer);
                        idx.Remove (i);
                    }
                    else 
                    {
                        DFS (ds, k, idx, count, ref answer);
                        idx.Remove (i);
                    }
                }
            }
        }
    }
}