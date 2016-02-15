using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammaticProblemSolving
{
    class Number1A
    {
        //This seems more 'right'
        public int RecursiveFindLCM(int first, int last)
        {
            bool thereYet = true;

            for (int i = last; i >= 1; i--)
            {
                while (first%i != 0)
                {
                    first++;
                    thereYet = false;
                }
            }

            if (!thereYet)
            {
                first = RecursiveFindLCM(first, last);
            }

            return first;
        }

        //but this one can do numbers greater than 12!
        public long IterativeFindLCM(long first, long last)
        {
            bool solvedYet = false;

            while (!solvedYet)
            {
                solvedYet = true;
                for (long i = last; i >= 1; i--)
                {
                    while (first%i != 0)
                    {
                        first++;
                        solvedYet = false;
                    }
                }
            }
            return first;
        }
    }
}
