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
            String[] input1 = {"banana", "apple", "rice", "pork", "pot"};
            int[] input2 = {3, 2, 2, 2, 1};
            String[] input3 = {"chicken", "apple", "apple", "banana", "rice", "apple", "pork", "banana", "pork", "rice", "pot", "banana", "apple", "banana"};
            int[,] input = {{0, 0}, {0, -1}, {2, -3}, {3, -3}};
            DiscountAll p = new DiscountAll ();
            int answer = p.Solution (input1, input2, input3);

            Console.WriteLine (answer);
            /*foreach (String n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}