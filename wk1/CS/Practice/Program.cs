using System;

namespace Practice
{
    class Program
    {
        // class has members, fields or state, and members or behaviors

        // fields

        //methods
        static void Main(string[] args)
        {
            // Console.WriteLine("Please enter an integer: ");

            // string response = Console.ReadLine(); // Console.ReadLine() returns a string
            Calculator calc = new Calculator();
            



            // // try-catch is a graceful way to handle exceptions. Dont let your application crash, handle your exceptions!
            // try
            // {
            //     int n;
            //     if (int.TryParse(response, out n)) //don't force it and throw exceptions, try it first. if it works, awesome. 
            //         // if not, then let me know with a boolean value so i can decide what to do next.
            //     {
            //         calc.Calculate(n);
            //     }
            //     else
            //     {
            //         Console.WriteLine("Please enter an integer");
            //     }

            //     int number = int.Parse(response); // int.Parse(string) returns an int
            //     // int number = int.Parse(Console.ReadLine());
            //     calc.Calculate(number);
            // }
            // catch( Exception ex )
            // {
            //     Console.WriteLine("I don't know what you did, but that's not an integer!");
            //     return;
            // }


            // we need to declare some variables outside of the loops scope to use them in the loops
        int n;
        bool test;
        do // run the loop at least once
        {
            Console.WriteLine("Enter an integer: ");
            string input = Console.ReadLine();
            test = int.TryParse(input, out n); // if it works, it will assign the value to n, and either way, report the success or failure
            // to the test variable

        } while (!test); // while the test variable is false, keep looping

        calc.Calculate(n);
        }
    }
}