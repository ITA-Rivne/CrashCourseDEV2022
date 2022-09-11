using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse_MAU.Models
{
    class Lamp : Device
    {
        private int _lux;

        public Lamp(int lux)
        {
            _lux = lux;
        }

        public void Handler(object o, EventArgs e)
        {
            if (!IsOn())
            {
                House h = o as House;
                h.Lamp.Power();
                Console.WriteLine(">>>>>>>> Somebody come in house. Lamp ON! >>>>>>>");

            }
            //else {
            //    Console.WriteLine(">>>>>>>>Lamp already  ON! >>>>>>>");
            //}


        }


    }
}
