using Sandbox.DesignPatterns.Command.Slots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.DesignPatterns.Command.Commands
{
    public class StereoOnWithDvdCommand : ICommand
    {
        Stereo stereo;

        public StereoOnWithDvdCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetDvd();
            stereo.SetVolume(10);
        }

        public void Undo()
        {
            stereo.Off();
        }
    }
}
