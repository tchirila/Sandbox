using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox.DesignPatterns.Command.Slots
{
    public class Light
    {
        string room;

        public Light(string room)
        {
            this.room = room;
        }

        public void On()
        {
            Console.WriteLine("{0} light is on", room);
        }

        public void Off()
        {
            Console.WriteLine("{0} light is off", room);
        }
    }
}
