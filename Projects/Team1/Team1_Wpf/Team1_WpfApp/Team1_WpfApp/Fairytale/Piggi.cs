using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_WpfApp.Fairytale
{
    class Piggi : IAnimal,IPiggi
    {
        public string name;
        int smart; // рівень розуму поросятка (від 1 до 10)
        int power; // рівень сили поросятка (від 1 до 10)
        int speed; // рівень швидкості поросятка (від 1 до 10)
        int distrLevel; //рівень стійкості будинку до руйнування

        public Building myHouse;

        bool died = false;
        bool vtik = false;
        int BaseDistance;

        public Piggi(String name, int smartIndex = 1)
        {
            this.name = name;
            Random r = new Random(smartIndex);
            this.smart = r.Next(1, 10)* smartIndex;
            this.power = r.Next(1, 10);
            this.speed = r.Next(1, 10);
            
            Console.WriteLine("Я " + name);
            Console.WriteLine($"Моя хитрість = {this.smart}, швидкість = {this.speed}  сила = {this.power} \n");
            

        }

        public void buildHouse()
        {
            var _base = new Material("Камінь");
            _base.Strength = power * 10;

            var wall = new Material("Дерево");
            wall.Strength = (power + smart) / 2 * 10;

            var roof = new Material("Солома");
            roof.Strength = speed * 10;

            myHouse = new Building($"Дім {name}a", _base, wall, roof);
        }

        public bool catched(int rivalspeed)
        {
            if (rivalspeed > speed)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return $"Я {this.name}  \n" +
                   $"Моя хитрість = {this.smart}, швидкість = {this.speed}  сила = {this.power} \n";            
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
