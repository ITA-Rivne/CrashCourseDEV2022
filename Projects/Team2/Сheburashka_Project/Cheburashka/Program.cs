using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheburashka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //встановлюємо кодування для виводу кирилиці в консоль
            Console.WriteLine("Як Чебурашка і друзі будували будинок \n");
            
            
           Lion r = new Lion("Лев");
            int a;
            a = r.GetWork("фундамент", 6);
            Console.WriteLine(a);
            r.Say();

            Console.ReadLine();
                     


        }
    }
}

