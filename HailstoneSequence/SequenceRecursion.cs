using System;
using System.Collections.Generic;
using System.Text;

namespace HailstoneSequence
{
    class SequenceRecursion
    {
        public int HStoneRecursion(int n)
        {
            Console.WriteLine(n);
            if (n == 1)
                return n;
            else if (n % 2 == 0)
            {
                return HStoneRecursion(n /= 2);
            }
            else
            {
                return HStoneRecursion((n *= 3) + 1);
            }
        }
    }
}
