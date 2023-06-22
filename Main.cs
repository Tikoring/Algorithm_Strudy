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
            int[] input1 = {2, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0};
            int[] input2 = {4, 6, 5, 1};
            String[] input3 = {"chicken", "apple", "apple", "banana", "rice", "apple", "pork", "banana", "pork", "rice", "pot", "banana", "apple", "banana"};
            int[,] input = {{80, 20}, {50, 40}, {30, 10}};
            FatigabilityWaste p = new FatigabilityWaste ();
            int answer = p.Solution (80, input);

            Console.WriteLine (answer);
            /*foreach (String n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}