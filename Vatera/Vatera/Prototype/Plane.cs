using System;
using System.Collections.Generic;
using System.Text;
using Vatera.Class;
using Vatera.Interface;

namespace Vatera.Prototype
{
    class Plane : IPlane
    {
        private String deliveryAddress;
        public String DeliveryAddress { set; get; }

        private List<Item> deliveryProduct;
        public List<Item> DeliveryProduct { set; get; }

        private String sojourn;
        public String Sojourn { set; get; }

        public Plane(String deliveryAddress, List<Item> deliveryProduct, String sojourn)
        {

        }

        public IPlane ShallowCopy()
        {
            Plane clone = new Plane(DeliveryAddress, DeliveryProduct, Sojourn);
            clone.deliveryAddress = deliveryAddress;
            clone.deliveryProduct = deliveryProduct;
            clone.sojourn = sojourn;
            return clone;
        }
        public Object Clone()
        {
            return (Plane)MemberwiseClone();
        }


    }
}
