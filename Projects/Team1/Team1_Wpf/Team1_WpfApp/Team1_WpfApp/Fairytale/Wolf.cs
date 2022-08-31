using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_WpfApp.Fairytale
{
    internal class Wolf : IAnimal
    {
        public string name { get; set; }

        public string GetMesssage()
        {
            return $"Моя сила = {this.strenght}, швидкість = {this.speed} \n";
        }

        // -------------------


        public int strenght;
        public int speed;
      

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
                return $"Я знищив {house.name} \n";
            }
            else
            {
                return $"Будинок має міцність {house.buildingSolidity()} мені не хватає сили {strenght} \n";                
            }
        
        }

        public void move(int distance)
        {
            throw new NotImplementedException();
        }        
    }
}
