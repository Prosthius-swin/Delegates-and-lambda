using System;
//using System.Generic.

namespace delegates_and_lambda_tasks
{
    class example
    {
        static void examples(string[] args)

        // Action - Does not return a value

        // Func - returns a value
        {
            Action<string> printGreeting = (n) => {Console.WriteLine("Hi " + n);};

            Func<int, int, string> multiplier = (x, y) => {return "The product is " + (x * y).ToString();};

            printGreeting("Bob");

            multiplier(5, 10);

            // JS - myFunct = (n) => {console.log("Hi " + n);};
        }
    }
}
