using System;
using System.Collections.Generic;
//using MyLib_;
using static MyLib_.Lib;
namespace Console_201_206_Kyryk
{
    
    class Client
    {
        Dictionary<string, Action> actions = new Dictionary<string, Action>()
        {
            ["Average of two  numbers"] = Task201,
            ["Is numer even"] = Task203,
            ["Sum and count of digits"] = Task204,
            ["Reverse number"] = Task205,
            ["Sum of digits"] = Task206,
        };
        public void Run()
        {
            foreach (var a in actions)
            {
                Console.WriteLine($"\n_______________{a.Key.ToUpper()} _______________\n");
                a.Value();
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void Task201() 
        {
            int number1 = InputIntNumber();
            int number2 = InputIntNumber();
            Console.WriteLine($"\t\tAverage :  { (double)(number1 + number2)/2}");
        }
        public static void Task203() 
        {
            int number = InputIntNumber();
            Console.WriteLine($"\t\tIs even {number} ::  {IsEven(number)}");
        }
        public static void Task205() 
        {
            int number = InputIntNumber();
            Console.WriteLine($"\t\tReverse  of {number} ::  {ReverseNumber(number)}");
        }
        public static void Task206() 
        {
            int number = InputIntNumber();
            var result = CountSumOfDigits(number);
            Console.WriteLine($"\t\tSum of digits  ::  {result.sumDigits}");
        }
        public static void Task204() 
        {
            int number = InputIntNumber();
            var result = CountSumOfDigits(number);
            Console.WriteLine($"\t\tCount  of digits  ::  {result.countDigits}");
            Console.WriteLine($"\t\tSum    of digits  ::  {result.sumDigits}");
        }
    }
}
