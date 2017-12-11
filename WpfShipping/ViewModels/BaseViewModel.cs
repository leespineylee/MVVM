using ClassLibraryFinal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfShipping.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged
    {
        private IShippingService _model;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChangedHandler(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
