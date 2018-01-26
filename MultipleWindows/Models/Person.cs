using System;
using System.ComponentModel;

namespace MultipleWindows.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string _firstName = "";
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName.Equals(value) == false)
                {
                    _firstName = value;
                    OnPropertyChanged("FirstName");
                    OnPropertyChanged("FullName");
                }
            }
        }

        private string _lastName = "";
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName.Equals(value) == false)
                {
                    _lastName = value;
                    OnPropertyChanged("LastName");
                    OnPropertyChanged("FullName");
                }
            }
        }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
