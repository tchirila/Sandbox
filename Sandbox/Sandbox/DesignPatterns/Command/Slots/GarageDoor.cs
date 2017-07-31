using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox.DesignPatterns.Command.Slots
{
    public class GarageDoor
    {
        string room;

        public GarageDoor(string room)
        {
            this.room = room;
        }

        public void Up()
        {
            Console.WriteLine("Garage door is open");
        }

        public void Down()
        {
            Console.WriteLine("Garage door is closed");
        }

        public void Stop()
        {
            Console.WriteLine("Garage door is not moving");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage door light is on");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage door light is off");
        }
    }
}
