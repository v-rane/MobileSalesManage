using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileSalesManagement
{
    public class Program
    {
        /*
         * @className- Program
         * @objective - for orcastation of program by calling several methods 
         */
        static void Main(string[] args)
        {
            //storing path of file which has input for program
            string filePath = "C:\\Users\\Varsha Rane\\Documents\\ProductSales.csv";
            ReadMobiledataFile readMobiledataFile = new ReadMobiledataFile();
            //calling method getMobileInformation and passing filePath in it
            List<MobileData> list = readMobiledataFile.getMobileInformation(filePath);
            Console.WriteLine("Mobile sales data is given below");
            //to display all objects of the list by assigning in list
            foreach (MobileData sales in list)
            {
                Console.WriteLine(sales.mobileId +"  , " + sales.mobileName + "  , " + sales.mobilePrice + "  , " + sales.mobileQuantity + "  , " + sales.pincode + "  , " + sales.dateOfPurchase);
            }
            Console.WriteLine("******************************************************************");

            //problem 1:- getting mobile revenues by mobileId
            MobileDataOperations mobileDataOperations = new MobileDataOperations();
            //storing result in resultList1 
            List<TotalSalesById> resultList1 = mobileDataOperations.getMobileRevenueByMobileId(list);
            foreach(var sales in resultList1)
            {
               Console.WriteLine(sales.MobileId + "," + sales.MobileName + " ," + sales.TotalQuantity + " ," + sales.TotalRevenue);
            }
            Console.WriteLine("************************************************************************************************************");

            //problem 2:- getting mobile revenue by Pincode
            List<OrderQuantityByPin> resultList2 = mobileDataOperations.getOrderQuantityByPin(list);
            foreach(var sales in resultList2)
            {
                Console.WriteLine(sales.Pincode +" , "+sales.NumOfOrders);
            }
        }
    }
    
}
