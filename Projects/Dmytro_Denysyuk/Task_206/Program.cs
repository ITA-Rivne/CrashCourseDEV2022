using System;
using System.Collections.Generic;

class Task_206
{
    static void Main()
    {
        int number, sum=0;
        while (true)
        {
            try
            {
                Console.WriteLine("Input number:");
                number = Convert.ToInt32(Console.ReadLine()); 
                number = System.Math.Abs(number);
                char[] charArr = number.ToString().ToCharArray();
                foreach (char ch in charArr)
                    sum += Convert.ToInt32(ch.ToString());
                Console.WriteLine($"Sum numbers: {sum}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }
    }
}