using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fairytale
{
    public class Kolobok
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

            Console.WriteLine("Hello! I'm Kolobok");
            Console.WriteLine($"My cunning = {this.cunning}; My speed = {this.speed} \n");
        }

        public string RunAway(string person)
        {
            this.defeatedPersons.Add(person);
            return "Goodbye!";
        }

        public string SingSong()
        {
           // var song = "Я Колобок, Колобок! я по коробу метений, я на яйцях спечений. ";
            var song = "Please, don't eat me. I will sign you my song! \n My song1 ";
            foreach (var person in defeatedPersons)
            {
                //song += $"Я від {person} утік! ";
                song += $"I've run away from {person}! ";
            }
            song += "And will go away from you! \n";
            return song;
        }
    }
}