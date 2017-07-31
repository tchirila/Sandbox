using Sandbox.DesignPatterns.Command.Slots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.DesignPatterns.Command.Commands
{
    public class CeilingFanOnMediumCommand : ICommand
    {
        CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanOnMediumCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.OnMedium();
        }

        public void Undo()
        {
            if (prevSpeed == CeilingFan.HIGH)
            {
                ceilingFan.OnHigh();
            }
            else if (prevSpeed == CeilingFan.MEDIUM)
            {
                ceilingFan.OnMedium();
            }
            else if (prevSpeed == CeilingFan.LOW)
            {
                ceilingFan.OnLow();
            }
            else if (prevSpeed == CeilingFan.OFF)
            {
                ceilingFan.Off();
            }           
        }
    }
}
