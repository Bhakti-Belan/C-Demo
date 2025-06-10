using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemonstration
{
    public delegate double TaxDelegate(IVehicle vehicle);

    internal class Taxlogic
    {
        public static double CalaculateCarTax(IVehicle v)
        {
            return v.Price * 0.05;
        }
        public static double CalaculateBikeTax(IVehicle v)
        {
            return v.Price * 0.02;
        }

    }
}
