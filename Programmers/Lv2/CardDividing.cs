using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class CardDividing
    {
        public int Solution(int[] arrayA, int[] arrayB) 
        {
            int answer = 0;
            int arrayMin = Math.Max (arrayA.Min (), arrayB.Min ());

            for (int i = 2; i <= arrayMin; i++)
            {
                bool dA = arrayA[0] % i == 0;
                bool dB = arrayB[0] % i == 0;
                if (dA == dB) continue;
                for (int j = 1; j < arrayA.Length; j++)
                {
                    if (dA == (arrayA[j] % i == 0))
                    {
                        dA = arrayA[j] % i == 0;
                    }
                    else
                    {
                        dA = dB;
                        break;
                    }
                    if (dB == (arrayB[j] % i == 0))
                    {
                        dB = arrayB[j] % i == 0;
                    }
                    else
                    {
                        dB = dA;
                        break;
                    }
                }
                if (dA != dB)
                {
                    answer = i;
                }
            }
            
            return answer;
        }
    }
}