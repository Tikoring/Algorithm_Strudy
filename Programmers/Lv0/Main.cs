using System;
using Programmers.Lv0.Problem;

namespace Programmers.Lv0.Solve
{
    public class Solution
    {
        public static void Main(string[] args) 
        {
            ConvertString p = new ConvertString ();
            int answer = p.Solution ("allpe", "apple");

            Console.WriteLine (answer);
            /*foreach (int n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}