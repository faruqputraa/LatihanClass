using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using LatihanClassTaxi;

namespace LatihanClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //membuat objek taxi
            Taxi taxi = new Taxi();

            //pengesetan nilai
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            //pengambilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();
                
            Console.ReadKey();
        }
    }
}