using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Programmers.Lv1.Problem
{
    public class StarSquare
    {
        public void Solution (int a, int b) 
        {
            StringBuilder maker = new StringBuilder ();
            for (int i = 0; i < a; i++)
            {
                maker.Append ('*', b);
                if (i != a - 1) maker.Append ('\n');
            }

            Console.WriteLine (maker.ToString ());
        }
    }
}