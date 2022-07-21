using System;

namespace Lesson4
{

    public class Plants : ICook<string>
    {

        public int Age
        { get; private set; }

        public int height;
        public bool isEdible;



        public string GetFood()
        {

            string message = "It is your salad";
            Console.WriteLine(message);         

            //return new Food();
            return message;
        }

        public int CalculateVolume(int a, int b, int c)
        {
            return a * b * c;
        }
    }   
}