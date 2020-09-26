using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasuringDevice
{
    public class Device
    {
        private Random rand;

        //create device timer and set timer event to method
        public Device()
        {
            rand = new Random();
        }

        //randomly generate a measurement between 1 and 10
        public int GetMeasurement()
        {
            return rand.Next(1, 11);
        }
    }
}
