using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fairytale
{
    public class Animal : IEatable
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

            Console.WriteLine($"Привіт! Я {this.name}");
            Console.WriteLine($"Моя хитрість = {this.cunning}; Моя швидкість = {this.speed} \n");
        }

        public Kolobok CookKolobok() => new Kolobok();

        public Kolobok Eat(ref Kolobok kolobok)
        {
            Console.WriteLine("Колобок, колобок, я тебе з'їм!");

                Console.WriteLine(kolobok.SingSong());

                if (this.cunning > kolobok.cunning && this.speed > kolobok.speed)
                {
                var message = this.cunning > kolobok.cunning ? "Ти був не надто хитрий!" : "Ти був дуже повільний!";
                    Console.WriteLine("Смачний був колобок!");
                    kolobok = null;
                    throw new Exception("Колобка з'їли :((");
                }
                else
                {
                    kolobok.RunAway(this.name);
                }

            return kolobok;
        }
    }
}
