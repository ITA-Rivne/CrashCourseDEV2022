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
            Console.WriteLine($"{value1} +  {value2}  = {Worker.Add(value1, value2)}");

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
            Console.WriteLine($"'{rndStr1}' + '{rndStr2}' = '{Worker.Add(rndStr1, rndStr2)}'");

            string generateRndWord(List<string> baseWords)
            {
                return baseWords[rnd.Next(0, baseWords.Count)];
            }
        }
        public static void Task_210()
        { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Client.Task_209();
        }
    }
}
