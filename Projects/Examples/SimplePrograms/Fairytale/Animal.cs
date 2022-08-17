using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fairytale
{
    class Animal
    {
        public string name;
        public int cunning;
        public int speed;
        public static Random random = new Random();

        public Animal(string name, int cunningIndex = 1)
        {
            this.name = name;

            //задаємо швидкість
            this.speed = random.Next(1, 10);

            //задаємо кмітливість
            this.cunning = random.Next(1, 10)* cunningIndex;

            Console.WriteLine($"Hello! I'm {this.name}");
            Console.WriteLine($"My cunning = {this.cunning}; My speed = {this.speed} \n");
        }

        public Kolobok CookKolobok() => new Kolobok();

        public void Eat(ref Kolobok kolobok)
        {
                //Console.WriteLine("Колобок, колобок, я тебе з'їм!");
                Console.WriteLine("Kolobok, Kolobok, I will eat you!");

                Console.WriteLine(kolobok.SingSong());

                if (this.cunning > kolobok.cunning && this.speed > kolobok.speed)
                {
                    //Console.WriteLine("Смачний був колобок!");
                    Console.WriteLine("It was tasty!");
                    kolobok = null;
                    throw new Exception("Kolobok is dead :((");
                }
                else
                {
                    kolobok.RunAway(this.name);
                }
        }

    }
}
