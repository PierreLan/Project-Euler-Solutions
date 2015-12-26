using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 600851475143;
            while (true)
            {
                long p = GetSmallestPrimeFactor(n);
                if (p < n)
                {
                    n /= p;
                }
                else
                {
                    Console.WriteLine("largest prime factor: " + n);
                    Console.ReadKey();
                    return;
                }
            } 
        }

        private static long GetSmallestPrimeFactor(long n)
        {
            if(n == 1)
            {
                return 1;
            }

            for (long i = 2, end = (long)Math.Sqrt(n); i <= end; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    return i;
                }
            }
            return n;
        }
    }
}
