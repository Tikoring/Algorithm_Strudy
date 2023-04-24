using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class RandomTwoAddition
    {
        public int[] Solution(int[] numbers) 
        {
            int[] answer = new int[] {};
            SortedSet<int> store = new SortedSet<int> ();
            Array.Sort (numbers);

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int n = 0;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    n = numbers[i] + numbers[j];
                    store.Add (n);
                }
            }
            answer = store.ToArray ();
            return answer;
        }
    }
}