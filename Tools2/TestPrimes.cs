using System;
using System.Collections;

namespace Tools
{
    public class TestPrimes
    {
        public bool isPrime(long num)
        {
            bool result = true;

            if (num == 2 || num == 3)
            {
                return true;
            }

            if(num == 4)
            {
                return false;
            }

            for (long i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    result = false;
                    return result;
                }
            }

            return result;

        }

    }
}
