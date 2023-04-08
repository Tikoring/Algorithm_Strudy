using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv0.Problem
{
    public class CharacterLoc
    {
        public int[] Solution(string[] keyinput, int[] board)
        {
            int[] answer = new int[] {0, 0};
            foreach (String key in keyinput) 
            {
                if (key.Equals ("up")) answer[0] += 1;
                else if (key.Equals ("left")) answer[1] += -1;
                else if (key.Equals ("right")) answer[1] += 1;
                else if (key.Equals ("down")) answer[0] += -1;

                if (answer[0] < -board[0] / 2) answer[0] += 1;
                else if (answer[0] > board[0] / 2) answer[0] += -1;
                else if (answer[1] < -board[1] / 2) answer[1] += 1;
                else if (answer[1] < board[1] / 2) answer[1] += -1;
            }
            return answer;
        }
    }
}