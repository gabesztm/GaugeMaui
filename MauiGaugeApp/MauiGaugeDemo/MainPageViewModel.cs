using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiGaugeDemo
{
    internal class MainPageViewModel : INotifyPropertyChanged
    {

        private double _demoNumber = 10;

        public double DemoNumber
        {
            get { return _demoNumber; }
            set { _demoNumber = value; NotifyPropertyChanged(); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void IncreaseDemoNumber()
        {
            DemoNumber++;
        }

        public void DecreaseDemoNumber()
        {
            DemoNumber--;
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
