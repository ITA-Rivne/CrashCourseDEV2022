using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team1_WpfApp.Fairytale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_WpfApp.Fairytale.Tests
{
    [TestClass()]
    public class BuildingTests
    {
        [TestMethod()]
        public void BuildingSolidityTestRez4()
        {

            //Given
            Console.WriteLine("TestDestructionBuilding() execution");
            var wolf = new Wolf("testWolf");
            wolf.strenght = 5;
            Material mat_base = new Material("Base");
            mat_base.Strength = 1;
            Material mat_wall = new Material("Wall");
            mat_wall.Strength = 2;
            Material mat_roof = new Material("Roof");
            mat_roof.Strength = 1;

            Building testBuilding = new Building("Test House", mat_base, mat_wall, mat_roof);


            int ExpectedValue = 4;

            //When
            //  wolf.destructionBuilding(house);

            var ActualValue = testBuilding.buildingSolidity();

            //Then
            Assert.AreEqual(ActualValue, ExpectedValue);
        }
    }
}