using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse_MAU.Models
{
    enum NeedsRegime { Normal, NeedWarm, NeedCool, NeedOutFire }

    class NeedsRegimeEventArgs : EventArgs
    {
        public NeedsRegime NeedsRegime { get; set; }
    }
}
