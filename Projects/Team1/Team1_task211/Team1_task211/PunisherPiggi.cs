using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team1_task211
{
    class PunisherPiggi : Piggi  //супер-порося, яке карає вовка, коли він зїдає порося
    {
        String name;
        public PunisherPiggi(String name):base(name)
        {
            this.name = name;

        }

        public int punishTheWolf(int WolflevelOfHungry, string name, string piggiName)
        {
            Console.WriteLine("Я {0} прийшов покарати вовка за те, що він з'їв порося {1}!", name, piggiName);
            WolflevelOfHungry -= 20;
            Console.WriteLine("Тепер у тебе життів "+ WolflevelOfHungry);
            return WolflevelOfHungry;   

        }

    }
}
