using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Models
{
   public class House
    {
        private int _temperature;
        private int _lux=50;
        private bool _isMoving=false;
        public string InfoLightMoving { get; set; } = "";
        public TemperatureSensor TemperatureSensor { get; set; }
        public AirConditioner AirConditioner = new AirConditioner();
        public MotionSensor MotionSensor;
        public Lamp Lamp = new Lamp(100);



        public int Temperature
        {
            get => _temperature;
            set
            {
                _temperature = value;
                TemperatureSensor.Value = value;
            }
        }

        public int Lux {
            get => _lux;
            set {
                _lux = value;
                MotionSensor.Value = value;

            }
        }

        public bool IsMoving {
            get => _isMoving;
            set {
                _isMoving = value;
                MotionSensor.IsMoving=value;
            }
        }

                
        public House(int startTemp = 20, int startLUX=50)
        {
            //temperature
            _temperature = startTemp;
            TemperatureSensor = new TemperatureSensor(this); // прив`язали сенсор до цього будинку 
            TemperatureSensor.ValueOutOfRange += AirConditioner.Handler;
            AirConditioner.Power();

            //movement
            MotionSensor = new MotionSensor(this);
            _lux = startLUX;
            MotionSensor.ValueOutOfRange += Lamp.Handler;
            if (Lamp.IsOn()) Lamp.Power();
            MonitoringIndicators(IsMoving,Lux);
        }
        //public void Run()
        //{
        //    Console.WriteLine("_______Smart House_____OPENED\n\n");
        //    Console.WriteLine("House is running....");

        //    Random rnd = new Random();
        //    int interval = 1000;

        //    int temp;
        //    int lux;
        //    bool moving=false;
        //    ConsoleKeyInfo key;
        //    do
        //    {

        //        lux = rnd.Next(0, 45);
        //        moving = Convert.ToBoolean(rnd.Next(0, 2));
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        Console.WriteLine($"House LUX: {lux}. Is moving: {moving}");
        //        IsMoving = moving;
        //        Lux = lux;


        //        Console.WriteLine("Enter temperature : ");
        //        temp = int.Parse(Console.ReadLine());
        //        Temperature = temp;
        //        //int randFactor =  rnd.Next(-10, 11);
        //        //Temperature += randFactor;
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine($"House temperature NOW : {Temperature}");
        //        // System.Threading.Thread.Sleep(interval);
        //        Console.ForegroundColor = ConsoleColor.Gray;
        //        Console.WriteLine("\t\tPress any  key");
        //        key = Console.ReadKey();
        //        if (Lamp.IsOn()) Lamp.Power();

        //    }
        //    while (key.Key!= ConsoleKey.Escape);// !Console.KeyAvailable);

        //    Console.WriteLine("\n\n_______Smart House_____CLOSED");
        //}

        public void MonitoringIndicators(bool moving, int lux) // will call by  command
        {
           
            //testing lamp and motionsensor!
            if (Lamp.IsOn())
                Lamp.Power();
          
             IsMoving = moving;
             Lux = lux;
            if (moving && Lux < 50)
            {
                InfoLightMoving = $"Somebody come in house.\n\rWelcome HOME! :) \n\rLamp ON, because a little dark! \n\rLux: {Lux}.\n\r";
            }
            else if (moving && Lux > 50)
            {
                InfoLightMoving = $"Somebody come in house.\n\rWelcome HOME! :) \n\rLamp OFF, because lighting is enough! \n\rLux: {Lux}.\n\r";
            }
            else if (!moving && Lux > 50)
            {
                InfoLightMoving = $"There is no one at home... \n\rLamp OFF, because lighting is enough! \n\rLux: {Lux}.\n\r";
            }
            else
            {
                InfoLightMoving = $"There is no one at home... \n\rLamp OFF.\n\r";
            }



        }
    }
}
