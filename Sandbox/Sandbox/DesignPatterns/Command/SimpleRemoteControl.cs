using Sandbox.DesignPatterns.Command.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.DesignPatterns.Command
{
    public class SimpleRemoteControl
    {
        ICommand slot; // this is the receiver?

        public SimpleRemoteControl()
        {

        }

        public void SetCommand(ICommand command)
        {
            slot = command;
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}
