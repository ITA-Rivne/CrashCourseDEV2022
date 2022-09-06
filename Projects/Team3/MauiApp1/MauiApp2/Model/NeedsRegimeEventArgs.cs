using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Model
{
    enum NeedsRegime { NeedWarm, NeedCool, NeedOutFire }

    class NeedsRegimeEventArgs : EventArgs
    {
        public NeedsRegime NeedsRegime { get; set; }
    }
}
