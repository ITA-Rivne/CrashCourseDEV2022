using System;
using NUnit.Framework;

namespace Lesson4
{
    [TestFixture]//визначення тест-класу
    [Parallelizable(ParallelScope.All)]
    class TestDB
    {
        [Test]
        [Category("Smoke")]
        [TestCase(25, ExpectedResult = "3")]
        [TestCase(17, ExpectedResult = "4")]
        public string TestDatabase(int intValue)
        {
            Console.WriteLine($"TestDaatabase GetSortOrderByOCCategory: {intValue}");
            return Database.GetSortOrderByOCCategory(intValue);
        }
    }
}
