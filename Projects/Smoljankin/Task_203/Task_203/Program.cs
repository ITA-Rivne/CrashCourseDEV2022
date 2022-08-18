using System;

namespace Task_203
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; ;
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                if(x % 2 == 0)
                {
                    Console.WriteLine("Number is even");
                }
                else
                {
                    Console.WriteLine("Number is not even");
                }
                
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input format");
            }

        }
    }
}
