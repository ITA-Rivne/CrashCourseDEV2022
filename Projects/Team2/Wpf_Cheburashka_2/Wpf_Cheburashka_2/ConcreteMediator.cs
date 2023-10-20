using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheburaska_Pattern
{
    class ConcreteMediator : IMediator
    {
        public Cheburashka  Colleague1 { get; set; }
        public Crocodile Colleague2 { get; set; }
        public Dog Colleague3 { get; set; }
        public Lion Colleague4 { get; set; }
        public Giraffe Colleague5 { get; set; }
        public Girl Colleague6 { get; set; }
        public Man Colleague7 { get; set; }

        public  void Send(string message, Colleague colleague)
        {
            if (Colleague1 == colleague)
                Colleague1.Notify(message);
            else if (Colleague2 == colleague)
                Colleague2.Notify(message);
            else if (Colleague3 == colleague)
                Colleague3.Notify(message);
            else if (Colleague4 == colleague)
                Colleague4.Notify(message);
            else if (Colleague5 == colleague)
                Colleague5.Notify(message);
            else if (Colleague6 == colleague)
                Colleague6.Notify(message);
            else if (Colleague7 == colleague)
                Colleague7.Notify(message);
        }
    }
}
