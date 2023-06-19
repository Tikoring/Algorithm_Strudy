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
            int[,] input = {{0, 0}, {0, -1}, {2, -3}, {3, -3}};
            Archery p = new Archery ();
            int[] answer = p.Solution (5, input1);

            Console.WriteLine (answer);
            /*foreach (String n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}