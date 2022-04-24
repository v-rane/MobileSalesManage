using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileSalesManagement
{
    public class OrderQuantityByPin
    {
        public int NumOfOrders { get; set; }
        public int Pincode { get; set; }

        public OrderQuantityByPin() { }
        public OrderQuantityByPin(int orders, int pincode)
        {
            NumOfOrders = orders;
            Pincode = pincode;
        }
    }
}
