using Sandbox.DesignPatterns.Command.Commands;
using Sandbox.DesignPatterns.Command.Slots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.DesignPatterns.Command
{
    public class CommandStart
    {
        public void CommandExample()
        {
            RemoteControl remote = new RemoteControl(); // this is the invoker

            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen Room");
            GarageDoor garageDoor = new GarageDoor("");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            CeilingFanOnHighCommand ceilingFanOnHigh = new CeilingFanOnHighCommand(ceilingFan);
            CeilingFanOnMediumCommand ceilingFanOnMedium = new CeilingFanOnMediumCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

            StereoOnWithCdCommand stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remote.SetCommand(2, ceilingFanOnHigh, ceilingFanOnMedium);
            remote.SetCommand(3, stereoOnWithCd, stereoOff);

            Console.WriteLine(remote);

            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);
            remote.UndoButtonWasPushed();
            remote.OnButtonWasPushed(1);
            remote.OffButtonWasPushed(1);
            remote.OnButtonWasPushed(2);
            remote.OffButtonWasPushed(2);
            remote.UndoButtonWasPushed();
            remote.OnButtonWasPushed(3);
            remote.OffButtonWasPushed(3);
            remote.UndoButtonWasPushed();

            Console.ReadLine();
        }

        public void CommandExampleMacros()
        {
            RemoteControl remote = new RemoteControl(); // this is the invoker

            Light livingRoomLight = new Light("Living Room");
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            StereoOnWithCdCommand stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            ICommand[] partyOn = { livingRoomLightOn, stereoOnWithCd };
            ICommand[] partyOff = { livingRoomLightOff, stereoOff };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            remote.SetCommand(0, partyOnMacro, partyOffMacro);

            Console.WriteLine(remote);
            Console.WriteLine("--- Pushing Macro On ---\n");
            remote.OnButtonWasPushed(0);
            Console.WriteLine("--- Pushing Macro Off ---\n");
            remote.OffButtonWasPushed(0);
            Console.WriteLine("--- Pushing Macro Undo ---\n"); // not working for every scenario
            remote.UndoButtonWasPushed();

            Console.ReadLine();
        }

        public void CommandExampleLambdas()
        {
            RemoteControl remote = new RemoteControl(); // this is the invoker

            Light livingRoomLight = new Light("Living Room");

            //remote.SetCommand(0, livingRoomLight.On , () => { livingRoomLight.Off(); });

            Console.WriteLine(remote);
            Console.WriteLine("--- Pushing Macro On ---\n");
            remote.OnButtonWasPushed(0);
            Console.WriteLine("--- Pushing Macro Off ---\n");
            remote.OffButtonWasPushed(0);
            Console.WriteLine("--- Pushing Macro Undo ---\n"); // not working for every scenario
            remote.UndoButtonWasPushed();

            Console.ReadLine();
        }
    }
}
