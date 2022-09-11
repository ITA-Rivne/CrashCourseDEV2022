using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Device = SmartHouse_MAU.Models.Device;

namespace SmartHouse_MAU.Models
{
    enum AirCondMode { Normal, Cool, Warm}
    class AirConditioner : Device
    {

        private int _delta;
        //private AirCondMode _mode = AirCondMode.Normal;   
        public AirConditioner(int delta = 1)
        {
            _delta = delta;
        }
        string _info = "";
        public string Info 
        {
            get => _info;
            set => _info = value;
        } 
        public AirCondMode Mode { get; set; }
        //{
        //    get=>_mode;
        //    set=> _mode = value;    
        //}
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
                        Info += $"Now {h.Temperature} C\u00b0 --> Air cooling\n\r";
                        Mode = AirCondMode.Cool;
                        h.Temperature -= _delta;
                        break;
                    case NeedsRegime.NeedWarm:
                        Debug.WriteLine($"\t\tNow {h.Temperature} C\u00b0 --> Air heating");
                        Info += $"Now {h.Temperature} C\u00b0 --> Air heating\n\r";
                        Mode = AirCondMode.Warm;
                        h.Temperature += _delta;
                        break;
                    case NeedsRegime.NeedOutFire:
                        Info += $"Now {h.Temperature} C\u00b0 --> Dangerous(> 50)\n\r";
                        Debug.WriteLine($"\t\tNow {h.Temperature} C\u00b0 --> Dangerous of fire!!!!");
                        Mode = AirCondMode.Cool;
                        break;
                    default: // Normal
                             // Info = "";
                        Info += $"Now {h.Temperature} C\u00b0 --> Normal\n\r";
                        Debug.WriteLine($"\t\tNow {h.Temperature} C\u00b0 --> Normal!!!!");
                        Mode = AirCondMode.Normal;
                        break;
                };
            }
            else
                Debug.WriteLine(">>>>>>>>>>>>>>>>>> Must On AirCondition >>>>>>>");

        }
    }
}
