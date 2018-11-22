using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arduino_Shutter_Control
{
    public struct MotorData
    {
        public string MotorName;
        public int MotorNumber;
        public bool FwdLimit, RevLimit, FwdCommand, RevCommand, InPosition, OutPosition;
    }

    public struct MotorCommand
    {
        public int MotorNumber;
        public bool MotorDirection;
    }
}
