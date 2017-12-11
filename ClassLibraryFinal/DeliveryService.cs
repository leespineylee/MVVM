﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryFinal
{
    public abstract class DeliveryService : IDeliveryService
    {

        protected double costPerRefuel;

        public double CostPerRefuel { get => costPerRefuel; set => costPerRefuel = value; }


        public IShippingVehicle ShippingVehicle { get => shippingVehicle; set => shippingVehicle = value; }


        protected IShippingVehicle shippingVehicle;

        public DeliveryService(IShippingVehicle vehicle)
        {
            this.shippingVehicle = vehicle;
        }

    }

    
}