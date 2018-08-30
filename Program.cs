using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RandomNumberGenerator = new Random();

            List<int> randomNumbers = new List<int>();
            for (int i = 0; i < 19; i++)
            {
                randomNumbers.Add(RandomNumberGenerator.Next(1, 51));
                // Console.WriteLine(randomNumbers[i]);
                // Console.WriteLine();
            }

            List<int> squaredNumbers = new List<int>();
            foreach (int number in randomNumbers)
            {
                squaredNumbers.Add(number * number);
                // Console.WriteLine($"{squaredNumbers[number]}");
                // Console.WriteLine();
            }

            List<int> oddlessNumbers = new List<int>();
            squaredNumbers.RemoveAll(i => i % 2 == 0);
            foreach (int oddNum in squaredNumbers)
            {

                Console.WriteLine($"{oddNum}");
                Console.WriteLine();
            }
        }
    }
}

