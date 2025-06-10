using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemonstration
{
    public class Publisher
    {
        public Action<string> Notify ;
            public void SendMessage(string message)
        {
            Notify(message);
        }
    }
    public class Subscriber
    {
        private string _name;
        public Subscriber(string name)
        {
            _name = name;
        }
        public void ReceiveMessage(string message)
        {

            Console.WriteLine($"{_name} received:{message}");
        }
    }
}
