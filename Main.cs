using System;
using Programmers.Lv0.Problem;

namespace Solve
{
    public class Solution
    {
        public static void Main(string[] args) 
        {
            Polynomial p = new Polynomial ();
            String answer = p.Solution ("3x + 7 + x");

            Console.WriteLine (answer);
            /*foreach (int n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}