using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Glider_Game.Models
{
    class Glider : INotifyPropertyChanged
    {
        private int _altitudeReached;
        public int AltitudeReached
        {
            get { return _altitudeReached; }
            set
            {
                _altitudeReached = value;
                OnPropertyChanged("AltitudeReached");
            }
        }

        private int _descentSpeed;
        public int DescentSpeed
        {
            get { return _descentSpeed; }
            set
            {
                _descentSpeed = value;
                OnPropertyChanged("DescentSpeed");
            }
        }

        private int _weight;
        public int Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                OnPropertyChanged("Weight");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
        
}
