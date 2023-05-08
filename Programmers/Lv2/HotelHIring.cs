using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Programmers.Lv2.Problem
{
    public class HotelHIring
    {
        public int Solution(string[,] book_time) 
        {
            int answer = 0;
            String[] start = new String[book_time.GetLength (0)];
            String[] end = new String[book_time.GetLength (0)];
            List<String> rooms = new List<string> ();
            StringBuilder maker = new StringBuilder ();
            for (int i = 0; i < book_time.GetLength (0); i++)
            {
                start[i] = book_time[i, 0];
                end[i] = book_time[i, 1];
            }
            Array.Sort (start, end);

            for (int i = 0; i < start.Length; i++)
            {
                int e = StringTimeToInt (end[i]) + 10;
                maker.Append (e / 60);
                maker.Append (':');
                if (e % 60 < 10) maker.Append (0);
                maker.Append (e % 60);
                if (rooms.Count == 0)
                {
                    rooms.Add (maker.ToString ());
                }
                else
                {
                    bool isNewRoom = true;
                    int s = StringTimeToInt (start[i]);
                    for (int j = 0; j < rooms.Count; j++)
                    {
                        int wait = StringTimeToInt (rooms[j]);
                        Console.WriteLine (rooms[j]);
                        if (wait <= s)
                        {
                            rooms[j] = maker.ToString ();
                            isNewRoom = false;
                            break;
                        }
                    }
                    if (isNewRoom)
                    {
                        rooms.Add (maker.ToString ());
                    }
                }
                maker.Clear ();
            }

            answer = rooms.Count;
            rooms.Clear ();
            return answer;
        }

        private int StringTimeToInt (String time)
        {
            return Int32.Parse (time.Substring (0, 2)) * 60 + Int32.Parse (time.Substring (3, 2));
        }
    }
}