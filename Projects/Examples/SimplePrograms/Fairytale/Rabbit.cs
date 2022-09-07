using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fairytale
{
    public class Rabbit : Animal, ISpeakable
    {
        public Rabbit(string name, int cunningIndex = 1) : base(name, cunningIndex)
        {
        }

        public string IntroduceYourself(ISpeakable person)
        {
            var str = "Мене звати Зайчик! A ти хто?";

            Console.WriteLine(str);

            Console.WriteLine(person.SayHello());
            person.IntroduceYourself(this);

            return str;
        }

        public string SayHello()
        {
            return SpeakMessage("Привіт! ");
        }

        public string SpeakMessage(string message)
        {
            Console.WriteLine(message);
            return message;
        }
    }
}
