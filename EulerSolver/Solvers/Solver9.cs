using System;
using System.Collections;

namespace EulerSolver.Solvers
{
    public class Solver9 : ISolver
    {
        public int FindSolution()
        {
            for (int a = 1; a < 1000; a ++)
            {
                for (int b = 1; b < 1000; b++)
                {
                    for (int c = 1; c < 1000; c++)
                    {
                        if (this.isPythag(a,b,c) && this.AddsTo1000(a,b,c))
                        {
                            return (a * b * c);
                        }
                    }
                }
            }
            
            int result = 1;
            
            return result;
        }

        public bool isPythag(int a, int b, int c)
        {
            if (a == b || a == c || b == c)
            {
                return false;
            }
            if ((a * a) + (b * b) == (c * c))
            {
                return true;
            }
            if ((c * c) + (b * b) == (a * a))
            {
                return true;
            }
            if ((a * a) + (c * c) == (b * b))
            {
                return true;
            }
            return false;
        }

        public bool AddsTo1000(int a, int b, int c)
        {
            if(a+b+c == 1000)
            {
                return true;
            }
            return false;
        }

        string ISolver.Solve()
        {
            throw new NotImplementedException();
        }
    }

}
