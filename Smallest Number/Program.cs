//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

using System;

namespace Smallest_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallest_number=1;

            while (smallest_number > 0)
            {
                
                if (smallest_number % 11 == 0 && smallest_number % 12 == 0 && smallest_number % 13 == 0
                && smallest_number % 14 == 0 && smallest_number % 15 == 0 && smallest_number % 16 == 0
                && smallest_number % 17 == 0 && smallest_number % 18 == 0 && smallest_number % 19 == 0
                && smallest_number % 20 == 0)
                {
                    Console.Write(smallest_number);
                    Console.Read();
                }
                else
                {
                    smallest_number += 1;
                }
            }

        }
    }
}
