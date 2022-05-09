using System;
using System.Linq;
using System.Collections.Generic;

namespace delegates_and_lambda_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1
            //Action<string> printWelcome = (n) => {Console.WriteLine($"Welcome {n}");};
            //printWelcome("John");

            //Q2
            //Func<int, int, int> addTwoNums = (x, y) => {return (x + y);};
            //Console.WriteLine(addTwoNums(10, 31));

            //Q3
            /*Action<int> sumArray = (q) => 
            {
                int[] nums = new int[5];
                Console.WriteLine("Input 5 numbers");
                Console.WriteLine();

                for(int i = 0; i < 5; i++)
                {
                    Console.Write($"element - {i} : ");
                    nums[i] = int.Parse(Console.ReadLine());
                }
                int arrSum = nums.Sum();

                Console.WriteLine(arrSum);
            };
            sumArray(1);*/

            //Q4
            //Func<int, int, double> powerTo = (x, y) => {return Math.Pow(x, y);};
            //Console.WriteLine(powerTo(3, 3));

            //Q5
            Action<int> fibonacciSequence = (q) => 
            {
                int first = 0;
                int second = 1;

                List<int> sequence = new List<int>();

                Console.Write("Enter a number : ");
                int counter  = int.Parse(Console.ReadLine());

                if(counter >= 1)
                {
                    sequence.Add(0);
                } else if (counter >= 2)
                {
                    sequence.Add(1);
                }

                for(int i = 2; i < counter; i++)
                {
                    int oneTwo = first + second;
                    first = second;
                    second = oneTwo;
                    sequence.Add(oneTwo);
                }

                Console.WriteLine();

                foreach(int fib in sequence)
                {
                    Console.Write($"{fib} ");
                }
            };

            fibonacciSequence(1);
        }
    }
}
