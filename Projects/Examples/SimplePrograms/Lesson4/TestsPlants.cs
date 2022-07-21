using System;
using System.Collections;
using NUnit.Framework;

namespace Lesson4
{
    [TestFixture]//визначення тест-класу
    [Parallelizable(ParallelScope.All)]
    public class TestPlants
    {
        [OneTimeSetUp] //код, що виконується один раз перед усіма тестами
        public void BeforeAllTests()
        {
            Console.WriteLine("setup all tests");
        }

        [SetUp] //код, що виконається для конфігурації кожного тесту
        public void BeforeOneTest()
        {
            Console.WriteLine("setup each test");
        }

        [OneTimeTearDown]//код виконається один раз після усіх тестів у класі
        public void AfterAllTests()
        {
            Console.WriteLine("cleanUp()");
        }

        [Test] //атрибут тесту - Nunit буде сприймати даний метод як тест
        [Category("Smoke")]//позначаємо, що тест буде виконуватись з Smoke тестами
        [Category("Regression")]//також даний тест буде виконуватись у Reression категорії
        [Repeat(3)]//повторити тест 3 рази і якщо вони успішні, то тест пройдено
        [Order(1)] // порядок виконання тестів
        public void TestCalculateVolume()
        {
            //Assert.Pass();

            //Given
            Console.WriteLine("TestCalculateVolume() execution");
            var plant = new Plants();
            int ExpectedValue = 12;

            //When
            var ActualValue = plant.CalculateVolume(2, 3, 2);

            //Then
            Assert.IsTrue(ActualValue == ExpectedValue);
            Assert.AreEqual(ActualValue, ExpectedValue);
        }

        [Test]
        [Retry(4)]//спобувати запустити тест до 4 разів, якщо хоча б один успішний, то тест пройдено
        //можна ігнорувати тести
        [Ignore("Ignore this test until... something is fixed; URL to BugReport")]
        public void TestCalculateVolume2()
        {
            //Given
            var plant = new Plants();
            int ExpectedValue = 5;

            //When
            var ActualValue = plant.CalculateVolume(2, 3, 3);

            //Then
            Assert.AreEqual(ExpectedValue, ActualValue, "Error message: TestCalculateVolume broken");
            Assert.AreEqual(ActualValue, ExpectedValue); // помилка!! ActualValue, ExpectedValue змінено місцями
        }


        //------------------- Робота з тест даними ---------------

        //подаємо дані через параметри тестового методу
        [Test]
        [Order(2)]
        public void TestValues(
                        [Values("Value1", "Value2")] string strValue,
                        [Random(1, 7, 2)] int intValue)
        {
            Console.WriteLine($"TestValues: {strValue} and {intValue}");
        }


        //подаємо дані через атрибути Nunit
        [TestCase(5, ExpectedResult = true)]
        [TestCase(-2, ExpectedResult = false)]
        public bool Test_TestCases(int x)
        {
            Console.WriteLine($"TestCase: {x} > 0 ");
            return x > 0;
        }

        //подаємо дані через DataProvider
        private static readonly object[] DataProviderExample =
        {
            new object[] {65 , 'A'},
            new object[] {97 , 'a'},
            new object[] {98 , 'b'}
        };

        [TestCaseSource(nameof(DataProviderExample))]
        public void TestCaseSource_DataProvider(int x, char y)
        {
            char expected = y;
            char actual = (char)x;
            Assert.AreEqual(x, y);
        }

        //використовуємо дані з класу тест даних, в даному випадку буде
        [TestCaseSource(typeof(MyDataClass), nameof(MyDataClass.TestCases))]
        public int TestCaseSource_DivideTest(int n, int d)
        {
            return n / d;
        }
    }


    //ключове слово yield для компілятора розгортається у колекцію з ітератором, яку
    //можна обробити в foreach циклі
    //нам не потрібно виписувати усю логіку інтерфейсу IEnumerable

    public class MyDataClass
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(12, 3).Returns(4);
                yield return new TestCaseData(12, 2).Returns(6);
                yield return new TestCaseData(12, 4).Returns(3);
            }
        }
    }
}