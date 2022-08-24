using System;

namespace Task_206
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, sum = 0;
            try
            {
                x = Convert.ToInt32(Console.ReadLine());

                while (x != 0)
                {
                    sum += x % 10;
                    x /= 10;
                }
                Console.WriteLine("Sum of digits = " + sum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input format");
            }
        }
    }
}
