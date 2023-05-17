using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class ParcelService
    {
        public long Solution(int cap, int n, int[] deliveries, int[] pickups) 
        {
            long answer = 0;
            int dIdx = deliveries.Length - 1;
            int pIdx = pickups.Length - 1;
            for (int i = dIdx; i >= 0 && deliveries[dIdx] == 0; i--)
            {
                if (deliveries[i] > 0) dIdx = i;
                else if (i == 0 && deliveries[i] == 0) dIdx = -1;
            }
            for (int i = pIdx; i >= 0 && pickups[pIdx] == 0; i--)
            {
                if (pickups[i] > 0) pIdx = i;
                else if (i == 0 && pickups[i] == 0) pIdx = -1;
            }

            while (pIdx > -1 || dIdx > -1)
            {
                int c = cap;
                int d1 = dIdx + 1;
                int d2 = pIdx + 1;
                for (;dIdx >= 0 && deliveries[dIdx] <= c; dIdx--)
                {
                    c -= deliveries[dIdx];
                    deliveries[dIdx] = 0;
                }
                if (dIdx >= 0 && c > 0)
                {
                    deliveries[dIdx] -= c;
                }

                c = 0;
                for (;pIdx >= 0 && pickups[pIdx] <= cap - c; pIdx--)
                {
                    c += pickups[pIdx];
                    pickups[pIdx] = 0;
                }
                if (pIdx >= 0 && cap - c > 0)
                {
                    pickups[pIdx] -= cap - c;
                }
                answer += Math.Max (d1, d2) * 2;
            }
            return answer;
        }   
    }
}