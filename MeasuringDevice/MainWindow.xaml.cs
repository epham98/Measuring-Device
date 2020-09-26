using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MeasuringDevice
{

    public partial class MainWindow : Window
    {
        private IMeasuringDevice measuringDevice;
        private Units units;

        public MainWindow()
        {
            InitializeComponent();
            units = Units.Imperial;
            measuringDevice = new MeasureLengthDevice(units);
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            statusBlock.Text = "Collecting measurements";
            measuringDevice.StartCollecting();
        }

        //stops collecting data
        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            statusBlock.Text = "Stopped";
            measuringDevice.StopCollecting();
        }

        private void recentMeasureButton_Click(object sender, RoutedEventArgs e)
        {
            if (measureComboBox.Text.Equals("Inches"))
            {
                recentMeasureBlock.Text = measuringDevice.ImperialValue() + "in @ " + DateTime.Now;
            }
            else if (measureComboBox.Text.Equals("Centimeters"))
            {
                recentMeasureBlock.Text = measuringDevice.MetricValue() + "cm @ " + DateTime.Now;
            }
        }

        //display all data acquired
        private void rawDataButton_Click(object sender, RoutedEventArgs e)
        {
            int[] data = measuringDevice.GetRawData();
            decimal[] measure = new decimal[data.Length];
            //convert appropriately on measurement selected
            for (int i = 0; i < data.Length; i++)
            {
                decimal value = data[i];
                if (measureComboBox.Text.Equals("Inches"))
                {
                    value = value * (decimal)0.3937;
                }
                else if (measureComboBox.Text.Equals("Centimeters"))
                {
                    value = value * (decimal)2.54;
                }
                measure[i] = value;
            }
            //display results
            rawListBox.Items.Clear();

            foreach (decimal value in measure)
            {
                if (measureComboBox.Text.Equals("Inches"))
                {
                    rawListBox.Items.Add(value + "in");
                }
                else if (measureComboBox.Text.Equals("Centimeters"))
                {
                    rawListBox.Items.Add(value + "cm");
                }
            }
        }
    }
}
