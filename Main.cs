using System;
using Programmers.Lv0.Problem;

namespace Solve
{
    public class Solution
    {
        public static void Main(string[] args) 
        {
            Factorization p = new Factorization ();
            int[] answer = p.Solution (10);

            //Console.WriteLine (answer);
            foreach (int n in answer) 
            {
                Console.WriteLine (n);
            }
        }
    }
}