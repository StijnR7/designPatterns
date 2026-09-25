using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            CeilingFan ceilingFan = new CeilingFan("Living Room ceiling fan");
            GarageDoor garageDoor = new GarageDoor(new Light("Garage"));
            Stereo stereo = new Stereo();

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);
            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanLowCommand ceilingFanLow = new CeilingFanLowCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);
            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);
            StereoOnWithCdCommand stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            StereoOnWithDvdCommand stereoOnWithDvd = new StereoOnWithDvdCommand(stereo);
            StereoOnWithRadioCommand stereoOnWithRadio = new StereoOnWithRadioCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            remoteControl.SetCommand(1, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(2, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(3, ceilingFanHigh, ceilingFanOff);
            remoteControl.SetCommand(4, garageDoorUp, garageDoorDown);
            remoteControl.SetCommand(5, stereoOnWithCd, stereoOff);

            Console.WriteLine(remoteControl);

            Console.WriteLine("--- Test all buttons ---");
            for (int i = 0; i < 7; i++)
            {
                remoteControl.OnButtonWasPushed(i);
                remoteControl.OffButtonWasPushed(i);
            }

            Console.WriteLine();
            Console.WriteLine("--- Test undo history (undo everything) ---");
            for (int i = 0; i < 14; i++)
            {
                remoteControl.UndoButtonWasPushed();
            }

            Console.WriteLine();
            Console.WriteLine("--- Test undo with nothing left ---");
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine();
            Console.WriteLine("--- Test ceiling fan speeds and undo ---");
            remoteControl.SetCommand(0, ceilingFanMedium, ceilingFanLow);
            remoteControl.OnButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine();
            Console.WriteLine("--- Test stereo with DVD and radio ---");
            remoteControl.SetCommand(0, stereoOnWithDvd, stereoOff);
            remoteControl.OnButtonWasPushed(0);
            remoteControl.UndoButtonWasPushed();
            remoteControl.SetCommand(0, stereoOnWithRadio, stereoOff);
            remoteControl.OnButtonWasPushed(0);
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine();
            Console.WriteLine("--- Test macro command ---");
            Command[] partyOn = { livingRoomLightOn, stereoOnWithCd, ceilingFanHigh };
            Command[] partyOff = { livingRoomLightOff, stereoOff, ceilingFanOff };
            remoteControl.SetCommand(6, new MacroCommand(partyOn), new MacroCommand(partyOff));
            Console.WriteLine("Party on:");
            remoteControl.OnButtonWasPushed(6);
            Console.WriteLine("Party off:");
            remoteControl.OffButtonWasPushed(6);
            Console.WriteLine("Undo party off:");
            remoteControl.UndoButtonWasPushed();
            Console.WriteLine("Undo party on:");
            remoteControl.UndoButtonWasPushed();
        }
    }
}
