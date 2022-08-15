using System;
using System.Collections.Generic;


namespace Lesson1
{
    class Syntax
    {
        public static void Main(string[] args)
        {

            #region//Примітивні типи даних
            float floatExample = 1.3f;

            var caracterVariable = 'C';

            bool isTrue = false;


            int a = 1;
            int b = 2;

            a = b;
            Console.WriteLine("Primitive type example: a = " + a);

            //Бажано використовувати var (неявний тип) - компілятор сам визначить і встановить необхідний тип даних для змінної
            var variableExample = "45567";

            #endregion

            #region//Масиви
            int[] intArray, intArray2;

            DateTime[] intArray3;

            intArray = new int[3] { 1, 2, 3 };

            string[] strArray = new string[3] { "one", "two", "three" };

            int[,] Array2D = new int[4, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            int[,,] Array3D = new int[4, 3, 3] { { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } },
                                                 { { 4, 5, 6 }, { 4, 5, 6 }, { 4, 5, 6 } },
                                                 { { 0, 1, 2 }, { 0, 1, 2 }, { 1, 1, 2 } },
                                                 { { 7, 8, 9 }, { 7, 8, 9 }, { 7, 8, 9 } } };
            #endregion

            #region//Оператори
            var result = a + b;
            a++;
            a += 23;
            a -= 34;

            result = a % b;

            isTrue = a <= b;
            isTrue = a == b;

            //тринарний логічний оператор
            var logicalResult =
                isTrue ? Syntax.TryTrenary() : false;

            Console.WriteLine(logicalResult);
            //Console.Beep();
            #endregion

            #region//Оператори вітвлень 

            isTrue = true;
            if (isTrue)
            {
                Console.WriteLine(isTrue);
            }
            else if (1 != 1)
            {
                Console.WriteLine(isTrue);
            }
            else
            {
                Console.WriteLine(isTrue);
            }



            var fromConsole = Console.ReadLine();

            switch (fromConsole)
            {
                case "1":
                    Console.WriteLine("variable = 1");
                    break;
                case "2":
                    Console.WriteLine("variable = 2");
                    break;
                case "3":
                    Console.WriteLine("variable = 3");
                    break;
                case "4":
                    Console.WriteLine("variable = 4");
                    break;
                default:
                    Console.WriteLine("variable by default");
                    break;
                    // goto case "1"; return або throw;
            }

            #endregion

            #region//Цикли
            //for
            for (int x = 0; x <= 3; x++)
            {
                for (int y = 0; y <= 2; y++)
                {
                    Console.WriteLine($"Array value {Array2D[x, y]}");
                }
            };


            //foreach
            intArray2 = intArray;
            intArray[0] = 8;

            foreach (var iterator in intArray2) //проходимось циклом по кожному значенню з масиву
            {
                Console.WriteLine($"List value {iterator}");  //приклад інтерполяції строки
               
                Console.WriteLine("List value" + iterator);  //приклад 
            }


            for (int x = 0; x <= 2; x++) //проходимось циклом for по кожному значенню з масиву
            {
                Console.WriteLine($"Array value {intArray[x]}");
            }

            List<int> numList = new List<int>(); //створюємо СПИСОК цілих чисел

            numList.Add(2); //додаємо в список елементи
            numList.Add(21);
            numList.Add(22);
            numList.Add(23);

            numList.RemoveAt(2);

            foreach (var iterator in numList) //цикли foreach працює і зі списками
            {
                Console.WriteLine($"List value {iterator}");
            }


            //цикли while і do while
            var i = 10;
            while (i >= 1)
            {                
                Console.WriteLine($"While Iteration # {i}");
                i--;
            };

            Console.WriteLine($"i = {i}");

            do
            {                
                Console.WriteLine($"Do while Iteration # {i}");
                i--;
            } while (i >= 1);
            #endregion

            #region//НЕПРИМІТИВНІ типи даних (типи даних за посиланням)

            //string - строкові дані
            string stringExample = "Simple string";
            string stringExample2 = stringExample;

            stringExample = "Changed" + "string";  //коли ми змінюємо string, то програма не міняє значення в пам'яті,
                                               //а створює новий об'єкт, який вже і містить змінений текст
                                               //Тому, хоча string є типом даних "за посиланням", у нашому випадку stringExample != stringExample2
                                               //оскільки stringExample вже посилається на іншу область пам'яті, яка містить новий текст
            Console.WriteLine(stringExample2);
            Console.Write(stringExample);

            //Tuples - кортежі
            (string, int, double) person = ("Tom", 25, 81.23);
            (string, int, double) person1 = person;

            person.Item1 = "changed";

            Console.WriteLine(person1.Item1);


            //Enums - приклад роботи з перечисленнями
            Console.WriteLine(Days.Monday);
            Console.WriteLine((int)Days.Wednesday);

            System.
            // клас System.DateTime передбачачє методи для роботи з датою та часом
            DateTime currentDay = DateTime.Today;

            #endregion
        }

        #region Methods
        //оголошення СТАТИЧНОГО методу tryTrenary()
        //статичні методи належать класу а не об'єкту, для роботи зі статичними методами не потрібно створювати об'єкт
        public static bool TryTrenary()
        {
            Console.WriteLine("Test breakpoins");
            return true;
        }

        //НЕ СТАТИЧНИЙ метод, який не повертає даних 
        //метод не може бути викликаний без ініціалізації об'єкту
        public void TryVoid(int someParameter = 0) //*Студія підсвічує невірний 
        {
            Console.WriteLine("tryVoid method");
        }

        #endregion Methods


        //Enums - приклад перечислень
        enum Days
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 4,
            Thursday = 4,
            Friday,
            Saturday,
            Sunday
        }
    }
}
