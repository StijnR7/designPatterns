using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanMediumCommand : Command
    {
        CeilingFan ceilingFan;
        Stack<int> prevSpeeds = new Stack<int>();
        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeeds.Push(ceilingFan.GetSpeed());
            ceilingFan.Medium();
        }

        public void Undo()
        {
            int prevSpeed = prevSpeeds.Pop();
            if (prevSpeed == ceilingFan.HIGH)
            {
                ceilingFan.High();
            }
            else if (prevSpeed == ceilingFan.MEDIUM)
            {
                ceilingFan.Medium();
            }
            else if (prevSpeed == ceilingFan.LOW)
            {
                ceilingFan.Low();
            }
            else
            {
                ceilingFan.Off();
            }
        }
    }
}
