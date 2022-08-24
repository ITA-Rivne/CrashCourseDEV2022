using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Radiuk_Task209_210
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region InputData

            Console.WriteLine("Input numbers and strings:\n");

            Console.Write("Enter the first number: ");
            float inputNumberFirst = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            float inputNumberSecond = int.Parse(Console.ReadLine());

            Console.Write("Enter the first string: ");
            string inputStringFirst = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string inputStringSecond = Console.ReadLine();

            #endregion

            #region Task209

            var sumOfNumbers = Operations.Add(inputNumberFirst, inputNumberSecond);
            var concatOfStrings = Operations.Add(inputStringFirst, inputStringSecond);

            Console.WriteLine("\nTask 209:");
            Console.WriteLine($"The sum of numbers is {sumOfNumbers}.");
            Console.WriteLine($"The concatanetion of strings is '{concatOfStrings}'.");

            #endregion

            #region Task 210

            Console.WriteLine("\nTask 210:");

            List<char> charsToRemove = new List<char>() { '.', 'e', 'e' };
            List<int> indicesToRemove = new List<int> { 1, 0, 30, 3, 10 };

            string outputStringFirst = Operations.RemoveFromString(concatOfStrings, charsToRemove);
            string outputStringSecond = Operations.RemoveFromString(concatOfStrings, indicesToRemove);

            Console.WriteLine($"Output string 1 is '{outputStringFirst}'.");
            Console.WriteLine($"Output string 2 is '{outputStringSecond}'.");

            #endregion

            Console.ReadLine();
        }
    }
}
