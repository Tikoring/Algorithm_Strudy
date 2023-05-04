using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class Mining
    {
        public int Solution(int[] picks, String[] minerals) 
        {
            int answer = 0;
            int sum = picks.Sum ();
            int max = minerals.Length > sum * 5 ? sum * 5 : minerals.Length;
            int maxLength = (int) Math.Ceiling ((double) max / 5) > sum ? sum : (int) Math.Ceiling ((double) max / 5);
            String[][] bundle = new String[maxLength][];
            int[][] fatigability = new int[maxLength][];
            for (int i = 0; i < maxLength; i++)
            {
                int c = 0;
                String[] tmp = new String[5];
                for (int j = i * 5; c < 5 && j < max; j++)
                {
                    tmp[j % 5] = minerals[j];
                    c++;
                }
                Array.Resize (ref tmp, c);

                bundle[i] = tmp;
            }

            for (int i = 0; i < maxLength; i++)
            {
                int[] tmp = new int[3];
                for (int j = 0; j < 3; j++) 
                {
                    tmp[j] = Calc (j, bundle[i]);
                }
                fatigability[i] = tmp;
            }
            Array.Sort (fatigability, (int[] x, int[] y) => {return y[2].CompareTo (x[2]);});

            for (int i = 0; i < maxLength; i++)
            {
                if (picks[0] > 0) {answer += fatigability[i][0]; picks[0]--;}
                else if (picks[1] > 0) {answer += fatigability[i][1]; picks[1]--;}
                else {answer += fatigability[i][2]; picks[2]--;}
            }
            
            return answer;
        }

        private int Calc (int pick, String[] minerals)
        {
            int sum = 0;
            switch (pick)
            {
                case 0:
                    sum += minerals.Length;
                    break;
                case 1:
                    foreach (String m in minerals)
                    {
                        if (m.CompareTo ("diamond") == 0) sum += 5;
                        else sum += 1;
                    }
                    break;
                case 2:
                    foreach (String m in minerals)
                    {
                        if (m.CompareTo ("diamond") == 0) sum += 25;
                        else if (m.CompareTo ("iron") == 0) sum += 5;
                        else sum += 1;
                    }
                    break;
            }
            return sum;
        }
    }
}