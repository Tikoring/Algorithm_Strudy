using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class EmergencyOrdered
    {
        public int[] Solution(int[] emergency) 
        {
            int[] answer = new int[] {};
            Array.Resize (ref answer, emergency.Length);
            Dictionary <int, int> idxData = new Dictionary<int, int> ();
            int[] ordered = new int[emergency.Length];
            Array.Copy (emergency, ordered, emergency.Length);
            Array.Sort (ordered);
            ordered = ordered.Reverse ().ToArray ();
            for (int i = 0; i < ordered.Length; i++)
                idxData.Add (ordered[i], i);
            
            for (int i = 0; i < emergency.Length; i++)
                answer[i] = idxData[emergency[i]];

            return answer;
        }
    }
}