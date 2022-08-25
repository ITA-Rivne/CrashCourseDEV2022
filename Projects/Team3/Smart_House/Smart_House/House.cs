using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_House
{
    class House
    {
        private int _temperature;
        public void Run()
        {
            Console.WriteLine("_______Smart House_____OPENED\n\n");
            Console.WriteLine("House is running....");
            
            Random rnd = new Random();
            int interval = 1000;

            int temp;
            do
            {
                
                temp = rnd.Next(15, 30);
                _temperature = temp;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"House temperature NOW : {_temperature}");
                System.Threading.Thread.Sleep(interval);

            }
            while (!Console.KeyAvailable);

            Console.WriteLine("\n\n_______Smart House_____CLOSED");
        }
    }
}
