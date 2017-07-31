using Sandbox.DesignPatterns.Command.Slots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.DesignPatterns.Command.Commands
{
    public class StereoOnWithCdCommand : ICommand
    {
        Stereo stereo;

        public StereoOnWithCdCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetCd();
            stereo.SetVolume(11);
        }

        public void Undo()
        {
            stereo.Off();
        }
    }
}
