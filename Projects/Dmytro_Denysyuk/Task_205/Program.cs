using System;
using System.Collections.Generic;

class Task_205
{
    static void Main()
    {
        int number;
        while (true)
        {
            try
            {
                Console.WriteLine("Input number:");
                number = Convert.ToInt32(Console.ReadLine());
                Console.Write(number > 0 ? "-" : "");
                number = System.Math.Abs(number);
                char[] charArr = number.ToString().ToCharArray();
                Array.Reverse(charArr);
                foreach (char ch in charArr)
                    Console.Write(ch);
                Console.WriteLine();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }
    }
}