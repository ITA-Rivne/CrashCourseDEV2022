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
            Console.WriteLine("209");
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
            
            //Написати overload методи RemoveFromString, які приймають текст і видаляють з нього або певний набір символів,
            //або символ\символи за порядковим номером в тексті. Реалізувати використання аргументів за замовчуванням
            Console.WriteLine("210");
            string s1, s2;
            int pos = 3;
            Console.WriteLine("задайте дві стрічки");
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();
            Console.WriteLine("вихідна стрічка ->" + s1);
            Console.WriteLine($"видаляє {s2} з cтрічки {s1}");
            Console.WriteLine(Arithmetic.RemoveFromString(s1, s2));
            Console.WriteLine($"видаляє 1 символ з позиції {pos}");
            Console.WriteLine(Arithmetic.RemoveFromString(s1, pos));
            Console.WriteLine("видаляє 1 символ з 4 позиції");
            Console.WriteLine(Arithmetic.RemoveFromString(s1));
            Console.ReadLine();
        }
    }
}
