using System;

namespace Smart_House
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            //house.temperatureSensor.Value = 50; // for test
            //house.Temperature = 0; // for test
            //house.Temperature = 40; // for test
            //house.Temperature = 50; // for test
            house.Run();
            
        }
    }
}
