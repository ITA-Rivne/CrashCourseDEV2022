using System;
using System.Collections.Generic;

class Task_201
{
    static void Main()
    {
        int num_1, num_2;
        double res;
        while (true)
        {
            try
            {
                Console.WriteLine("Input Number 1");
                num_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Number 2");
                num_2 = Convert.ToInt32(Console.ReadLine());
                res = (double)((num_1 + num_2) / 2);
                Console.WriteLine("Result: " + res.ToString());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }
    }
}