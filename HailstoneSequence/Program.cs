using System;

namespace HailstoneSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 9;
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
