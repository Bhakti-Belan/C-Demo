using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemonstration
{
    internal class AllVehicles
    {
    }
    public class Car : IVehicle
    {
        string type;
        double price;
        public string Type => type;

        public double Price => price;
        public Car(string t,double p)
        {
            type = t;
            price = p;
        }
    }
    public class Bike : IVehicle
    {
        string type;
        double price;
        public string Type => type;

        public double Price => price;
        public Bike(string t, double p)
        {
            type = t;
            price = p;
        }
    }
}
