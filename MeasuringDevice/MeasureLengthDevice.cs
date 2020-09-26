using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace MeasuringDevice
{
    class MeasureLengthDevice : Device, IMeasuringDevice
    {
        private Units unitsToUse;
        private int[] dataCaptured;
        private int mostRecentMeasure;
        private DispatcherTimer dispatcherTimer;

        //constructor
        public MeasureLengthDevice(Units unitsUsing)
        {
            unitsUsing = unitsToUse;
            dataCaptured = new int[20];
            mostRecentMeasure = 0;
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(TimerTick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 3);
        }

        //if recent measure is interpreted in in, convert to cm and return a decimal
        public decimal MetricValue()
        {
            //throw new NotImplementedException();
            if (this.unitsToUse == Units.Imperial)
            {
                return mostRecentMeasure * (decimal)0.3937;
            }
            return mostRecentMeasure;
        }

        //if recent measure is interpreted in cm, convert to in and return a decimal
        public decimal ImperialValue()
        {
            //throw new NotImplementedException();
            if (this.unitsToUse == Units.Metric)
            {
                return mostRecentMeasure * (decimal)2.54;
            }
            return mostRecentMeasure;
        }

        //starts device and collects measurements and records
        public void StartCollecting()
        {
            dispatcherTimer.Start();
        }

        //stops device and recording
        public void StopCollecting()
        {
            dispatcherTimer.Stop();
        }

        //retrieves copy of all recent data measuring device has captured and returns it as array of ints
        public int[] GetRawData()
        {
            //count the amount of data measured
            int count = 0;
            for (int i = 0; i < dataCaptured.Length; i++)
            {
                if (dataCaptured[i] != 0)
                {
                    count++;
                }
            }
            //create empty int array to put captured data in and return
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = dataCaptured[i];
            }
            return array;
        }

        //collects data every second
        void TimerTick(object sender, EventArgs e)
        {
            mostRecentMeasure = GetMeasurement();
            //captures measurements in data for GetRawData method, sort acquired data from newest descending
            for (int i = dataCaptured.Length - 1; i > 0; i--)
            {
                dataCaptured[i] = dataCaptured[i - 1];
            }
            dataCaptured[0] = mostRecentMeasure;
        }
    }
}
