using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//In this class first the records from the CSV file will be inserted to the list of CUstomerDetails and Vehicle Details and as per user request it will out put the reports 
namespace Graduate_Test_Brief
{
    class Reports
    {
        public static void insertRecords(string filePath)
        {
            List<CustomerDetails> customers = new List<CustomerDetails>();
            List<VehicleDetails> vehicles = new List<VehicleDetails>();
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');

                    if (!fields[4].Equals(""))
                    {
                        if (fields[0] != CustomerDetails.CustomerID)
                        {
                            customers.Add(new CustomerDetails(fields[0], fields[1], fields[2], fields[3]));
                        }
                        vehicles.Add(new VehicleDetails(fields[0], fields[4], fields[5], fields[6], fields[7], fields[8], fields[9], fields[10], fields[11], fields[12]));
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }

        public static void getReport1()
        {
            try
            {
                Console.WriteLine("REPORT FOR ALL KNOWN CUSTOMERS AND ANY VEHICLES THEY OWN:");
                Console.WriteLine("CustomerID  ForeName  Surname  DateOfBirth  VehicleID  RegNumber  Manufacturer   Model     EngineSize  RegDate     InteriorColour  HasHalmet  VehicleType");
                List<string> customers = CustomerDetails.getDetails();
                List<string> vehicles = VehicleDetails.getDetails();

                for (int i = 0; i < customers.Count; i++)
                {
                      string[] customerFields = customers[i].Split(',');
                    for (int j = 0; j < vehicles.Count; j++)
                    {
                        string[] vehicleFields = vehicles[j].Split(',');

                        if (customerFields[0] == vehicleFields[0])
                        {
                            Console.WriteLine(customerFields[0] + "           " + customerFields[1] + "       " + customerFields[2] + "    " + customerFields[3] + "   " + vehicleFields[1] + "          " + vehicleFields[2] + "   " + vehicleFields[3] + "       " + vehicleFields[4] + "      " + vehicleFields[5] + "        " + vehicleFields[6] + "  " + vehicleFields[7] + "        " + vehicleFields[8] + "              " + vehicleFields[9]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void getReport2(int minAge, int maxAge)
        {

            try
            {
                Console.WriteLine("REPORT FOR ALL CUSTOMERS BETWEEN THE AGE OF 20 AND 30:");
                Console.WriteLine("CustomerID  ForeName  Surname  DateOfBirth");
                List<string> customer = CustomerDetails.getDetails();
                for (int i = 0; i < customer.Count; i++)
                {
                    string[] customerFields = customer[i].Split(',');

                    DateTime birthDate = DateTime.Parse(customerFields[3]);
                    DateTime currentDate = DateTime.Now;

                    int age = currentDate.Year - birthDate.Year;

                    if (birthDate > currentDate.AddYears(-age))
                    {
                        age--;
                    }

                    if (age > minAge && age < maxAge)
                    {
                        Console.WriteLine(customerFields[0] + "           " + customerFields[1] + "       " + customerFields[2] + "    " + customerFields[3]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        public static void getReport3(int Year)
        {
            try
            {
                Console.WriteLine("REPORT FOR ALL VEHICLES REGISTERED BEFORE 1ST JANUARY 2010:");
                Console.WriteLine("VehicleID  RegNumber  Manufacturer   Model     EngineSize  RegDate     InteriorColour  HasHalmet  VehicleType");
                List<string> vehicles = VehicleDetails.getDetails();
                for (int i = 0; i < vehicles.Count; i++)
                {
                    string[] vehicleFields = vehicles[i].Split(',');
                    if (!vehicleFields[6].Equals(""))
                    {
                        DateTime regDate = DateTime.Parse(vehicleFields[6]);
                        if (regDate.Year < Year)
                        {
                            Console.WriteLine(vehicleFields[1] + "          " + vehicleFields[2] + "   " + vehicleFields[3] + "        " + vehicleFields[4] + "      " + vehicleFields[5] + "        " + vehicleFields[6] + "  " + vehicleFields[7] + "        " + vehicleFields[8] + "              " + vehicleFields[9]);
                        }
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void getReport4(int engSize)
        {
            try
            {
                Console.WriteLine("REPORT FOR ALL VEHICLES WITH AN ENGINE SIZE OVER 1100:");
                Console.WriteLine("VehicleID  RegNumber  Manufacturer   Model     EngineSize  RegDate     InteriorColour  HasHalmet  VehicleType");
                List<string> vehicles = VehicleDetails.getDetails();

                for (int i = 0; i < vehicles.Count; i++)
                {
                    string[] vehicleFields = vehicles[i].Split(',');
                    if (!vehicleFields[5].Equals(""))
                    {
                        int engineSize = Int32.Parse(vehicleFields[5]);
                        if (engineSize > engSize)
                        {
                            Console.WriteLine(vehicleFields[1] + "          " + vehicleFields[2] + "   " + vehicleFields[3] + "        " + vehicleFields[4] + "      " + vehicleFields[5] + "        " + vehicleFields[6] + "  " + vehicleFields[7] + "        " + vehicleFields[8] + "              " + vehicleFields[9]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
