using Sandbox.DesignPatterns.Command.Slots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.DesignPatterns.Command.Commands
{
    public class LightOnCommand : ICommand
    {
        Light light; // when 'this' is used, it refers to the variable declared in this class <-

        public LightOnCommand(Light light)
        {
            this.light = light; // 'this' is used when both variables have the same name.
        }

        public void Execute()
        {
            light.On();
        }

        public void Undo()
        {
            light.Off();
        }
    }
}
