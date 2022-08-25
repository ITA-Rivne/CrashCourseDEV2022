using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_House
{
    class AirConditioner : Device
    {

        private int _delta;
        public AirConditioner(int delta = 1)
        {
            this._delta = delta;
        }

        public void Handler(object o, EventArgs e)
        {

            House h = o as House;
            NeedsRegimeEventArgs ne = e as NeedsRegimeEventArgs;
            switch (ne.NeedsRegime)
            {
                case NeedsRegime.NeedCool:
                    Console.WriteLine($"\t\tNow {h.Temperature} C\u00b0 --> Air cooling");
                    h.Temperature -= _delta;
                    break;
                case NeedsRegime.NeedWarm:
                    Console.WriteLine($"\t\tNow {h.Temperature} C\u00b0 --> Air heating");
                    h.Temperature += _delta;
                    break;
                default:
                    break;
            };


        }
    }
}
