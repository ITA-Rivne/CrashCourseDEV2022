using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_209_210
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Написати overload методи Add які в залежності від параметрів або додають цифрові значення,
            //або об'єднують введені тексти. Передбачити аргументи за замовчуванням і використання статичних полів\методів

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("задайте дві стрічки");
            string a, b;
            a=Console.ReadLine();
            b = Console.ReadLine();
            Console.WriteLine(Arithmetic.Add(a, b));
            Console.WriteLine("задайте два числа");
            int c, d;
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Arithmetic.Add(c, d));
            Console.WriteLine("за замовчуванням 5");
            Console.WriteLine(Arithmetic.Add());
            Console.ReadLine();

            //Написати overload методи RemoveFromString, які приймають текст і видаляють з нього або певний набір символів,
            //або символ\символи за порядковим номером в тексті. Реалізувати використання аргументів за замовчуванням



        }
    }
}
