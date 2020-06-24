namespace EulerSolver.Solvers
{
    public class Solver1 : ISolver
    {
        public int SumMultiplesUpTo(int max)
        {
            int sum = 0;
            // TODO: Implement summing multiples of 3 or 5 less than max

            int counter = 0;

            while (counter < max)
            {
                if (counter % 3 == 0 || counter % 5 == 0)
                {
                    sum += counter;
                }

                counter++;
            }

            return sum;
        }

        public string Solve()
        {
            return SumMultiplesUpTo(1000).ToString();
        }
    }
}
