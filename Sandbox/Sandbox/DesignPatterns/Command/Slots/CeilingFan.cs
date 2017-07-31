using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.DesignPatterns.Command.Slots
{
    public class CeilingFan
    {
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;
        string room;
        int speed;

        public CeilingFan(string room)
        {
            this.room = room;
            speed = OFF;
        }

        public void OnHigh()
        {
            speed = HIGH;
            Console.WriteLine("{0} ceiling fan is on high", room);
        }

        public void OnMedium()
        {
            speed = MEDIUM;
            Console.WriteLine("{0} ceiling fan is on medium", room);
        }

        public void OnLow()
        {
            speed = LOW;
            Console.WriteLine("{0} ceiling fan is on low", room);
        }

        public void Off()
        {
            speed = OFF;
            Console.WriteLine("{0} ceiling fan is off", room);
        }

        public int GetSpeed()
        {
            return speed;
        }
    }
}
