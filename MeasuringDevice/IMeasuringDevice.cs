using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasuringDevice
{
    public interface IMeasuringDevice
    {
        //return decimal representing metric value of most recent measurement
        decimal MetricValue();
        //returns decimal representing imperial value of most recent measurement
        decimal ImperialValue();
        //starts device and collects measurements
        void StartCollecting();
        //stops device and collecting
        void StopCollecting();
        //gets copy of all measurements recorded as an array
        int[] GetRawData();
    }
}
