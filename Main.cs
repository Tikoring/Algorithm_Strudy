using System;
using Programmers.Lv0.Problem;
using Programmers.Lv1.Problem;

namespace Solve
{
    public class Solution
    {
        public static void Main(string[] args) 
        {
            String[] input1 = {"ayaye", "uuu", "yeye", "yemawoo", "ayaayaa"};
            String[] input2 = {"2019.01.01 D", "2019.11.15 Z", "2019.08.02 D", "2019.07.01 D", "2018.12.28 Z"};
            String[] input3 = {"i", "want", "to", "drink", "water"};
            int[] input = {2, 1, 1, 2, 3, 1, 2, 3, 1};
            NumberPair p = new NumberPair ();
            String answer = p.Solution ("100", "123450");

            Console.WriteLine (answer);
            /*foreach (int n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}