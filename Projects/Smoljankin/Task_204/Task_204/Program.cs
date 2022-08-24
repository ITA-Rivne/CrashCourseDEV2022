using System;

namespace Task_204
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, count = 0, sum = 0;
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                
                while(x != 0)
                {
                    count++;
                    sum += x % 10;
                    x /= 10;
                }
                Console.WriteLine("number of digits = " + count + "\nsum of digits = " + sum);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input format");
            }
        }
    }
}
