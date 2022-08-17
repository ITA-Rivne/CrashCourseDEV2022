using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            double num = Double.Parse(Console.ReadLine());
            if (num % 2 == 0)  Console.WriteLine("The number is even"); 
            else  Console.WriteLine("The number is odd"); 
            Console.ReadLine();
        }
    }
}
