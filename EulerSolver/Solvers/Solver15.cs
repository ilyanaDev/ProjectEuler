using System;
using System.Collections;
using Tools;

namespace EulerSolver.Solvers
{
    public class Solver15 : ISolver
    {
        //essential question: how many unique arrangements of 20 rights and 20 downs?
        public double FindSolution(int sidelengths)
        {

            double result = this.FindFactorial(sidelengths * 2) / 
                (this.FindFactorial(sidelengths) * this.FindFactorial(sidelengths));

            return result;
        }

        public double FindFactorial(int num)
        {
            double result = 1;
            for(int i = 1; i <=  num; i ++)
            {
                result = result * i;
            }

            return result;

        }

        string ISolver.Solve()
        {
            throw new NotImplementedException();
        }
    }

}
