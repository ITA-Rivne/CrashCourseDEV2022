using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Device = MauiApp2.Model.Device;

namespace MauiApp2.Model
{
    class AirConditioner : Device
    {

        private int _delta;
        public AirConditioner(int delta = 1)
        {
            _delta = delta;
        }

        public void Handler(object o, EventArgs e)
        {
            if (IsOn())
            {
                House h = o as House;
                NeedsRegimeEventArgs ne = e as NeedsRegimeEventArgs;
                switch (ne.NeedsRegime)
                {
                    case NeedsRegime.NeedCool:
                        Debug.WriteLine($"\t\tNow {h.Temperature} C\u00b0 --> Air cooling");
                        h.Temperature -= _delta;
                        break;
                    case NeedsRegime.NeedWarm:
                        Debug.WriteLine($"\t\tNow {h.Temperature} C\u00b0 --> Air heating");
                        h.Temperature += _delta;
                        break;
                    case NeedsRegime.NeedOutFire:
                        Debug.WriteLine($"\t\tNow {h.Temperature} C\u00b0 --> Dangerous of fire!!!!");
                        break;
                    default:
                        break;
                };
            }
            else
                Debug.WriteLine(">>>>>>>>>>>>>>>>>> Must On AirCondition >>>>>>>");

        }
    }
}
