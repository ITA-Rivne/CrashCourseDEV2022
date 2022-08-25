using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_House
{
    class MotionSensor : ISensor
    {
        private const int defaultLUX = 50;
        private bool _isMoving = false;
        private int _lux;

        public bool IsMoving {
            get => _isMoving;
            set => _isMoving = value;
        }

        public House House;

        //int _desireMinLUX;
        //int _desireMaxLUX;
        public MotionSensor(House house,int lux=defaultLUX) {
            this._lux = lux;
            this.House = house;
        }

        public int Value
        {
            get => _lux;
            set {
                _lux = value;
                if (IsMoving && _lux < defaultLUX) {
                    ValueOutOfRange?.Invoke(House, null);
                }
            }
        }

        public event EventHandler ValueOutOfRange;
    }
}
