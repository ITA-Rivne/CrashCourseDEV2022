using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fairytale
{
    public class Kolobok : ISpeakable
    {
        // клас Kolobok
        // колобок вміє співати пісню, утікати = два методи
        // поля - температура, хитрість, швидкість

        public int cunning;
        public int speed;
        public int temperature;
        private List<string> defeatedPersons; //переможені персонажі

        public Kolobok(int cunningIndex = 1)
        {
            this.cunning = new Random().Next(1, 10) * cunningIndex;
            this.temperature = new Random().Next(15, 65);
            this.defeatedPersons = new List<string>();
            this.speed = new Random().Next(1, 10);

            Console.WriteLine("Привіт! Я Колобок");
            Console.WriteLine($"Моя хитрість = {this.cunning}; Моя швидкість = {this.speed} \n");
        }


        public string SayHello()
        {
            return "Привіт! ";
        }

        public string IntroduceYourself(ISpeakable person = null) => SpeakMessage("Мене звати Колобок");

        public string SpeakMessage(string message)
        {
            Console.WriteLine(message);
            return message;
        }

        public Kolobok RunAway(string person)
        {
            //TODO: add NameConverter()
            if (person.EndsWith("а"))
                this.defeatedPersons.Add(person.Remove(person.Length - 1, 1) + "и");
            else
                this.defeatedPersons.Add(person + "a");


            Console.WriteLine($"Щасливо, {person}!\n");
            return this;
        }

        public string SingSong()
        {
            var song = "Не їж мене, я тобі пісеньку заспіваю! \nЯ Колобок, Колобок! Я по коробу метений, я на яйцях спечений. ";

            foreach (var person in defeatedPersons)
            {
                song += $"Я від {person} утік! ";
            }
            song += "І від тебе втечу!";
            return song;
        }
    }
}