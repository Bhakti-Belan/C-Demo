using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemonstration
{
    public class Alarm
    {
        public delegate void AlarmEventHandler();
        public event AlarmEventHandler OnAlarmRaised;
        public void CheckTime(int hour)
        {
            if(hour==7)
            {
                Console.WriteLine("Its 7 AM!");
                OnAlarmRaised();
            }
            else
            {
                Console.WriteLine("Not Time Yet");
            }
        }
    }
}
