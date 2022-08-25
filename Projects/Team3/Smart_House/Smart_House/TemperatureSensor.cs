﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_House
{
    class TemperatureSensor : ISensor
    {
        private const int defaultTemperature = 18;
        private const int defaultMaxTemperature = 23;
        private const int defaultDangerousFireTemperature = 50;

        private int _temperature; // 
        int _desireMinTemperature;
        int _desireMaxTemperature;
        int _dangerousFireTemperature;

        public House house;
        public TemperatureSensor(House house,
            int minDesireTemp = defaultTemperature,
            int maxDesireTemp = defaultMaxTemperature,
            int dangerousFireTemp = defaultDangerousFireTemperature)
        {
            this.house = house;
            _desireMinTemperature = minDesireTemp;
            _desireMaxTemperature = maxDesireTemp;
            _dangerousFireTemperature = dangerousFireTemp;
            // need check  and swap if bad
        }
        public int Value
        {
            get => _temperature;
            set
            {
                _temperature = value;
             }
        }

        public event EventHandler ValueOutOfRange;

    }
}
