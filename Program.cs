// With the resulting List, populate a new List that contains each number squared. For example, if the original list is 2, 5, 3, 15, the final list will be 4, 25, 9, 225.

// Then remove any number that is odd from the list of squared numbers.

using System;
using System.Linq;
using System.Collections.Generic;

namespace random
{
    // {public static void Display(List<int> allTheLists) => stringNumbers = string.Join(", ", allTheLists); Console.WriteLine(stringNumbers); Console.WriteLine();}
    class Program
    {
        static void Main(string[] args)
        {
            {
                Random RandomNumGenerator = new Random();

                List<int> randomNumbers = new List<int>();

                for (int i = 0; i < 20; i++)
                {
                    randomNumbers.Add(RandomNumGenerator.Next(1, 51));
                    Console.WriteLine(randomNumbers[i]);
                }
            }
        }
    }
}
