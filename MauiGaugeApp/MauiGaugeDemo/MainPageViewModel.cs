using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiGaugeDemo
{
    internal class MainPageViewModel : INotifyPropertyChanged
    {

        private double _demoNumber = 4;

        public double DemoNumber
        {
            get { return _demoNumber; }
            set { _demoNumber = value; NotifyPropertyChanged(); }
        }

        private Color _gaugeColor = Colors.Green;

        public Color GaugeColor
        {
            get { return _gaugeColor; }
            set { _gaugeColor = value; NotifyPropertyChanged(); }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        public void IncreaseDemoNumber()
        {
            DemoNumber++;
            SetGaugeColor();
        }

        public void DecreaseDemoNumber()
        {
            DemoNumber--;
            SetGaugeColor();
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void SetGaugeColor()
        {
            if(DemoNumber > 8)
            {
                GaugeColor = Colors.Red;
                return;
            }
            if (DemoNumber > 5)
            {
                GaugeColor = Colors.Orange;
                return;
            }
            else
            {
                GaugeColor = Colors.Green;
            }
        }
    }
}
