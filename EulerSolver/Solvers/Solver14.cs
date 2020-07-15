using System;
using System.Collections;
using Tools;

namespace EulerSolver.Solvers
{
    public class Solver14 : ISolver
    {
        public double FindSolution()
        {
            int longestChainLengthSoFar = 351;
            int varWithLongestChain = 77031;

            //known that 77031, longest chain var under 100,000 is not the longest chain var under 1,000,000
            for (int incrementVar = 100001; incrementVar < 1000000; incrementVar ++)
            {
                //breaks the rule of not messing with for loop incrementation
                //but I want to test only odd numbers because they should be more likely to be the longest chain
                incrementVar++;

                int chainLength = this.ChainLength(incrementVar);

                if (chainLength > longestChainLengthSoFar)
                {
                    longestChainLengthSoFar = chainLength;
                    varWithLongestChain = incrementVar;
                }

            }

            return varWithLongestChain;

        }

        public int ChainLength(int input)
        {
            int currentVar = input;
            int chainLength = 1;

            while (currentVar != 1)
            {

                if (this.isEven(currentVar))
                {
                    currentVar = currentVar / 2;

                }

                else
                {
                    currentVar = (currentVar * 3) + 1;
                    //compressing # of steps; idea found from Wolfram Alpha's reference
                    //to Terras's modification of the problem
                    currentVar = currentVar / 2;
                    chainLength++;

                }

                chainLength++;

            }

            return chainLength;

        }

        public bool isEven(int input)
        {
            if (input % 2 == 0)
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
