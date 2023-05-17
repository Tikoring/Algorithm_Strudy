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
            int[] input1 = {0};
            int[] input2 = {0};
            String[] input3 = {"X591X","X1X5X","X231X", "1XXX1"};
            int[,] input = {{7, 7}, {2, 7}, {7, 3}};
            ParcelService p = new ParcelService ();
            long answer = p.Solution (1, 1, input1, input2);

            Console.WriteLine (answer);
            /*foreach (String n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}