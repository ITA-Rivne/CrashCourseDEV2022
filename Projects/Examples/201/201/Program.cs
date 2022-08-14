using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter first number");
           double firstNum = Double.Parse(Console.ReadLine());
           Console.WriteLine("Enter second number");
           double secondNum = Double.Parse(Console.ReadLine());
           Console.WriteLine("The arithmetic mean is: "+ (firstNum+secondNum)/2);
           Console.ReadLine();
           
        }
    }
}
