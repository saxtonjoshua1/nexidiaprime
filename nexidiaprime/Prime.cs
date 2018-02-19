using System;
using System.Collections.Generic;
using System.Text;

namespace nexidiaprime
{

    public class Prime
    {
        public static List<long> Findprimes(long n)
        {
            var primelist = new List<long>();
            while (n % 2 == 0)
            {
                primelist.Add(2);
                n /= 2;
            }

            long factor = 3;
            while (factor * factor <= n)
            {
                if (n % factor == 0)
                {
                    primelist.Add(factor);
                    n /= factor;
                }
                else
                {
                    //Go to the next odd number
                    factor += 2;
                }
            }

            if (n > 1)
                primelist.Add(n);

            //negative numbers are assumed to be not prime
            if (n < 0)
                primelist.Add(0);

            return primelist;
        }

        public static bool IsPrime(long n)
        {
            if (Findprimes(n).Count == 1 && Findprimes(n)[0] != 0)
                return true;
            else
                return false;
        }
    }
}
