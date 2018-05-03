using System;
using System.Collections.Generic;
using GalaSoft.MvvmLight;
using WpfApp.Controls;

namespace WpfApp.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private bool _isMenuOpen;

        public bool IsMenuOpen
        {
            get => _isMenuOpen;
            set
            {
                _isMenuOpen = value;
                RaisePropertyChanged();
            }
        }

        public List<PageItemViewModel> PageItems { get; set; }

        public MainWindowViewModel()
        {
            PageItems = new List<PageItemViewModel>
            {
                new PageItemViewModel
                {
                    Name = "Insepction Information",
                    Content = new PatientInformationControl()
                }
            };
        }
    }
}
