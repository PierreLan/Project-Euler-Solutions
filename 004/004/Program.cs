using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _004
{
    class Program
    {
        static void Main(string[] args)
        {
            long maxPalindrome = -1;
            for (long i = 100; i < 1000; i++)
            {
                for (long j = i; j < 1000; j++)
                {
                    long product = i*j;
                    if(IsPalindrome(product) && maxPalindrome < product)
                    {
                        maxPalindrome = product;
                    }
                }
            }
            Console.WriteLine(maxPalindrome);
            Console.ReadKey();
        }

        static bool IsPalindrome(long n)
        {
            string str = n.ToString();
            for (int lower = 0, upper = str.Length - 1; lower < upper; lower++, upper--)
            {
                if(str[lower] != str[upper])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
