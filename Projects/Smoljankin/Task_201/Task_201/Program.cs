using System;

namespace Task_201
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, average;
            try
            {
                x = Convert.ToSingle(Console.ReadLine());
                y = Convert.ToSingle(Console.ReadLine());
                average = (x + y) / 2;
                Console.WriteLine("Average = " + average);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Invalid input format");
            }
            
        }
    }
}
