using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class EmoticonDiscount
    {
        public int[] Solution(int[,] users, int[] emoticons) 
        {
            int[] answer = new int[2] {0, 0};
            int choiceSize = emoticons.Length;
            int[] choice = new int[choiceSize];
            int[] discount = new int[4];
            for (int i = 0; i < 4; i++)
            {
                discount[i] = (i + 1) * 10;
            }

            DFS (ref choice, discount, emoticons, users, 0, choiceSize, answer);

            return answer;
        }

        private void DFS (ref int[] choice, int[] discount, int[] price, int[,] users, int n, int size, int[] answer)
        {
            n++;
            for (int i = 0; i < discount.Length; i++)
            {
                choice[n - 1] = discount[i];
                if (n == size)
                {
                    int[] sales = new int[users.GetLength (0)];
                    int publish = 0;
                    int purchase = 0;
                    for (int j = 0; j < sales.Length; j++)
                    {
                        for (int k = 0; k < size; k++)
                        {
                            if (choice[k] >= users[j, 0])
                            {
                                if (choice[k] == 10) sales[j] += (int) (price[k] * 9 / 10);
                                else if (choice[k] == 20) sales[j] += (int) (price[k] * 8 / 10);
                                else if (choice[k] == 30) sales[j] += (int) (price[k] * 7 / 10);
                                else sales[j] += (int) (price[k] * 6 / 10);
                            }
                        }
                        if (sales[j] >= users[j, 1]) publish += 1;
                        else purchase += sales[j];
                    }
                    if (publish > answer[0]) 
                    {
                        answer[0] = publish;
                        answer[1] = purchase;
                    }
                    else if (publish == answer[0] && purchase > answer[1])
                    {
                        answer[1] = purchase;
                    }
                    continue;
                }
                DFS (ref choice, discount, price, users, n, size, answer);
            }
        }
    }
}