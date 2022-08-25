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
        public TemperatureSensor temperatureSensor;
        public int Temperature
        {
            get => _temperature;
            set
            {
                _temperature = value;
                temperatureSensor.Value = value;
            }
        }
        public House()
        {
            temperatureSensor = new TemperatureSensor(this);
            temperatureSensor.ValueOutOfRange += (o, args) => Console.WriteLine("Out Of range");
        }
        public void Run()
        {
            Console.WriteLine("_______Smart House_____OPENED\n\n");
            Console.WriteLine("House is running....");
            
            Random rnd = new Random();
            int interval = 1000;

            int temp;
            do
            {
                
                temp = rnd.Next(10, 40);
                Temperature = temp;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"House temperature NOW : {_temperature}");
                System.Threading.Thread.Sleep(interval);

            }
            while (!Console.KeyAvailable);

            Console.WriteLine("\n\n_______Smart House_____CLOSED");
        }
    }
}
