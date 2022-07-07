using System;

namespace Practice
{
    class Calculator
    {
        // Fields

        // Methods
        public void Calculate(int n)
        {
            // print every multiple of 3
            // between 1 and n
            // in reverse order

            // +, -, *, /, %
            // % is modulus, and returns the remainder of a division
            // n % 3  = ?

            // find the highest number that is a multiple of 3 that is less than n
            int start = n - (n % 3);

            // loop, that decreases by 3 every iteration, and prints the current value, until <= 3

            // for ( int i = start; i >= 3; i = i-3 ) // i-=3
            // {
            //     Console.WriteLine(i);
            // }
            
            if ( start >= 3)
            {
                while ( start >= 3 )
                {
                    Console.WriteLine(start);
                    start -= 3;
                }
            }
            else
            {
                Console.WriteLine("Number has no multiples of 3, or is not greater than 3");
            }
        }
    }
}