using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class LottoBestWorst
    {
        public int[] Solution(int[] lottos, int[] winNums) 
        {
            int[] answer = new int[2] {0, 0};
            Array.Sort (lottos);
            Array.Sort (winNums);
            int c = 0;
            int z = 0;
            foreach (int m in lottos)
            {
                if (m == 0) 
                {
                    z++;
                    continue;
                }
                else
                {
                    foreach (int n in winNums)
                    {
                        if (m < n) break;
                        else if (m == n) 
                        {
                            c++;
                            break;
                        }
                    }
                }
            }
            answer[0] = c + z;
            answer[1] = c;
            for (int i = 0; i < 2; i++)
            {
                switch (answer[i])
                {
                    case 6 :
                        answer[i] = 1;
                        break;
                    case 5 :
                        answer[i] = 2;
                        break;
                    case 4 :
                        answer[i] = 3;
                        break;
                    case 3 :
                        answer[i] = 4;
                        break;
                    case 2 :
                        answer[i] = 5;
                        break;
                    default :
                        answer[i] = 6;
                    break;
                }
            }
            return answer;
        }
    }
}