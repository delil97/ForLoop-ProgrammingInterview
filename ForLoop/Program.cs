using System;
using System.Collections.Generic;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersDivisibleByThree = new List<int>();
            List<int> numbersDivisibleByFive = new List<int>();

            for (int n = 200 - 1; n >= 100; n--) //counts from 200 to 100
            {
                if(n % 3 == 0) // checks if the number is divisible by three
                {
                    numbersDivisibleByThree.Add(n);
                    Console.WriteLine("This number is divided by three: " + n);
                }
                else if (n % 5 == 0)// checks if the number is divisible by three
                {
                    numbersDivisibleByFive.Add(n); 
                    Console.WriteLine("This number is divided by five: " + n);
                }

            }
        }
    }
}
