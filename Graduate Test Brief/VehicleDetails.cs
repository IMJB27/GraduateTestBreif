using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduate_Test_Brief
{
    class VehicleDetails
    {
        public static List<string> vehicleDetails = new List<string>();

        public static string CustomerID { get; set; }
        public static string VehicleID { get; set; }
        public static string RegistrationNumber { get; set; }
        public static string Model { get; set; }
        public static string Manufacturer { get; set; }
        public static string EngineSize { get; set; }
        public static string RegistationDate { get; set; }
        public static string InteriorColour { get; set; }
        public static string HasHelmetStorage { get; set; }
        public static string VehicleType { get; set; }

        public VehicleDetails(string customerID, string vehicleID, string registrationNumber, string manufacturer, string model, string engineSize, string registrationDate, string interiorColour, string hasHelmetStorage, string vehicleType)
        {
            CustomerID = customerID;
            VehicleID = vehicleID;
            RegistrationNumber = registrationNumber;
            Model = model;
            Manufacturer = manufacturer;
            EngineSize = engineSize;
            RegistationDate = registrationDate;
            InteriorColour = interiorColour;
            HasHelmetStorage = hasHelmetStorage;
            VehicleType = vehicleType;
            setDetails();
        }

        public static void setDetails()
        {
            vehicleDetails.Add(CustomerID + "," + VehicleID + "," + RegistrationNumber + "," + Manufacturer + "," + Model + "," + EngineSize + "," + RegistationDate + "," + InteriorColour + "," + HasHelmetStorage + "," + VehicleType);
        }

        public static List<string> getDetails()
        {
            return vehicleDetails;
        }
    }
}
