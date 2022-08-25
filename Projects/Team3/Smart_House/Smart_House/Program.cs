using System;

namespace Smart_House
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            //house.temperatureSensor.Value = 50; // fot test
            house.Run();
            
        }
    }
}
