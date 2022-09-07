using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fairytale
{
    public class Fox : Animal, ISpeakable
    {
        //Оголошуємо делегат всередині класу
        delegate void PrintMessage(string msg);

        //Оголошуємо подію - це делегат типу PrintMessage
        event PrintMessage Notify;


        #region Oголошуємо методи, що за сигнатурою відповідають оголошеному делегату
        public void DisplayMessageInConsole(string msg)
        {
            Console.WriteLine($"Display Message to console: {msg}");
        }

        public void SendMessageViaInternet(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Send Message via Internet: {msg}");
        }
        #endregion


        public Fox(string name, int cunningIndex = 1) : base(name, cunningIndex)
        {
            Notify = SendMessageViaInternet;
            if (Notify != null) Notify("[Виникла подія в класі Лисиця]");
        }

        public string IntroduceYourself(ISpeakable person)
        {
            throw new NotImplementedException();
        }

        public string SayHello()
        {
            throw new NotImplementedException();
        }

        public string SpeakMessage(string message)
        {
            throw new NotImplementedException();
        }



        #region-------Анонімні методи

        delegate int Operation(int x, int y);

        Operation operation = delegate (int x, int y)
        {
            return x + y;
        };

        public void CallAnonim()
        {
            int result = operation(4, 5);
            Console.WriteLine(result);
        }
        #endregion

        #region Лямбда вирази - спрощений запис анонімних методів. Лямбда-вираз це також делегат
        //(список_параметрів) => вираз

        delegate void OperationPrint(int x, int y);

        OperationPrint PrintOperation = (x, y) => Console.WriteLine($"{x} + {y} = {x + y}");  

        public void CallLambda()
        {
            PrintOperation(1, 2);
            PrintOperation(22, 14);

            PrintOperation += (x, y) => Console.WriteLine($"{x} - {y} = {x - y}");

            PrintOperation(40, 25);

            //Лямбда вирази як і делегати можна передавати параметрами
            Console.WriteLine(operation(55, 25));
        }
        #endregion
    }











    class AccountEventArgs
    {
        // Повідомлення
        public string Message { get; }
        // Додаткова хитрість
        public int ExtraCunning { get; }
        public AccountEventArgs(string message, int extraCunning)
        {
            Message = message;
            ExtraCunning = extraCunning;
        }
    }
}
