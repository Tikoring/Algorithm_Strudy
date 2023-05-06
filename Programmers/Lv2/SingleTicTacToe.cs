using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Programmers.Lv2.Problem
{
    public class SingleTicTacToe
    {
        public int Solution(String[] board) 
        {
            int answer = 0;
            int[] counter = {0, 0};
            int[] finish = {0, 0};
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i][j] == 'O') counter[0]++;
                    else if (board[i][j] == 'X') counter[1]++;
                }
            }
            if (counter[0] == counter[1]) odd = 0;
            else if (counter[0] == counter[1] + 1) odd = 1;
            else return 0;

            StringBuilder maker = new StringBuilder ();
            String[] seq = new String[8];
            int idx = 0;
            for (int i = 0; i < 3; i++)
            {
                seq[idx++] = new String (board[i]);
                for (int j = 0; j < 3; j++) 
                {
                    maker.Append (board[j][i]);
                }
                seq[idx++] = maker.ToString ();
                maker.Clear ();
            }
            for (int i = 0; i < 3; i++)
            {
                maker.Append (board[i][i]);
            }
            seq[idx++] = maker.ToString ();
            maker.Clear ();
            for (int i = 0; i < 3; i++)
            {
                maker.Append (board[2 - i][i]);
            }
            seq[idx++] = maker.ToString ();
            maker.Clear ();

            for (int i = 0; i < 8; i++)
            {
                if (seq[i].CompareTo ("OOO") == 0) finish[0]++;
                else if (seq[i].CompareTo ("XXX") == 0) finish[1]++;
            }

            if (finish[0] == finish[1] && finish[0] == 0) answer = 1;
            else if (finish[0] >= 1 && finish[1] == 0 && odd == 1) answer = 1;
            else if (finish[0] == 0 && finish[1] == 1 && odd == 0) answer = 1;
            else answer = 0;
            
            return answer;
        }
    }
}