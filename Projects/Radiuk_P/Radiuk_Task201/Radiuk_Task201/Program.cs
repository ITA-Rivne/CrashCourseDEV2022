using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiuk_Task201
{
    class Program
    {
        static void Main(string[] args)
        {
            // The initialization of variables
            double numberFirst, numberSecond;

            Console.Write("Enter the first number: ");
            numberFirst = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            numberSecond = double.Parse(Console.ReadLine());

            // The average of two numebrs
            double numberAverage = (numberFirst + numberSecond) / 2;
            Console.WriteLine("The average numbers is {0}.", numberAverage);
            Console.ReadLine();
        }
    }
}
