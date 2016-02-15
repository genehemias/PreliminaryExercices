
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammaticProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            Number1 LCM = new Number1();
            Number1A ImprovedLCM = new Number1A();

            Console.WriteLine("The smallest positive number that is evenly divisible by all of the numbers from 1 to 12 is:");
            Console.WriteLine("First attempt: " + LCM.FindLcm());
            Console.WriteLine("Recursive solution: " + ImprovedLCM.RecursiveFindLCM(1, 12));
            Console.WriteLine("Iterative solution: " + ImprovedLCM.IterativeFindLCM(1, 12));
            
            Number2 MultipleSum = new Number2();

            Console.WriteLine("The sum of all the multiples of 3 or 5 below 1000 is:");
            Console.WriteLine(MultipleSum.SumOfMultiples());

            Console.ReadKey();
        }
    }
}
