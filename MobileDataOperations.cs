using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileSalesManagement
{
    public class MobileDataOperations
    {
        /*
         * @className - MobileDataOperations
         * @objective- to aggregate data of mobileData
         * @autherName - Varsha Rane
         * @date - 21-2-2022
         */
        public List<TotalSalesById> getMobileRevenueByMobileId(List<MobileData> list)
        {
            //dic with Id as key and object of TotalSalesById as value
            Dictionary<int, TotalSalesById> dic = new Dictionary<int, TotalSalesById>();
            //list creating for storing result
            List<TotalSalesById> resultList = new List<TotalSalesById>();
            foreach (MobileData mobileData in list)
            {
                if (dic.ContainsKey(mobileData.mobileId))
                {
                    //if same mobileId come in dic again then make changes in TotalQuantity and TotalRevenue for getting total
                    dic[mobileData.mobileId].TotalQuantity += mobileData.mobileQuantity;
                    dic[mobileData.mobileId].TotalRevenue*=mobileData.mobileQuantity;
                }
                else
                {
                    //assigning values in dic by creating object of TotalSalesById 
                    dic.Add(mobileData.mobileId, new TotalSalesById());
                    dic[mobileData.mobileId].MobileId = mobileData.mobileId;
                    dic[mobileData.mobileId].TotalQuantity = mobileData.mobileQuantity;
                    dic[mobileData.mobileId].TotalRevenue = mobileData.mobilePrice;
                    dic[mobileData.mobileId].MobileName= mobileData.mobileName;
                }

            }
            foreach(var data in dic.Values)
            {
                resultList.Add(data);
            }
            return resultList;
        }
        //******************************************************************************************************
        public List<OrderQuantityByPin> getOrderQuantityByPin(List<MobileData> list)
        {/*
          * @MethodName - getOrderQuantityByPin
          * @objective - to get the number of orders for pincode
          * @para - List<MobileData>
          * @return - List<OrderQuantityByPin>
          */

            //dic is creating with pincode as key and OrderQuantityByPin as object
            Dictionary<int, OrderQuantityByPin> dic = new Dictionary<int, OrderQuantityByPin>();
            //iterating list of mobileData object
             OrderQuantityByPin orderQuantityByPin = new OrderQuantityByPin();
            foreach (MobileData data in list)
            {
                if (dic.ContainsKey(data.pincode))
                {
                    dic[data.pincode].NumOfOrders += data.mobileQuantity; 
                }
                else
                {
                    //adding in dic if dic does not contains pincode 
                    dic.Add(data.pincode,new OrderQuantityByPin());
                    dic[data.pincode].Pincode = data.pincode;
                    dic[data.pincode].NumOfOrders = data.mobileQuantity;                 
                }
            }
            //returning list after creating dic to list  
            return dic.Values.ToList();
        }
        
        
    }
}
