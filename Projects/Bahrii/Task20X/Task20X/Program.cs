using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20X
{
    class Program
    {
       
        static private float Add(float a = 0, float b = 0, float c = 0)
        {
            return a + b + c;
        }
        static private string Add(string a = "", string b = "", string c = "")
        {
             return string.Join(" ", new string[3] { a, b, c});
        }

        static private string RemoveFromString(string str, char[] charsToRemove)
        {
            foreach (var c in charsToRemove)
            {
                str = str.Replace(c.ToString(), string.Empty);
            }
            return str;
        }

        static private string RemoveFromString(string str, int[] indexToRemove)
        {
            int offset = 0;
            foreach (var pos in indexToRemove)
            {
                if (pos > str.Length - 1) break;
                str = str.Remove(pos - offset, 1);
                offset++;
            }
            return str;
        }

        static void Main(string[] args)
        {
            #region//Task 209
            /*Написати overload методи Add які в залежності від параметрів або додають цифрові значення,
            * або об'єднують введені тексти. Передбачити аргументи за замовчуванням і використання статичних полів\методів
            * */
            Console.WriteLine("Task 209");

            var result = Add("1", "2", "3");

            Console.WriteLine("Join: {0}", result);
                     
            var result2 = Add(1, 2, 3);

            Console.WriteLine("Sum: {0}", result2);

            #endregion

            #region//Task 210
            //Написати overload методи RemoveFromString, які приймають текст і видаляють з нього або певний набір символів, 
            //або символ\символи за порядковим номером в тексті. Реалізувати використання аргументів за замовчуванням

            Console.WriteLine("\nTask 210");
            string inputStr = "Написати overload методи RemoveFromString";
            char[] charsToRemove = new char[8] { 'а', 'и', 'і', 'е', 'о', 'я', 'ь', 'ю' };
            int[] indexToRemove = new int[4] { 1, 3, 5, 6 };

            string result3 = RemoveFromString(inputStr, charsToRemove);
            string result4 = RemoveFromString(inputStr, indexToRemove);

            Console.WriteLine("Enter string: {0}", inputStr);
            Console.WriteLine("Result string 1: {0}", result3);
            Console.WriteLine("Result string 2: {0}", result4);

            #endregion

            Console.ReadKey();

        }
    }
}
