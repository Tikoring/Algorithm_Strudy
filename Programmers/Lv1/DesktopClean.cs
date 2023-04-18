using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class DesktopClean
    {
        public int[] Solution(String[] wallpaper) 
        {
            int[] answer = new int[4] {wallpaper.Length, wallpaper[0].Length, -1, -1};
            int rMin = wallpaper.Length;
            int cMin = wallpaper[0].Length;
            int rMax = -1;
            int cMax = -1;

            for (int i = 0; i < wallpaper.Length; i++)
            {
                int idx = wallpaper[i].IndexOf ('#');
                if (idx >= 0)
                {
                    rMin = Math.Min (rMin, i);
                    cMin = Math.Min (cMin, idx);
                }
                idx = wallpaper[i].LastIndexOf ('#');
                if (idx >= 0)
                {
                    rMax = Math.Max (rMax, i + 1);
                    cMax = Math.Max (cMax, idx + 1);
                }
            }
            answer[0] = rMin;
            answer[1] = cMin;
            answer[2] = rMax;
            answer[3] = cMax;
            return answer;
        }
    }
}