using System;

namespace HailstoneSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            Console.WriteLine("Recursion:");
            SequenceRecursion sr = new SequenceRecursion();
            sr.HStoneRecursion(n);
            Console.WriteLine("\nIteration:");
            SequenceIteration si = new SequenceIteration();
            si.HStoneIteration(n);
            
        }
    }
}
