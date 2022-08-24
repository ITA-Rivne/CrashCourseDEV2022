using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_task211
{
    class Building
    {
        String buildingName;
        int buildingSolidity; // the level of building's solidity (its strength), from 1 to 10  
        bool buildingStatus = true; // whether it is intact or destroyed

        public Building(String buildingName)
        {
            this.buildingName = buildingName;
            this.buildingSolidity = new Random().Next(1, 10);

            Console.WriteLine($"Ми називаємо цей будиночок {buildingName}");
            Console.ReadKey();

        }

        public Basement BasementDepth
        {
            get { return BasementDepth; }
            set { BasementDepth = value; }
        }

        public Walls WallsColor
        {
            get { return WallsColor; }
            set { WallsColor = value; }
        }

        public Walls RoofColor
        {
            get { return RoofColor; }
            set { RoofColor = value; }
        }
    }

    // class Basement (фундамент будинку)
    class Basement
    {
        float basementDepth; // the depth of the basement in meters

        public Basement()
        {
            basementDepth = 3;
        }
        public Basement(float basementDepth)
        {
            this.basementDepth = basementDepth;
        }

        public float BasementDepth
        {
            get { return basementDepth; }
            set { basementDepth = value; }
        }

        public void ShowData()
        {
            Console.WriteLine($"Глибина підвалу складає {basementDepth} метрів.");
        }
    }

    // class Walls (стіни будинку)
    class Walls
    {
        string color; // the color of the walls

        public Walls()
        {
            color = "рожевий";
        }
        public Walls(string color)
        {
            this.color = color;
        }

        public string WallsColor
        {
            get { return color; }
            set { color = value; }
        }

        public void ShowData()
        {
            Console.WriteLine($"Стіни будинку пофарбовані у {color} колір.");
        }
    }

    // class Roof (криша будинку)
    class Roof
    {
        string color; // the color of the roof

        public Roof()
        {
            color = "коричневий";
        }
        public Roof(string color)
        {
            this.color = color;
        }

        public string RoofColor
        {
            get { return color; }
            set { color = value; }
        }

        public void ShowData()
        {
            Console.WriteLine($"Криша будинку пофарбована у {color} колір.");
        }
    }
}
