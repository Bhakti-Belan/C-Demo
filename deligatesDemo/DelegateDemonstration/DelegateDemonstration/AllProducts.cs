using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemonstration
{
    public class Products
    {
   
        public string name;
        public double price;
        public string category;
        public int count;
       
       public Products(string name, double price, string category, int count)
        {
            this.name = name;
            this.price = price;
            this.category = category;
            this.count = count;
        }
    }
    
}
