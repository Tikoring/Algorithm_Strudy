using System;
using Programmers.Lv0.Problem;
using Programmers.Lv1.Problem;
using Programmers.Lv2.Problem;

namespace Solve
{
    public class Solution
    {
        public static void Main(string[] args) 
        {
            int[] input1 = {1, 5, 2, 6, 3, 7, 4};
            int[,] input2 = {{2, 5, 3}, {4, 4, 1}, {1, 7, 3}};
            String[] input3 = {"sun", "bed", "car"};
            int[,] input = {{4, 8}, {4, 5}, {10, 14}, {11, 13}, {5, 12}, {3, 7}, {1, 4}};
            CirclesIntervalIntPair p = new CirclesIntervalIntPair ();
            long answer = p.Solution (1, 3);

            Console.WriteLine (answer);
            /*foreach (int n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}