using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class TrioGetPrimeNum
    {
        public int Solution(int[] nums)
        {
            int answer = 0;
            List<int> triSum = new List<int> ();
            Array.Sort (nums);
            int m = nums[nums.Length - 1] + nums[nums.Length - 2] + nums[nums.Length - 3];

            bool[] prime = new bool[m + 1];
            for (int i = 0; i <= m; i++)
                prime[i] = true;

            for (int i = 2; i <= Math.Sqrt(m); i++)
            {
                for (int j = 2; j <= m; j++)
                {
                    if (i == j && prime[j]) continue;
                    if (j % i == 0) prime[j] = false;
                }
            }

            for (int i = 0; i < nums.Length - 2; i++)
                for (int j = i + 1; j < nums.Length - 1; j++)
                    for (int k = j + 1; k < nums.Length; k++)
                        triSum.Add (nums[i] + nums[j] + nums[k]);
            
            foreach (int n in triSum)
                if (prime[n]) answer++;

            return answer;
        }
    }
}