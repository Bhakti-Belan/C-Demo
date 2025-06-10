using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemonstration
{
    public delegate int operation(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Publisher publisher = new Publisher();
              Subscriber sub1 = new Subscriber("Bhakti");
              Subscriber sub2 = new Subscriber("Aqsa");

              publisher.Notify += sub1.ReceiveMessage;
              publisher.Notify += sub2.ReceiveMessage;
              publisher.SendMessage("Hello");*/

              Products[] p = new Products[5];
              p[0] = new Products("Monitor", 5000, "Electronic", 12);
              p[1] = new Products("Pen", 50, "Stationery", 10);
              p[2] = new Products("Pencil", 100, "Stationery", 05);
              p[3] = new Products("Notebook", 150, "Stationery", 15);
              p[4] = new Products("Mouse", 1000, "Electronic", 11);
              FilterLogic fl=new FilterLogic(ProductFilter.expensive);
             FilterLogic fl1=new FilterLogic(ProductFilter.stock);
             FilterLogic fl2=new FilterLogic(ProductFilter.category);
            fl.FilteredProduct(p);
            fl1.FilteredProduct(p);
            fl2.FilteredProduct(p);

           /* Alarm myalarm = new Alarm();
            myalarm.OnAlarmRaised += NeedToGetup;
            myalarm.CheckTime(6);
            myalarm.CheckTime(7);   */



        }
        public static void NeedToGetup()
        {
            Console.WriteLine("New day,new energy,new me");
        }

    }
}
