using System;
using Programmers.Lv0.Problem;

namespace Programmers.Lv0.Solve
{
    public class Solution
    {
        public static void Main(string[] args) 
        {
            UpperLower p = new UpperLower ();
            String answer = p.Solution ("cccCCC");

            Console.WriteLine (answer);
            /*foreach (int n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}