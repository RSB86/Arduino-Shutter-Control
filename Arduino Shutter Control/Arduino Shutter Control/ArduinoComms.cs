using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Arduino_Shutter_Control
{
    public class ArduinoComms
    {
        public String CommPort { get; set; }

        static String readData;

        private SerialPort port = new SerialPort();

        public int Connect()
        {
            port.PortName = CommPort;
            port.BaudRate = 57600;
            port.Parity = Parity.None;
            port.StopBits = StopBits.One;

            try
            {
                port.Open();
                port.Write("Connect");
            }
            catch (Exception ex)
            {
                port.Close();
                return -1;
            }
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            var timeNow = DateTime.UtcNow.Second;
            while (((DateTime.UtcNow.Second - timeNow) < 2))
            {
                if(readData == "Connection Successful")
                {
                    return 1;
                }
            }
            return -1;

        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            readData = sp.ReadExisting();
            switch (readData)
            {
                case "M1LeftLow":
                    break;

            }
            sp.DiscardInBuffer();
        }

        public void M1Left()
        {
            port.Write("M1_Left");
        }
        public void M1Right()
        {
            port.Write("M1_Right");
        }
    }
}
