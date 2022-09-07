using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fairytale
{
    public class Volf : Animal, ISpeakable
    {
        public Volf(string name, int cunningIndex = 1) : base(name, cunningIndex)
        {
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
    }
}
