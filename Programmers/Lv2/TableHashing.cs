using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programmers.Lv2.Problem
{
    public class CompareByNth : IComparer<Table>
    {
        private int nth;

        public CompareByNth (int n)
        {
            this.nth = n;
        }

        public int Compare (Table x, Table y)
        {
            int nthX = x.Peek (nth);
            int nthY = y.Peek (nth);

            if (nthX.CompareTo (nthY) == 0)
            {
                return y.Peek (0).CompareTo (x.Peek (0));
            }

            return nthX.CompareTo (nthY);
        }
    }

    public class Table
    {
        private int n;
        private int[] d;
        public Table (int n)
        {
            this.n = n;
            d = new int[n];
        }

        public void Insert (int i, int e)
        {
            d[i] = e;
        }

        public int Peek (int i)
        {
            return d[i];
        }

        public int ModSum (int nth)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += d[i] % nth;
            }
            return sum;
        }
    }
    public class TableHashing
    {
        public int Solution(int[,] data, int col, int row_begin, int row_end) 
        {
            int answer = 0;
            int size = data.GetLength (1);
            CompareByNth cmp = new CompareByNth (col - 1);
            Table[] db = new Table[data.GetLength (0)];
            for (int i = 0; i < data.GetLength (0); i++)
            {
                db[i] = new Table (size);
                for (int j = 0; j < size; j++)
                {
                    db[i].Insert (j, data[i, j]);
                }
            }
            Array.Sort (db, cmp);

            for (int i = row_begin - 1; i < row_end; i++)
            {
                answer ^= db[i].ModSum (i + 1);
            }

            return answer;
        }
    }
}