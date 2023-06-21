using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class ParkingCharge
    {
        public int[] Solution(int[] fees, String[] records) 
        {
            List<int> answer = new List<int> ();
            int end = TranslateTime ("23:59");
            SortedSet<String> carNumber = new SortedSet<String> ();
            Dictionary<String, int> parkingStart = new Dictionary<String, int> ();
            Dictionary<String, int> parkingTime = new Dictionary<String, int> ();
            Dictionary<String, int> parkingState = new Dictionary<String, int> ();
            foreach (String r in records)
            {
                String[] tmp = r.Split (' ');
                int t = TranslateTime (tmp[0]);
                if (carNumber.Contains (tmp[1]))
                {

                    if (parkingState [tmp[1]] == 1)
                    {
                        t -= parkingStart[tmp[1]];
                        parkingState[tmp[1]] = 0;
                        parkingTime[tmp[1]] += t;
                    }
                    else 
                    {
                        parkingState[tmp[1]] = 1;
                        parkingStart[tmp[1]] = t;
                    }
                }
                else
                {
                    carNumber.Add (tmp[1]);
                    parkingState.Add (tmp[1], 1);
                    parkingStart.Add (tmp[1], t);
                    parkingTime.Add (tmp[1], 0);
                }
            }
            
            foreach (String n in carNumber)
            {
                int time = 0;
                int charge = fees[1];
                if (parkingState[n] == 1)
                {
                    time += end - parkingStart[n];
                }
                time += parkingTime[n];
                if (time > fees[0])
                {
                    charge += (int) Math.Ceiling ((double) (time - fees[0]) / fees[2]) * fees[3];
                }
                answer.Add (charge);
            }
            return answer.ToArray ();
        }

        private int TranslateTime (String st)
        {
            int t = 0;
            int h = Int32.Parse (st.Substring (0, 2));
            int m = Int32.Parse (st.Substring (3));
            t = h * 60 + m;
            return t;
        }
    }
}