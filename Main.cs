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
            int[] input1 = {1, 3, 2, 5, 4, 5, 2, 3};
            int[] input2 = {0};
            String[] input3 = {"X591X","X1X5X","X231X", "1XXX1"};
            int[,] input = {{2,2,6}, {1,5,10}, {4,2,9}, {3,8,3}};
            MandarinChoice p = new MandarinChoice ();
            long answer = p.Solution (4, input1);

            Console.WriteLine (answer);
            /*foreach (String n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}