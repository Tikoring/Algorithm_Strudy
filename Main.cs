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
            int[] input1 = {7000, 9000};
            int[] input2 = {0};
            String[] input3 = {"X591X","X1X5X","X231X", "1XXX1"};
            int[,] input = {{2,2,6}, {1,5,10}, {4,2,9}, {3,8,3}};
            TableHashing p = new TableHashing ();
            int answer = p.Solution (input, 2, 2, 3);

            Console.WriteLine (answer);
            /*foreach (String n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}