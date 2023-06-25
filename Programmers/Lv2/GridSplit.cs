using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class GridSplit
    {
        public int Solution(int n, int[,] wires) 
        {
            int answer = int.MaxValue;
            Dictionary<int, List<int>> connection = new Dictionary<int, List<int>> ();
            for (int i = 0; i < n - 1; i++)
            {
                connection.Clear ();
                int c = 0;
                HashSet<int> g1 = new HashSet<int> ();
                HashSet<int> g2 = new HashSet<int> ();
                g1.Add (wires[i, 0]);
                g2.Add (wires[i, 1]);
                for (int j = 1; j <= n; j++)
                {
                    connection.Add (j, new List<int> ());
                }
                for (int j = 0; j < n - 1; j ++)
                {
                    if (i == j) {continue;}
                    int n1 = wires[j, 0];
                    int n2 = wires[j, 1];
                    connection[n1].Add (n2);
                    connection[n2].Add (n1);
                }
                int size = 0;
                do
                {
                    size = g1.Count;
                    HashSet<int> nodes = new HashSet<int> ();
                    foreach (int nd in g1)
                    {
                        foreach (int cn in connection[nd])
                        {
                            nodes.Add (cn);
                        }
                    }
                    foreach (int nd in nodes)
                    {
                        g1.Add (nd);
                    }

                } while (size != g1.Count);

                size = 0;
                do
                {
                    size = g2.Count;
                    HashSet<int> nodes = new HashSet<int> ();
                    foreach (int nd in g2)
                    {
                        foreach (int cn in connection[nd])
                        {
                            if (nodes.Contains (cn)) {continue;}
                            nodes.Add (cn);
                        }
                    }
                    foreach (int nd in nodes)
                    {
                        g2.Add (nd);
                    }

                } while (size != g2.Count);
                c = g1.Count - g2.Count;
                answer = Math.Min (answer, Math.Abs (c));
            }
            return answer;
        }
    }
}