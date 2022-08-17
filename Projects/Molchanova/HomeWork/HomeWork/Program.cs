using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            //201
            Console.WriteLine("Enter first number");
            int a = Int32.Parse( Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Result="+ seredne(a,b));
            //203
            Console.WriteLine("Перевірка на парність. Введіть число для перевірки");
            int c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Парність:" + parne(c));
            //204
            Console.WriteLine("204 Введіть число: ");
            int d = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" Кількість цифр:" + countNum(d));
            Console.WriteLine(" Сума цифр:" + sumNum(d));

            Console.WriteLine("205 Введіть число: ");
            int r = Int32.Parse(Console.ReadLine());
            ReversNum(r);
            Console.WriteLine();
            Console.WriteLine("206 Введіть число: ");
            int r1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" Сума цифр:" + sumNum(r1));
            //207
            Console.WriteLine("207 Однакові елементи: ");
            int []arr = new int [8]{ 2, 3, 4, 5, 4,5,6,6 };
            PrintArr(arr);
            Console.WriteLine();
            NonSingleElement(arr);
            //208
            Console.WriteLine("207 Мінімальне непарне масива: ");
            int[] arr1 = new int[9] { 2, 3, 4, 5, 4, 5, 6, 6,9 };
            PrintArr(arr1);
            Console.WriteLine();
            MinElem(arr1);

        }
        //201
       static double seredne(int a, int b) {
            return (a + b) / 2.0;
        }
        //203
        static bool parne(int a)
        {
            if (a % 2 == 0) return true;
            else
                return false;
        }
        //204
        static int countNum(int a)
        {
            int count=0;
            while (a > 0)
            {
                count++;
                a = a / 10;
            }

            return count;
        }
        //204, 206
        static int sumNum(int a)
        {
            int sum = 0;
            while (a > 0)
            {
                sum += a % 10;
                 a = a / 10;
            }

            return sum;
        }
        //205
        static void ReversNum(int a)
        {
            int sum = 0;
            while (a > 0)
            {
                sum = a % 10;
                a = a / 10;
                Console.Write(sum+" ");
            }

           
        }

        //207
        static void NonSingleElement(int []a)
        {
           for(int i=0; i<a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        Console.WriteLine(a[i]+" ");
                    }
                }
            }

        }


        //208
        static void MinElem(int[] a)
        {
            int min =99999999;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min && a[i] % 2 != 0)
                    min = a[i];
                    
            }

            if (min%2!=0)
                Console.WriteLine(min);
            else
                Console.WriteLine("Масив не містить непарних чисел");
        }

        static void PrintArr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {

                Console.Write(a[i]+" ");
            }
        }


        }

}
