using System;
using System.Collections.Generic;
using System.Text;

namespace day2
{
    
        public static class TemperatureConverter
        {
            public static double Cel2Far(double temp)
            {
                return ((temp * 9) / 5) + 32;
            }

            public static double Far2Cel(double temp)
            {
                return (temp - 32) * 5 / 9;
            }
        }
}
