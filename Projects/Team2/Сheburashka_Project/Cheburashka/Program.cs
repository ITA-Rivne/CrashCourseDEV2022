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
            
            
           Lion r = new Lion();
            r.GetWork("фундамент", 4);
            Console.ReadLine();

           


        }
    }
}

