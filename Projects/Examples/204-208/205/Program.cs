using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _206
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number = Int32.Parse(Console.ReadLine());
            int reversNum = 0;
            while (number > 0)
            {
                reversNum = number % 10;
                number = number / 10;
                Console.Write(reversNum);
            }
            
            Console.ReadLine();
        }
    }
}
