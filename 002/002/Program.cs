using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            long limit = 4000000;
            long prev = 1;
            long next = 2;
            long sum = 0;

            while (prev < limit)
            {
                if (prev % 2 == 0)
                {
                    sum += prev;
                }
                long tmp = next;
                next = prev + next;
                prev = tmp;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
