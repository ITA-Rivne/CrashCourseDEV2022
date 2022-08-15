using System;
using System.Collections.Generic;

class Task_203
{
    static void Main()
    {

        while (true)
        {
            int number;

            try
            {
                Console.WriteLine("Input Number: ");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Result: " + (number % 2 == 0 ? "pair" : "odd"));
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }
    }
}