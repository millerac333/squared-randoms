﻿// With the resulting List, populate a new List that contains each number squared. For example, if the original list is 2, 5, 3, 15, the final list will be 4, 25, 9, 225.

// Then remove any number that is odd from the list of squared numbers.

using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using the Random class, generate a list of 20 random numbers that are in the range of 1-50.
            Random randomNumberGenerator = new Random();

            // // Create a list
            List<int> randomNumbers = new List<int>();

            // // Populate the list
            for (int number = 0; number <= 19; number++)
            {
                randomNumbers.Add(randomNumberGenerator.Next(1, 51));
                Console.WriteLine($"{randomNumbers[number]}");
            }

        }
    }
}
