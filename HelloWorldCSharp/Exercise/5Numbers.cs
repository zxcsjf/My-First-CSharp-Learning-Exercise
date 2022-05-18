using System;
using System.Collections.Generic;
    /// <summary>
    /// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
    /// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
    /// and display the result on the console.
    /// </summary>
namespace HelloWorldCSharp.Exercise
{
    internal class FiveNumbers
    {
        private static void Run(string[] args)
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.WriteLine("enter a number");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("Error, the number has been enter!");
                    continue;
                }
                numbers.Add(number);
            }

            numbers.Sort();
            foreach (var number in numbers)
                Console.WriteLine(number);

        }
    }
}
