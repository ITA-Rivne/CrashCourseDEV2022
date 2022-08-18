using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson3
{
    class ProgramGeneric
    {
        #region Functions
        
        public static void methodExceptionExample()
        {
            try
            {
                Console.WriteLine("Method that contains try catch");

                //виклик методу в середниі якого існують свої try catch конструкції
                throw new Exception("methodExceptionExample new Exception....");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }




        #endregion Functions

        public static async Task Main(string[] args)
        {
            //--------------- Приклади реалізації інтерфейсів---------------------------
            
            //Колекція створена через реалізацію IEnumerable + IEnumerator
            var myCollection = new MyCollection();
            foreach (var i in myCollection)
            {
                Console.WriteLine(i);
            }

            //Колекція створена через yield
            var сollectionYield = new MyYieldCollection();
            foreach (var i in сollectionYield)
            {
                Console.WriteLine(i);
            }

            //----------------- Приведення і підстановка класів --------------
            Animal animal1 = new Animal();
            Animal someAnimal = new Animal();
            Cat cat1 = new Cat(2, 4, 5);
            Cat cat2 = new Cat();

            var animalsCollection = new List<Animal>();
            //об'єкти з класів наслідників можуть поводитись як об'єкти батьківських класів
            //не можна порушувати принцип SOLID L= Lliskov substitution principle - принцип підстановки
            animalsCollection.Add(cat1);
            animalsCollection.Add(cat2);
            animalsCollection.Add(animal1);
            animalsCollection.Add(new Cat(2, 6, 3));

            var catsCollection = new List<Cat>();

            //ВИБІРКА з Animals лище котів - є коротша форма через LINQ -дивіться нижче
            foreach (var animal in animalsCollection)
            {
                try
                {
                    //приведення типів в даному випадку буде викидати помилки
                    //оскільки не кожен об'єкт Animal можна привести до класу нащадка
                    catsCollection.Add((Cat)animal);
                    Console.WriteLine($"The cat from List says = {cat1.voise}");

                    //виклик методу всередниі якого існують свої try catch конструкції
                    //компілятор зайде всередину methodExceptionExample() і спробує опрацювати код та 
                    //можливі помилки, якщо знайде помилки, то поверне їх у поточний try блок
                    methodExceptionExample();

                    // Створюємо власне виключення
                    if (animal.age < 5) throw new Exception("Age is < 5 ...");
                }

                // ієрархія класів помилок, відловлюються специфічні і потім загальні
                catch (SystemException ex)
                {
                    Console.WriteLine("Here is the SystemException!");
                    Console.WriteLine(ex.Message);
                }

                catch (Exception ex) // Exception - загальний\базовий клас для всіх виключень
                {
                    Console.WriteLine("Here is the Exception!");
                    Console.WriteLine(ex.StackTrace);
                }
                // блок finally виконається в обох випадках і при викиданні помилки,
                // і якщо в блоці try помилок не було
                finally
                {
                    Console.WriteLine("Here is a finally block");
                    Console.ReadLine();
                }
            }

            #region Generics
            //----------------------------- Generics узагальнені типи ------------

            MyGenerics<int>.GenericExample(22);

            MyGenerics<string>.GenericExample("string");

            MyGenerics<object>.GenericExample(new object());




            //Ініціалізаціє об'єкту з узагальненим типом
            var someRestaurant = new Restaurant<Food>();

            //об'єкт класу Restauranr приймає як параметр об'єкт будь-якого класу який реалізував інтерфейс ICook 

            Fish myFish = new Fish();

            myFish.Move(1);

            //в разі потеби ми можемо представити новий об'єкт у вигляді інтерфейсу
            ICookable<Food> myFish2 = new Fish();
            //але в такому випадку ми зможемо працювати ЛИШЕ з методами описаними в інтерфейсі
            //решта методів об'єкта приховується.
            //myFish2.Move(1);  // - цей код не спрацює вже для myFish2



            someRestaurant.MadeFood(myFish);
            //someRestaurant.MadeFood((ICookable<string>)myFish);
            


            //Створюємо новий ресторан, АЛЕ.....
            var veganRestaurant = new Restaurant<string>();
            veganRestaurant.MadeFood(new Plants());
            // ....вже не вийде зробити їжу з риби у веганському ресторані оскільки ми 
            // його типізували викликавши як new Restaurant<string>
        //    veganRestaurant.MadeFood(new Fish());   // - цей код з new Fish() вже не спрацює

            #endregion Generics

        }
    }

    //Generic class
    static class MyGenerics<TKey>
    {
        public static string GenericExample(TKey anyTypeObject)
        {
            Console.WriteLine("Some common logic for all types");
            return anyTypeObject.ToString();
        }
    }

    //приклад класу, що реалізує IEnumerable через ключове слово yield
    class MyYieldCollection : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return "yield Hello world!";
            yield return "yield Hello world!1";
            yield return "yield Hello world!2";
            yield return "yield Hello world!3";
        }
    }
}