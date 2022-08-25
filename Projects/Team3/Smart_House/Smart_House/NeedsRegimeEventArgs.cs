using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_House
{
    enum NeedsRegime { NeedWarm, NeedCool, NeedOutFire }

    class NeedsRegimeEventArgs : EventArgs
    {
        public NeedsRegime NeedsRegime { get; set; }
    }
}
