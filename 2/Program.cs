using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int total = 0;
            int topLimit = Int32.MaxValue;

            Console.WriteLine(
                "By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            for (int i = 0; i < topLimit; i++)
            {
                var fibonacciNumber = Fibonacci(i);
                //Console.WriteLine(fibonacciNumber);
                if (fibonacciNumber % 2 == 0)
                {
                    total += fibonacciNumber;
                }
                else if(fibonacciNumber> 4000000)
                {
                    break;
                }
            }


            Console.WriteLine("Total: {0}", total);

            Console.WriteLine("Complete. Press enter to continue...");
            Console.ReadLine();
        }

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}