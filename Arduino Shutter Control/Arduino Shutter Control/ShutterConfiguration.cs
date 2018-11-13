using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Arduino_Shutter_Control
{
    class ShutterConfiguration
    {
        public int NumberChannelsConfigured { get; set; }
        public bool[] FwdIsIN { get; set; }
        public string[] ChannelName { get; set; }
        public bool[] Enable_AutoRun_Timer { get; set; }
        public decimal[] TimerPreset { get; set; }
        public bool[] TimerTriggerPosition { get; set; }

        public ShutterConfiguration(int maxChannelNumbers)
        {
            FwdIsIN = new bool[maxChannelNumbers];
            ChannelName = new string[maxChannelNumbers];
            Enable_AutoRun_Timer = new bool[maxChannelNumbers];
            TimerPreset = new decimal[maxChannelNumbers];
            TimerTriggerPosition = new bool[maxChannelNumbers];
        }
    }
}
