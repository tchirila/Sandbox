using Sandbox.DesignPatterns.Command.Slots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.DesignPatterns.Command.Commands
{
    public class StereoOnWithRadioCommand : ICommand
    {
        Stereo stereo;

        public StereoOnWithRadioCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetRadio();
            stereo.SetVolume(20);
        }

        public void Undo()
        {
            stereo.Off();
        }
    }
}
