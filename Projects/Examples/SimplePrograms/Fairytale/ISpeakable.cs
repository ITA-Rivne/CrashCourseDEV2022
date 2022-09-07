using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fairytale
{
    public interface ISpeakable
    {
        string SayHello();

        string IntroduceYourself(ISpeakable person);

        string SpeakMessage(string message);
    }
}
