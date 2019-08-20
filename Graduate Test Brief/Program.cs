using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//This is the Main Class from where the user can request which report he/she wants to know
namespace Graduate_Test_Brief
{
    class Program
    {

        static void Main(string[] args)
        {
            string sChoice;
            int iChoice;
            bool condition = true;
            Reports.insertRecords(@"..\..\Assets\Customer Information.csv");
            do
            {
                Console.WriteLine("WELCOME TO CRM...");
                Console.WriteLine("PLEASE CHOOSE A OPTION FROM BELOW:");
                Console.WriteLine("1. REPORT FOR ALL KNOWN CUSTOMERS AND ANY VEHICLES THEY OWN.");
                Console.WriteLine("2. REPORT FOR ALL CUSTOMERS BETWEEN THE AGE OF 20 AND 30.");
                Console.WriteLine("3. REPORT FOR ALL VEHICLES REGISTERED BEFORE 1ST JANUARY 2010.");
                Console.WriteLine("4. REPORT FOR ALL VEHICLES WITH AN ENGINE SIZE OVER 1100.");
                Console.WriteLine("5. EXIT");
                Console.Write("PLEASE ENTER YOUR CHOICE HERE: ");
                sChoice = Console.ReadLine();
                iChoice = Convert.ToInt32(sChoice);

                switch (iChoice)
                {
                    case 1:
                        Reports.getReport1();
                        break;

                    case 2:
                        Reports.getReport2(20, 30);
                        break;

                    case 3:
                        Reports.getReport3(2010);
                        break;

                    case 4:
                        Reports.getReport4(1100);
                        break;
                    case 5:
                        condition = false;
                        break;
                    default:
                        Console.Read();
                        break;
                }

            } while (condition == true);

        }
    }
}
