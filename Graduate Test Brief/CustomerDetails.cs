using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//In this class all the data of customers will be stored in list named customerDetails and when user request it will return all details of every customers
namespace Graduate_Test_Brief
{
    class CustomerDetails
    {
       public static List<string> customerDetails = new List<string>();

        public static string CustomerID { get; set; }
        public static string CustomerName { get; set; }
        public static string CustomerSurname { get; set; }
        public static string CustomerDOB { get; set; }

        public CustomerDetails(string customerID, string customerName, string customerSurname, string custuomerDOB)
        {
            CustomerID=customerID;
            CustomerName=customerName;
            CustomerSurname=customerSurname;
            CustomerDOB=custuomerDOB;
            setDetails();
        }

        public static void setDetails()
        {
            customerDetails.Add(CustomerID + "," + CustomerName + "," + CustomerSurname + "," + CustomerDOB);
        }

         public static List<string> getDetails()
         {
             return customerDetails;
         }
    }
}
