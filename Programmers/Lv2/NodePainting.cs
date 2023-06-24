using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Programmers.Lv2.Problem
{
    public class NodePainting
    {
        private struct Pair
        {
            public long x {get;}
            public long y {get;}

            public Pair (long x, long y)
            {
                this.x = x;
                this.y = y;
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }
                else if (!(obj is Pair))
                {
                    return false;
                }
                return (x == ((Pair)obj).x) && (y == ((Pair)obj).y);
            }

            public override int GetHashCode()
            {
                return x.GetHashCode () ^ y.GetHashCode ();
            }
        }

        public string[] Solution(int[,] line) 
        {
            List<String> answer = new List<String> ();
            HashSet<Pair> dots = new HashSet<Pair> ();
            List<StringBuilder> maker = new List<StringBuilder> ();
            
            for (int i = 0; i < line.GetLength (0); i++)
            {
                for (int j = 0; j < line.GetLength (0); j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    int a = line[i, 0];
                    int b = line[i, 1];
                    int c = line[i, 2];
                    int d = line[j, 0];
                    int e = line[j, 1];
                    int f = line[j, 2];
                    if ((long) a * e == (long) b * d)
                    {
                        continue;
                    }
                    else
                    {
                        if (((long) d * c - (long) a * f) % ((long) a * e - (long) b * d) == 0 &&
                            ((long) b * f - (long) e * c) % ((long) a * e - (long) b * d) == 0)
                        {
                            dots.Add (new Pair (((long) b * f - (long) e * c) / ((long) a * e - (long) b * d),
                            ((long) d * c - (long) a * f) / ((long) a * e - (long) b * d)));
                        }
                    }
                }
            }
            long minx = long.MaxValue;
            long maxx = long.MinValue;
            long miny = long.MaxValue;
            long maxy = long.MinValue;
            foreach (Pair d in dots)
            {
                minx = Math.Min (minx, d.x);
                maxx = Math.Max (maxx, d.x);
                miny = Math.Min (miny, d.y);
                maxy = Math.Max (maxy, d.y);
            }
            
            for (int i = 0; i <= maxy - miny; i++)
            {
                maker.Add (new StringBuilder ().Append ('.', (int) (maxx - minx + 1)));
            }

            foreach (Pair d in dots.ToArray ())
            {
                maker[(int) (maxy - d.y)].Replace ('.', '*', (int) (d.x - minx), 1);
            }

            for (int i = 0; i < maker.Count; i++)
            {
                answer.Add (maker[i].ToString ());
            }

            return answer.ToArray ();
        }
    }
}