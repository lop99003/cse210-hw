using System;
using System.Collections.Generic;
using System.Linq; // Used for LINQ queries (Stretch Challenge)

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the entered numbers.
        List<int> numbersList = new List<int>();

        // Ask the user for a series of numbers until 0 is entered.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int enteredNumber;

        do
        {
            Console.Write("Enter number: ");
            enteredNumber = Convert.ToInt32(Console.ReadLine());

            // Append each entered number to the list.
            if (enteredNumber != 0)
            {
                numbersList.Add(enteredNumber);
            }

        } while (enteredNumber != 0);

        // Core Requirement 1: Compute the sum of the numbers in the list.
        int sum = numbersList.Sum();

        // Core Requirement 2: Compute the average of the numbers in the list.
        double average = numbersList.Average();

        // Core Requirement 3: Find the maximum number in the list.
        int maxNumber = numbersList.Max();

        // Output the results.
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");

        // Stretch Challenge 1: Find the smallest positive number in the list.
        int smallestPositive = numbersList.Where(num => num > 0).DefaultIfEmpty(0).Min();
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Stretch Challenge 2: Sort the numbers in the list and display the sorted list.
        numbersList.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (var number in numbersList)
        {
            Console.WriteLine(number);
        }
    }
}
