using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv1.Problem
{
    public class DayCalculationOf2016
    {
        public String solution(int a, int b) 
        {
            String answer = "";
            String[] dayOfWeek = {"THU", "FRI", "SAT", "SUN", "MON", "TUE", "WED"};
            int[] days = {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            int day = b;
            for (int i = 0; i < a - 1; i++)
                day += days[i];
            answer = dayOfWeek[day % 7];
            return answer;
        }
    }
}