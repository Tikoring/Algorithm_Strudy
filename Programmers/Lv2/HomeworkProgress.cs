using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class HomeworkProgress
    {
        public String[] Solution(String[,] plans) 
        {
            String[] answer = new String[] {};
            Stack<String[]> waiting = new Stack<String[]> ();
            List<String> complete = new List<String> ();
            List<String[]> plan = new List<String[]> ();
            int currentTime = 0;

            for (int i = 0; i < plans.GetLength (0); i++)
            {
                String[] tmp = {plans[i, 0], plans[i, 1], plans[i , 2]};
                plan.Add (tmp);
            }
            plan = plan.OrderBy (x => x[1]).ToList ();
            currentTime = Int32.Parse (plan[0][1].Substring (0, 2)) * 60 + Int32.Parse (plan[0][1].Substring (3, 2));
            
            for (int i = 0; i < plan.Count; i++)
            {
                String[] now = plan[i];
                if (waiting.Count == 0)
                {
                    waiting.Push (now);
                }
                else 
                {
                    String[] prev = waiting.Pop ();
                    int play = Int32.Parse (prev[2]);
                    currentTime += play;
                    int nowT = Int32.Parse (now[1].Substring (0, 2)) * 60 + Int32.Parse (now[1].Substring (3, 2));
                    if (currentTime > nowT)
                    {
                        play = currentTime - nowT;
                        currentTime = nowT;
                        prev[2] = play.ToString ();
                        waiting.Push (prev);
                        waiting.Push (now);
                    }
                    else if (currentTime == nowT)
                    {
                        waiting.Push (now);
                        complete.Add (prev[0]);
                    }
                    else 
                    {
                        complete.Add (prev[0]);
                        while (waiting.Count > 0)
                        {
                            prev = waiting.Pop ();
                            play = Int32.Parse (prev[2]);
                            currentTime += play;
                            if (currentTime > nowT)
                            {
                                play = currentTime - nowT;
                                currentTime = nowT;
                                prev[2] = play.ToString ();
                                waiting.Push (prev);
                                break;
                            }
                            else if (currentTime == nowT)
                            {
                                complete.Add (prev[0]);
                                break;
                            }
                            else 
                            {
                                complete.Add (prev[0]);
                            }
                        }
                        waiting.Push (now);
                        currentTime = nowT;
                    }
                }
            }
            while (waiting.Count > 0)
            {
                String[] now = waiting.Pop ();
                complete.Add (now[0]);
            }
            answer = complete.ToArray ();
            return answer;
        }
    }
}