﻿using Sandbox.DesignPatterns.Command.Slots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.DesignPatterns.Command.Commands
{
    public class LightOffCommand : ICommand
    {
        Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }

        public void Undo()
        {
            light.On();
        }
    }
}
