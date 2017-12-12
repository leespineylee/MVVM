using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryFinal;
using System.ComponentModel;

namespace WPFShipping.ViewModels
{
    public class BaseViewModel
    {
         public IShippingService shippingservice;





















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

