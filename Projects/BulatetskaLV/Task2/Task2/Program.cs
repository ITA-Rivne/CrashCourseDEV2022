using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region // Cереднє арифметичне двох чисел.

            float a=20, b=5;
            float result = (a + b) / 2;
            Console.WriteLine(result);
            Console.WriteLine("---------------------------------");


            #endregion

            #region // To be or not to be

            string stringExample1 = "To be or not to be \n"+ @"\Shakespeare\";
            Console.WriteLine(stringExample1);
            Console.WriteLine("---------------------------------");


            #endregion

            #region // Напишіть програму, яка перевіряє число, введене з клавіатури на парність
            
            int c;
            c = Convert.ToInt32(Console.ReadLine());
            
            if (c%2 == 0)
            {
                Console.WriteLine("Число парне");
            }
            else
            {
                Console.WriteLine("Число не парне");
            }
            Console.WriteLine("---------------------------------");
            #endregion

            #region // Напишіть програму, що виводить на екран кількість цифр числі x  (x <100) і суму цих цифр
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            int sumX;
            if (x < 10)
            {
                Console.WriteLine("кількість цифр 1" + "сума цифр " + x);
            }
            else 
            {
                sumX = x / 10 + x % 10;
                Console.WriteLine("кількість цифр 2" + "сума цифр " + sumX);
            }
            Console.WriteLine("---------------------------------");
            #endregion

            #region // Напишіть програму, що виводить на екран кількість цифр в числі і суму цих цифр

            int d;
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(d);
            int sum = 0;
            int countD = 0;
            
            while (d >= 1)
            {
                sum +=d % 10; 
                d =d/10;
                countD++;
             }
            Console.WriteLine("Кількість цифр "+countD);
            Console.WriteLine("Сума цифр "+sum);
            Console.WriteLine("---------------------------------");
            #endregion

            #region //  Користувач вводить з клавіатури число, необхідно перевернути його(число) і вивести на екран.
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            int res = 0;
           
            while (num >= 1)
            {
                res = res*10+ num % 10;
                num = num / 10;
                           }
            Console.WriteLine("перевернуте число " + res);
            Console.WriteLine("---------------------------------");
            #endregion

            #region //Написати програму, яка знаходить в масиві значення, що повторюються два і більше разів, і показує їх на екран.

            int[] intArray;
            intArray = new int[10] { 10, 3, 5, 8, 4, 4, 10, 8, 2, 4 };
            for (int i = 0; i <= intArray.Length-2; i++)
            {
                for (int j = i+1; j <= intArray.Length-1; j++)
                {
                    if (intArray[i] == intArray[j] && i!=j)
                    {
                        Console.WriteLine(intArray[i]);
                        break;
                    }
                   
                }
            };
            Console.WriteLine("---------------------------------");
            #endregion

            #region //Написати програму, яка знаходить в масиві найменше непарне число і показує його на екран.
            // шукаємо хоч одне непарне число
            int min=2;
           
            for (int i = 1; i <= intArray.Length - 1; i++)
            {
                if (intArray[i] % 2 == 1)
                {
                    min = intArray[i];
                    break;
                }

            }

            if (min != 2) // якщо хоч одне непарне знайдено, то шукаємо мінімальне непарне інакше непарних немає
            { 
                for (int i = 1; i <= intArray.Length - 1; i++)
                {
                    if (min > intArray[i] && intArray[i] % 2 == 1)
                    {
                        min = intArray[i];

                    }
                } 
                 Console.WriteLine(min);
            }
            else
                Console.WriteLine("в масиві немає непарних чисел"); 
            
        

           
            #endregion
            Console.ReadLine();
        }
    }
}
