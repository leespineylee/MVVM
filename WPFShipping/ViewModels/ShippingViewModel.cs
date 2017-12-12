using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryFinal;

namespace WPFShipping.ViewModels
{
    public class ShippingViewModel : BaseViewModel
    {

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

        public uint StartZipCode { get; }




        public ShippingViewModel(IShippingService shippingService)
       {
           this.shippingservice = shippingService;
           StartZipCode = 60613;
           DestinationZipCode = 60612;
        }
    }
}
