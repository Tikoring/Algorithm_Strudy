using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class HallOfFame1
    {
        public int[] Solution(int k, int[] score) 
        {
            int[] answer = new int[] {};
            Array.Resize (ref answer, score.Length);
            List<int> hall = new List<int> ();
            for (int i = 0; i < score.Length; i++)
            {
                hall.Add (score[i]);
                hall.Sort ();
                if (hall.Count > k) hall.RemoveAt (0);
                answer[i] = hall[0];
            }
            return answer;
        }
    }
}