using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using DotNetGui.MVVMDemo.Lib.Data;
using System.Collections.ObjectModel;

namespace DotNetGui.MVVMDemo.PeopleList.ViewModel
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person _person;
        private ObservableCollection<AddressViewModel> _addresses = new ObservableCollection<AddressViewModel>();

        public PersonViewModel(Person person)
        {
            _person = person;

            foreach (Address tempAddress in _person.Addresses)
                _addresses.Add(new AddressViewModel(tempAddress));
        }

        public String FirstName
        {
            get { return _person.FirstName; }
            set 
            {
                if (_person.FirstName != value)
                {
                    _person.FirstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }

        public string LastName
        {
            get { return _person.LastName; }
            set 
            {
                if (_person.LastName != value)
                {
                    _person.LastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }

        public DateTime Birthday
        {
            get { return _person.Birthday; }
            set 
            {
                if (_person.Birthday != value)
                {
                    _person.Birthday = value;
                    OnPropertyChanged("Birthday");
                }
            }
        }

        public ObservableCollection<AddressViewModel> Addresses
        {
            get { return _addresses; }
        }

        public bool IsSelected { get; set; }

        #region INotifyPropertyChanged Members

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
