using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_WpfApp.Fairytale
{
    class Wolf
    {
        public int strenght;
        public int speed;
        public string name;

        public Wolf(String name, int strenghtIndex = 1)
        {
            this.name = name;
            Random r = new Random(strenghtIndex);
            this.strenght = r.Next(1, 10) * strenghtIndex;
            this.speed = r.Next(1, 10);

            //Console.WriteLine("Я " + name);
            //Console.WriteLine($"Моя сила = {this.strenght}, швидкість = {this.speed} \n");

        }

        public string destructionBuilding(Building house)
        {
            if (strenght > house.buildingSolidity())
            {
                house.buildingStatus = false;
                return $"Я знищив {house.buildingName} \n";
            }
            else
            {
                return $"Будинок має міцність {house.buildingSolidity()} мені не хватає сили {strenght} \n";                
            }
        
        }

        public override string ToString()
        {
            return $"Я {this.name}  \n" +
                   $"Моя сила = {this.strenght}, швидкість = {this.speed} \n";
        }
    }
}
