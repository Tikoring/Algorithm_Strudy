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
            int[,] input = {{40, 10000}, {25, 10000}};
            EmoticonDiscount p = new EmoticonDiscount ();
            int[] answer = p.Solution (input, input1);

            Console.WriteLine (answer);
            /*foreach (String n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}