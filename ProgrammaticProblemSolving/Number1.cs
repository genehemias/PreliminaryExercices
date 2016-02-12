using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammaticProblemSolving
{
    class Number1
    {
        //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder. 
        //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 12?

        public int FindLcm()
        {
            var twelves = new List<int>();
            var elevens = new List<int>();
            var tens = new List<int>();
            var nines = new List<int>();
            var eights = new List<int>();
            var sevens = new List<int>();
            var sixes = new List<int>();
            var fives = new List<int>();
            var fours = new List<int>();

            for (int i = 1; i <= 10000; i++)
            {
                twelves.Add(i * 12);
                elevens.Add(i * 11);
                tens.Add(i * 10);
                nines.Add(i * 9);
                eights.Add(i * 8);
                sevens.Add(i * 7);
                sixes.Add(i * 6);
                fives.Add(i * 5);
                fours.Add(i * 4);
            }

            var multiples = 
                twelves.Intersect(elevens).
                Intersect(tens).Intersect(nines).
                Intersect(eights).Intersect(sevens)
                .Intersect(sixes).Intersect(fives).
                Intersect(fours).ToList();

            return multiples[0];
        }
    }
}
