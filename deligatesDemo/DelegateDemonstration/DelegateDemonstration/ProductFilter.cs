using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemonstration
{
    public delegate void FilterProduct(Products[] products);
    internal class ProductFilter
    {
        public static void expensive(Products[] products)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Expensive Products Are:");
            foreach (Products p1 in products)
                {
                if(p1.price>100)
                {
                  
                    Console.WriteLine("Name: "+p1.name + " Price: " + p1.price + " Stock: " + p1.count + " Category: " + p1.category);
                }
            }
            Console.WriteLine("---------------------------------------------------");
        }
        public static void stock(Products[] products)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Products Runnning Out Of Stock Are:");
            foreach (Products p1 in products)
            {
                if (p1.count <10)
                {

                    Console.WriteLine("Name: " + p1.name + " Price: " + p1.price + " Stock: " + p1.count + " Category: " + p1.category);
                }
            }
            Console.WriteLine("---------------------------------------------------");
        }
        public static void category(Products[] products)
        {
            Console.WriteLine("Enter Category To Search:");
            string category=Console.ReadLine();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Products In " + category + " Are:");
            foreach (Products p1 in products)
            {
                if (p1.category.Equals(category))
                {

                    Console.WriteLine("Name: " + p1.name + " Price: " + p1.price + " Stock: " + p1.count + " Category: " + p1.category);
                }
            }
            Console.WriteLine("---------------------------------------------------");
        }
    }
}
