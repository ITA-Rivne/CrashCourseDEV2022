using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_House
{
    abstract class Device : IDevice
    {   
        int _id = ++lastId; //id
        static int lastId = 0;//count devices in house
        bool _on = false;
        
        public void Power()
        {
            _on=!_on;
        }
    }
}
