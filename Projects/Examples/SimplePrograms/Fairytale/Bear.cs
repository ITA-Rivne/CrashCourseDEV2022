using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fairytale
{
    //Оголошуємо делегат (можемо оголошувати як в середині так і ззовні класу)
    delegate void PrintMessage(string msg);

    public class Bear : Animal, ISpeakable
    {
        // створюємо змінні типу делегат
        PrintMessage myDelegate, myDelegate2;

        #region Oголошуємо методи, що за сигнатурою відповідають оголошеному делегату
        public void DisplayMessageInConsole(string msg)
        {
            Console.WriteLine($"Display Message to console: {msg}");
        }        
        
        public void DisplayMessageToLogFile(string msg)
        {
            Console.WriteLine($"Print Message to logFile: {msg}");
        }
        #endregion

        public Bear(string name, int cunningIndex = 1) : base(name, cunningIndex)
        {
            //Присвоюємо нашій змінній адресу методу
            myDelegate = DisplayMessageInConsole;


            //Можемо делегату присвоювати посилання на кілька методів
            myDelegate += DisplayMessageToLogFile;
        }

        public string SayHello()
        {
            myDelegate.Invoke("Hello! [delegate]");

            return "Hello!";
        }

        public string IntroduceYourself(ISpeakable person = null)
        {
            myDelegate -= DisplayMessageToLogFile;
            myDelegate("I'm Bear [delegate]");

            return "I'm Bear";
        }

        public string SpeakMessage(string message)
        {
            myDelegate2 = DisplayMessageToLogFile;
            var myDelegate3 = myDelegate + myDelegate2;
            myDelegate3.Invoke(message + "[myDelegate + myDelegate2]");

            return "";
        }
    }
}
