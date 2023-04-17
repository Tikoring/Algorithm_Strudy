using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class ParkWalking
    {
        public int[] Solution(String[] park, String[] routes) 
        {
            int[] answer = new int[2] {0, 0};
            int v = park.Length;
            int h = park[0].Length;
            Dictionary<char, int[]> direction = new Dictionary<char, int[]> () {
                {'E', new int[] {0, 1}}, {'S', new int[] {1, 0}}, {'W', new int[] {0, -1}}, {'N', new int[] {-1, 0}}
            };
            for (int row = 0; row < park.Length; row++)
            {
                int col = park[row].IndexOf ('S');
                if (col >= 0)
                {
                    answer[0] = row;
                    answer[1] = col;
                    break;
                }
            }

            foreach (String r in routes)
            {
                int[] move = new int[2] {0, 0};
                Array.Copy (direction[r[0]], move, 2);
                move[0] *= Int32.Parse (r[2].ToString ());
                move[1] *= Int32.Parse (r[2].ToString ());

                int row = answer[0] + move[0];
                int col = answer[1] + move[1];
                if (row < 0 || row >= v || col < 0 || col >= h) continue;
                else if (move[0] > 0)
                {
                    String tmp = "";
                    for (int i = answer[0]; i <= row; i++)
                        tmp += park[i][col].ToString ();
                    if (tmp.IndexOf ('X') != -1) continue;
                }
                else if (move[0] < 0)
                {
                    String tmp = "";
                    for (int i = row; i <= answer[0]; i++)
                        tmp += park[i][col].ToString ();
                    if (tmp.IndexOf ('X') != -1) continue;
                }
                else if (move[1] > 0)
                {
                    String tmp = park[row].Substring (answer[1], move[1] + 1);
                    if (tmp.IndexOf ('X') != -1) continue;
                }
                else if (move[1] < 0)
                {
                    String tmp = park[row].Substring (col, -move[1] + 1);
                    if (tmp.IndexOf ('X') != -1) continue;
                }

                answer[0] = row;
                answer[1] = col;
            }

            return answer;
        }
    }
}