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
            int[] input1 = {1, 0, 1};
            int[] input2 = {};
            String[] input3 = {"diamond", "diamond", "diamond", "iron", "iron", "diamond", "iron", "stone"};
            int[,] input = {{4, 8}, {4, 5}, {10, 14}, {11, 13}, {5, 12}, {3, 7}, {1, 4}};
            Mining p = new Mining ();
            int answer = p.Solution (input1, input3);

            Console.WriteLine (answer);
            /*foreach (String n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}