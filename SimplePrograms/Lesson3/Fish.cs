using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    class Fish :  Animal, ICookable<Food>
    {
        bool IsOceanic { get; set; }

        bool isEdible = true;

        public Food GetFood() {

            Console.WriteLine("It is your sushi");
            return this.isEdible ? new Food() : throw new Exception("This food isn't edible"); //приклад використання тренарного оператора
        }
    }
}
