using System;
using System.Collections.Generic;

namespace Console_209_210_Kyryk
{
    class Client
    {
        //Написати overload методи Add які в залежності від параметрів або додають цифрові значення, або об'єднують введені тексти.
        //Передбачити аргументи за замовчуванням і використання статичних полів\методів
        public static void Task_209()
        {
            Random rnd = new Random();

            int value1 = rnd.Next(0, 100);
            int value2 = rnd.Next(0, 200);
            Console.WriteLine($"{value1} +  {value2}  = {WorkerAddition.Add(value1, value2)}");

            List<string> languages = new List<string>() 
            { 
                "C#", " C++", "Python", "JavaScript", "Java"
            };
            List<string> elements = new List<string>()
            {
                "OOP", "Method", "Class", "Cycles", "Operators", "GitHub"
            };
            string rndStr1 = generateRndWord(languages);
            string rndStr2 = generateRndWord(elements);
            Console.WriteLine($"'{rndStr1}' + '{rndStr2}' = '{WorkerAddition.Add(rndStr1, rndStr2)}'");

            string generateRndWord(List<string> baseWords)
            {
                return baseWords[rnd.Next(0, baseWords.Count)];
            }
        }
        //Написати overload методи RemoveFromString, які приймають текст і видаляють з нього або певний набір символів,
        //або символ\символи за порядковим номером в тексті.
        //Реалізувати використання аргументів за замовчуванням
        public static void Task_210()
        {
            string str = @"Git is a version control system.
Git helps you keep track of code changes.
Git is used to collaborate on code.";

            string result = WorkerString.RemoveString(str, "oe.");
            Console.WriteLine(result);
            Console.WriteLine();
            string result2 = WorkerString.RemoveString(str,  0, 2, 4, 5);
            Console.WriteLine(result2);
            
            Console.WriteLine();
            string result3 = WorkerString.RemoveString(str,   2, 4, 0,  5);
            Console.WriteLine(result3);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Client.Task_209();
            Client.Task_210();
        }
    }
}
