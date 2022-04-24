using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileSalesManagement
{
    public class ReadMobiledataFile
    {
        public List<MobileData> getMobileInformation(string filePath)
        {
            //empty list will be created for storing result
            List<MobileData> list = new List<MobileData>();
            //reading lines from filePath and adding  in array of string
            string[] lines = System.IO.File.ReadAllLines(filePath);
            //iterating string array - lines
            foreach (string line in lines)
            {
            //will split in lines of file  where it will see ',' 
                string[] str = line.Split(',');
                //adding values in mobiledata objects 
                MobileData mobileData = new MobileData();
                mobileData.mobileId = Convert.ToInt32(str[0]);
                mobileData.mobileName = str[1];
                mobileData.mobilePrice = Convert.ToInt32(str[2]);
                mobileData.mobileQuantity = Convert.ToInt32(str[3]);
                mobileData.pincode = Convert.ToInt32(str[4]);
                mobileData.dateOfPurchase = Convert.ToDateTime(str[5]);
               // adding object of mobiledata in list
                list.Add(mobileData);
            }
            return list;
        }
    }
}
