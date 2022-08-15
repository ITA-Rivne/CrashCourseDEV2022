using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple Tasks

            //Average of two numerics
            Console.WriteLine("-------Average of 2 numerics-------");
            Console.WriteLine("Input two numerics");
            float a1 = Convert.ToSingle (Console.ReadLine());
            float a2 = Convert.ToSingle (Console.ReadLine());
            float aver = (a1 + a2) / 2;
            Console.WriteLine("Average of " + a1 + " and "+ a2 + " is ="+ aver);
            Console.ReadKey();

            //Text from Shakespeare
            Console.WriteLine("-------Text from Shakespeare-------");
            Console.WriteLine("To be or not to be \n\\ Shakespeare \\");
            Console.ReadKey();

            //Check for parity
            Console.WriteLine("-------Check for Parity-------");
            Console.WriteLine("Input numeric:");
            int a3 = Convert.ToInt32(Console.ReadLine());
            if (a3 % 2 == 0) Console.WriteLine("Pair");
            else Console.WriteLine("Odd");
            Console.ReadKey();

            //Quantity of digits and its sum of numeric from 0 to 99
            Console.WriteLine("-------Quantity of digits and its sum of numeric from 0 to 99-------");
            Console.WriteLine("Input numeric:");
            int a4 = Convert.ToInt32(Console.ReadLine());
            if (a4 < 100)
            {
                Console.WriteLine(a4.ToString().Length );
                Console.WriteLine(a4.ToString().Sum((c => c - '0')));
            }
            else Console.WriteLine("So big numeric!");
            Console.ReadKey();
        }
    }
}
