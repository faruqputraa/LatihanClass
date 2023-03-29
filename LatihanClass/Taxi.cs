
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassTaxi
{
    public class Taxi
    {
        // properties
        public string DriverName { get; set; }
        public Boolean OnDuty { get; set; }
        public int NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("DriverName: {0}", DriverName);
            if (OnDuty == true)
            {
                Console.WriteLine("OnDuty: Yes", OnDuty);
            }
            else
            {
                Console.WriteLine("OnDuty: No", OnDuty);
            }
            Console.WriteLine("NumPassenger: {0}\n", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);    
        }

        public void DropOffPassenger()
        {
            Console.WriteLine( "{0} selesai mengantar penumpang", DriverName);
        }
    }
}


