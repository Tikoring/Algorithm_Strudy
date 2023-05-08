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
            int[] input1 = {1, 0, 1};
            int[] input2 = {};
            String[,] input3 = {{"15:00", "17:55"}, {"16:40", "18:20"}, {"14:20", "15:20"}};
            int[,] input = {{7, 7}, {2, 7}, {7, 3}};
            HotelHIring p = new HotelHIring ();
            int answer = p.Solution (input3);

            Console.WriteLine (answer);
            /*foreach (String n in answer) 
            {
                Console.WriteLine (n);
            }*/
        }
    }
}