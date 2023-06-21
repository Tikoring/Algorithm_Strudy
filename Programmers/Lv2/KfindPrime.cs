using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Programmers.Lv2.Problem
{
    public class KfindPrime
    {
        public int Solution(int n, int k) 
        {
            int answer = 0;
            StringBuilder maker = new StringBuilder ();
            while (n > 0)
            {
                maker.Append (n % k);
                n /= k;
            }
            String num = new String (maker.ToString ().Reverse ().ToArray ());
            String[] nums = num.Split ('0');
            long[] numi = new long[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i].Length == 0) {continue;}
                numi[i] = Int64.Parse (nums[i]);
            }
            long max = numi.Max ();
            foreach (long idx in numi)
            {
                bool isPrime = true;
                if (idx < 2)
                {
                    isPrime = false;
                }
                for (long i = 2; i <= Math.Sqrt (idx); i++)
                {
                    if (idx % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    answer++;
                }
            }
            return answer;
        }
    }
}