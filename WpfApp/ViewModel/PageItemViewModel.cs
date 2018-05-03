using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace WpfApp.ViewModel
{
    public class PageItemViewModel : ViewModelBase
    {
        private string _name;
        private object _content;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        public object Content
        {
            get => _content;
            set
            {
                _content = value;
                RaisePropertyChanged();
            }
        }
    }
}
