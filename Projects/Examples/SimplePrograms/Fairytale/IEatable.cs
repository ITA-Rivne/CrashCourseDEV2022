using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fairytale
{
    interface IEatable
    {
        Kolobok Eat(ref Kolobok kolobok);
    }
}
