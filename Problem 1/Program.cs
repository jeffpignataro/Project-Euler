using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int multipleOf3 = 0, multipleOf5 = 0;
            int topLimit = 1000;
            int total = 0;

            Console.WriteLine("Find the sum of all the multiples of 3 or 5 below 1000.");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            for (int bottomLimit = 1; bottomLimit < topLimit; bottomLimit++)
            {
                bool isMultiple = false;
                if (bottomLimit % 3 == 0)
                {
                    Console.WriteLine("Multiple of 3: {0}", bottomLimit);
                    isMultiple = true;
                }
                else if (bottomLimit % 5 == 0)
                {
                    Console.WriteLine("Multiple of 5: {0}", bottomLimit);
                    isMultiple = true;
                }
                else
                {
                    Console.WriteLine(bottomLimit);
                }

                if (isMultiple)
                {
                    total += bottomLimit;
                }
            }

            Console.WriteLine("Total: {0} Press enter to continue...", total);

            Console.WriteLine("Complete. Press enter to continue...");
            Console.ReadLine();
        }
    }
}
