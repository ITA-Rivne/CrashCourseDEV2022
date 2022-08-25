﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_task211
{
    class Building
    {
        String buildingName;
        //float buildingSolidity;  
        bool buildingStatus = true; // whether it is intact or destroyed

        public Building(String buildingName)
        {
            this.buildingName = buildingName;
            // this.buildingSolidity = new Random().Next(1, 10);

            Console.WriteLine($"Я називаю свій будиночок '{buildingName}'!");
            Console.ReadKey();

        }

        public Basement BasementSolidity
        {
            get { return BasementSolidity; }
            set { BasementSolidity = value; }
        }

        public Walls WallsSolidity
        {
            get { return WallsSolidity; }
            set { WallsSolidity = value; }
        }

        public Walls RoofSolidity
        {
            get { return RoofSolidity; }
            set { RoofSolidity = value; }
        }
    }

    // class Basement (фундамент будинку)
    class Basement
    {
        float basementSolidity;

        public Basement()
        {
            this.basementSolidity = new Random().Next(1, 10);
        }
        public Basement(float basementSolidity)
        {
            this.basementSolidity = basementSolidity;
        }

        public float BasementSolidity
        {
            get { return basementSolidity; }
            set { basementSolidity = value; }
        }

        public void ShowData()
        {
            Console.WriteLine($"Міцність стін складає {basementSolidity} одиниць.");
        }
    }

    // class Walls (стіни будинку)
    class Walls
    {
        float wallsSolidity;

        public Walls()
        {
            this.wallsSolidity = new Random().Next(1, 10);
        }
        public Walls(float wallsSolidity)
        {
            this.wallsSolidity = wallsSolidity;
        }

        public float WallsSolidity
        {
            get { return wallsSolidity; }
            set { wallsSolidity = value; }
        }

        public void ShowData()
        {
            Console.WriteLine($"Міцність стін складає {wallsSolidity} одиниць.");
        }
    }

    // class Roof (криша будинку)
    class Roof
    {
        float roofSolidity;

        public Roof()
        {
            this.roofSolidity = new Random().Next(1, 10);
        }
        public Roof(float roofSolidity)
        {
            this.roofSolidity = roofSolidity;
        }

        public float RoofSolidity
        {
            get { return roofSolidity; }
            set { roofSolidity = value; }
        }

        public void ShowData()
        {
            Console.WriteLine($"Міцність криші складає {roofSolidity} одиниць.");
        }
    }
}
