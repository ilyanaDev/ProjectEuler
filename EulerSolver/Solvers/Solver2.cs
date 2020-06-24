using System.Collections;

namespace EulerSolver.Solvers
{
    public class Solver2 : ISolver
    {
        public int SumEvenSequenceUpTo(int max)
        {
            int sum = 0;

            ArrayList sequence = this.GenerateSequenceUpTo(max);

            foreach (int elmnt in sequence)
            {
                if (elmnt % 2 == 0)
                {
                    sum += elmnt;
                }
            }

            return sum;

        }

        public ArrayList GenerateSequenceUpTo(int max)
        {
            ArrayList FibSeq = new ArrayList();
            FibSeq.Add(1);
            FibSeq.Add(2);

            int index = 1;

            while ((int)FibSeq[index] < max)
            {
                FibSeq.Add((int)FibSeq[index] + (int)FibSeq[index - 1]);

                index++;

                if ((int) FibSeq[index] > max)
                {
                    FibSeq.Remove(index);
                }
            }

            return FibSeq;

        }

        public string FSArrListToString(ArrayList FS)
        {
            string output = "";

            foreach (int elmnt in FS)
            {
                output = output + elmnt + ",";
            }

            return output;
        }

        public string Solve()
        {
            return SumEvenSequenceUpTo(1000).ToString();
        }
    }
}
