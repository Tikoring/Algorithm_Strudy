using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class SpecialSort
    {
        public int[] Solution(int[] numlist, int n)
        {
            int[] answer = new int[] {};
            int idx = 0;
            Array.Resize (ref answer, numlist.Length);
            Dictionary<int, int[]> distDict = new Dictionary<int, int[]> ();
            foreach (int i in numlist)
            {
                if (distDict.ContainsKey (Math.Abs (n - i))) distDict[Math.Abs (n - i)][1] = i;
                else distDict.Add (Math.Abs (n - i), new int[2] {i, 0});
            }

            int[] distList = distDict.Keys.ToArray ();
            Array.Sort (distList);

            foreach (int i in distList)
            {
                int[] tmp = distDict[i];
                Array.Sort (tmp);
                answer[idx++] = tmp[1];
                if (tmp[0] > 0) answer[idx++] = tmp[0];
            }
            return answer;
        }
    }
}