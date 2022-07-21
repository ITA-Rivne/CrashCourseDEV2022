using System;

namespace Lesson3
{

    public class Plants : ICookable<string>
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

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }   
}