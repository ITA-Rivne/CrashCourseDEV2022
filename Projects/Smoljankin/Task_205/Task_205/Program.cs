using System;

namespace Task_205
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y=0;
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
               
                while(x != 0)
                {
                    y *= 10;
                    y += x % 10;
                    x /= 10;
                }
                Console.WriteLine("Кeversed number = " + y);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input format");
            }

        }
    }
}
