using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.DesignPatterns.Command.Slots
{
    public class Stereo
    {
        string room;

        public Stereo(string room)
        {
            this.room = room;
        }

        public void On()
        {
            Console.WriteLine("{0} stereo is on", room);
        }

        public void Off()
        {
            Console.WriteLine("{0} stereo is off", room);
        }

        public void SetCd()
        {
            Console.WriteLine("{0} stereo is set to CD input", room);
        }

        public void SetDvd()
        {
            Console.WriteLine("{0} stereo is set to DVD input", room);
        }

        public void SetRadio()
        {
            Console.WriteLine("{0} stereo is set to Radio input", room);
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine("{0} stereo volume is set to {1}", room, volume);
        }
    }
}
