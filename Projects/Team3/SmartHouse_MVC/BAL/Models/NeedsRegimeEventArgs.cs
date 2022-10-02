using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Models
{
  public  enum NeedsRegime { NeedWarm, NeedCool, NeedOutFire }

   public class NeedsRegimeEventArgs : EventArgs
    {
        public NeedsRegime NeedsRegime { get; set; }
    }
}
