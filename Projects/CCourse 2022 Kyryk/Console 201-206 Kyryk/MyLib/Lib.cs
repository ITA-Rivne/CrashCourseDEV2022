using System;
using System.Linq;

namespace MyLib_
{
    public static class Lib
    {

        public static int InputIntNumber()
        {
            int number;
            Console.WriteLine("\t\tEnter int number : ");
            while (!int.TryParse(Console.ReadLine(), out  number))
            {
                Console.WriteLine("\t\tTry  again! Enter int number : ");
            }

            return number;
        }
        public static bool IsEven(int number) => number % 2 == 0;
        public static (int countDigits, int sumDigits) CountSumOfDigits(int number)
        {
            string numberStr = Math.Abs(number).ToString();

            int counter = numberStr.Length;
            int sum = numberStr.Sum(c=> c - '0');

            return (counter, sum);
        }
        public static int ReverseNumber(int number)
        {
            int tmp = Math.Abs(number);
            int sign = number >= 0? 1 : -1;
            int reverse = 0;
            while (tmp != 0)
            {
                reverse *= 10;
                reverse += tmp % 10;
                tmp /= 10;
            }
            return reverse *  sign;
        }

    }
}
