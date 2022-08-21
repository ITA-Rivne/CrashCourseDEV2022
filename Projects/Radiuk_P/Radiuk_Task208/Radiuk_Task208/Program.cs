using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiuk_Task208
{
    class Program
    {
        static void Main()
        {		
			// Define the input string
			Console.WriteLine("Enter the array of integers with ',' as a seperator:");
			string foo = Console.ReadLine();
			string[] tokens = foo.Split(',');

			// Define the array of integers
			List<int> arrayToCheck = new List<int>();

			// Add the entered from a keyboard integers to the array
			int numberToAdd;

            foreach (string s in tokens)
			{
				if (int.TryParse(s, out numberToAdd))
                {
					arrayToCheck.Add(numberToAdd);
                }
            }

			// Check whether at least one element is odd
			bool allAreEven = !arrayToCheck.Any(num => (num % 2) != 0);

			// Initialize the output value
            int numberMinOdd = 0;

			// If at least one element is odd, find the smallest one
			// Else throw an exception
            if (allAreEven == false)
			{
                numberMinOdd = arrayToCheck.Where(num => (num % 2) != 0).Min();
                Console.WriteLine($"The smallest odd number is {numberMinOdd}.");
            }
			else
			{
                Console.WriteLine($"No odd numbers found.");
            }
			Console.ReadLine();
		}
    }
}
