using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Time
    {
        public string GetCurrentTime()
        {
            string currTime = DateTime.Now.ToString("HH:mm:ss");
            return currTime;
        }

        public void CompareTime()
        {
            DateTime currTime = Convert.ToDateTime(GetCurrentTime());
            DateTime testTime = Convert.ToDateTime("12:25:03");
            int result = DateTime.Compare(currTime, testTime);
            Console.WriteLine("The result is {0}", result);
        }
    }
}
