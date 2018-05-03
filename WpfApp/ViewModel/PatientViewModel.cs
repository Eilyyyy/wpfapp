using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace WpfApp.ViewModel
{
    public class PatientViewModel : ViewModelBase
    {
        private string _name;
        private string _email;
        private Gender _gender;
        private string _phoneNumber;
        private string _idNumber;
        private DateTime _birthday;
        private DateTime _registerDay;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                RaisePropertyChanged();
            }
        }

        public Gender Gender
        {
            get => _gender;
            set
            {
                _gender = value;
                RaisePropertyChanged();
            }
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
                RaisePropertyChanged();
            }
        }

        public string IdNumber
        {
            get => _idNumber;
            set
            {
                _idNumber = value;
                RaisePropertyChanged();
            }
        }

        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                _birthday = value;
                RaisePropertyChanged();
            }
        }

        public DateTime RegisterDay
        {
            get => _registerDay;
            set
            {
                _registerDay = value;
                RaisePropertyChanged();
            }
        }
    }

    public enum Gender
    {
        Man,
        Woman
    }
}
