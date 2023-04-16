using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class FindMode
    {
        public int Solution(int[] array) 
        {
            int answer = 0;
            Dictionary<int, int> nums = new Dictionary<int, int> ();
            foreach (int n in array)
                if (nums.ContainsKey (n)) nums[n]++;
                else nums.Add (n, 1);
            int[] keys = nums.Keys.ToArray ();
            int[] values = nums.Values.ToArray ();
            Array.Sort (values, keys);

            if (keys.Length == 1) answer = keys[0];
            else 
            {
                int size = keys.Length;
                if (values[size - 1] == values[size - 2]) answer = -1;
                else answer = keys[size - 1];
            }

            
            return answer;
        }
    }
}