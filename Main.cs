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
            int[] input1 = {4, 2, 4, 5, 3, 3, 1};
            int[] input2 = {0};
            String[] input3 = {"X591X","X1X5X","X231X", "1XXX1"};
            int[,] input = {{2,2,6}, {1,5,10}, {4,2,9}, {3,8,3}};
            PointingTool p = new PointingTool ();
            long answer = p.Solution (2, 4);

            Console.WriteLine (answer);
            /*foreach (String n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}