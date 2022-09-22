using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Cheburaska_Pattern;


namespace Wpf_Cheburashka_2
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]

    class GetWorkTest
    {
        [Test]
        public void TestGetWork()
        {
            //arrange
            int x = 3;
            int y = 3;
            int expected = 3;

            //act
            ConcreteMediator mediator = new ConcreteMediator();
            Girl c = new Girl(mediator, y);

            int actual = c.GetWork("Galya", x);

            //assert
            Assert.AreEqual(expected, actual);

        }

    }
}
