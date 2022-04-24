using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileSalesManagement
{
    public class MobileData
    {
        /*
         * @className - MobileData
         * @objective- getter setter of mobileData
         */
        public int mobileId { get; set; }
        public string mobileName { get; set; }
        public int mobilePrice { get; set; }
        public int mobileQuantity { get; set; }
        public int pincode { get; set; }
        public DateTime dateOfPurchase { get; set; }
    }
}
