using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ClassLibraryFinal;

namespace WpfShippingService.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged, IShippingLocation
    {
        private IShippingService _model;

        public IShippingService model
        {
            get => _model;
            set => _model = value;
        }

        
        public uint StartZipCode { get; }












        public uint _DestinationZipCode;
        public uint DestinationZipCode
        {
            get { return _DestinationZipCode; }
            set
            {
                this._DestinationZipCode = value;
                
                RaisePropertyChangedHandler("DestinationZipCode");
            }

        }

        public uint test
        {
            get { return DestinationZipCode - StartZipCode; }
            set { test = value; }
        }









        public BaseViewModel(IShippingService model)
        {
            this.model = model;
            StartZipCode = 60613;
            DestinationZipCode = 60612;


        }




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
