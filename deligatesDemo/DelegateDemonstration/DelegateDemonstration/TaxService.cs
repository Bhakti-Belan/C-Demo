using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemonstration
{
    internal class TaxService
    {
       // private TaxDelegate taxCal;
        public TaxService(/*TaxDelegate taxCal*/)
        {
           // this.taxCal = taxCal;
        }
        public void printTax(TaxDelegate t, IVehicle vehicle)
        {
            double tax = t(vehicle);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Vehicle Type: " + vehicle.Type);
            Console.WriteLine("Vehicle Price: " + vehicle.Price);
            Console.WriteLine("Tax: " + tax);
            Console.WriteLine("------------------------------------------");
        }

    }
}
