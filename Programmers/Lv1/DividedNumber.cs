using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class DividedNumber
    {
        public int[] solution(int[] arr, int divisor) 
        {
            int[] answer = new int[] {};
            List<int> divided = new List<int> ();

            foreach (int n in arr)
            {
                if (n % divisor == 0) divided.Add (n);
            }
            if (divided.Count == 0) divided.Add (-1);
            answer = divided.ToArray ();
            Array.Sort (answer);
            return answer;
        }
    }
}