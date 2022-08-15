using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number = Int32.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;
            while (number > 0)
            {
                count++;
                sum += number % 10;
                number = number / 10;
            }
            Console.WriteLine("The digit in the number is {0}, and the sum of the digits is {1}", count, sum);
            Console.ReadLine();
        }
    }
}
