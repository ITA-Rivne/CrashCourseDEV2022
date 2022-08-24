using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_task211
{
    class Piggi : IAnimal,IPiggi
    {
        String name;
        int smart; // рівень розуму поросятка (від 1 до 10)
        int power; // рівень сили поросятка (від 1 до 10)
        int speed; // рівень швидкості поросятка (від 1 до 10)
        int distrLevel; //рівень стійкості будинку до руйнування
        bool died = false;
        bool vtik = false;
        int BaseDistance;

        public Piggi(String name)
        {
            this.name = name;
            this.smart = new Random().Next(1, 10);
            this.power = new Random().Next(1, 10);
            this.speed = new Random().Next(1, 10);
            Console.WriteLine("Я " + name);
            Console.ReadKey();

        }

        public void buildHouse()
        {
            distrLevel = (smart + power) / 2;
            Console.WriteLine("Я побудував будинок з оцінкою стійкості" + distrLevel);
        }


        public void funny()
        {
            smart++;
            power++;
            speed++;
        }

        public void move(int distance)
        {
            distance += speed;
            Console.WriteLine("Я пройшов ще " + speed + " метрів.");

        }
    }
}
