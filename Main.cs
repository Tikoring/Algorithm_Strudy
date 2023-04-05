using System;
using Programmers.Lv0.Problem;

namespace Solve
{
    public class Solution
    {
        public static void Main(string[] args) 
        {
            
            CursedThree p = new CursedThree ();
            int answer = p.Solution (15);

            Console.WriteLine (answer);
            /*foreach (int n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}