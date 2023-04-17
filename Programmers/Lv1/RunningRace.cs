using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class RunningRace
    {
        public String[] Solution(String[] players, String[] callings) 
        {
            String[] answer = new String[] {};
            Dictionary<String, int> loc = new Dictionary<String, int> ();
            for (int i = 0; i < players.Length; i++)
                loc.Add (players[i], i);

            foreach (String name in callings)
            {
                int idx = loc[name];
                String tmp = players[idx - 1];
                players[idx - 1] = name;
                players[idx] = tmp;
                loc[name] = idx - 1;
                loc[tmp] = idx;
            }
            answer = players;
            return answer;
        }
    }
}