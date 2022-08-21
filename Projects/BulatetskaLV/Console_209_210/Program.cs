using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_209_210
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написати overload методи Add які в залежності від параметрів або додають цифрові значення,
            //або об'єднують введені тексти. Передбачити аргументи за замовчуванням і використання статичних полів\методів

              string Add(string s1, string s2)
            {
                return s1+s2;
            }
            string a = "Hello";
            string b = "World!!";
            Console.WriteLine(Add(a,b));
            Console.ReadLine();

        }
    }
}
