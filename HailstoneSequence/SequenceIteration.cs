using System;
using System.Collections.Generic;
using System.Text;

namespace HailstoneSequence
{
    class SequenceIteration
    {
        public void HStoneIteration(int n)
        {
            Console.WriteLine(n);
            do
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                    Console.WriteLine(n);
                }
                else
                {
                    n *= 3;
                    n++;
                    Console.WriteLine(n);
                }
            } while (n != 1);
        }  
    }
}
