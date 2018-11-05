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
        public string CommPort { get; set; }

        static string readData;

        public bool Connected { get; set; }

        private SerialPort port = new SerialPort();

        public bool Connect()
        {
            try
            {
                port.PortName = CommPort;
                port.BaudRate = 57600;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
            
                port.Open();
                port.Write("Connect");
            }
            catch (Exception ex)
            {
                port.Close();
                Connected = true;
                return false;
            }
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            var timeNow = DateTime.UtcNow.Second;
            while ((DateTime.UtcNow.Second - timeNow) < 10)
            {
                if (readData == "Connection Successful")
                {
                    Connected = true;
                    OnArduinoConnected(EventArgs.Empty);
                    return true;
                }
            }
            Connected = false;
            return false;

        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            var sp = (SerialPort) sender;
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

        protected virtual void OnArduinoConnected (EventArgs e)
        {
            EventHandler handler = ArduinoConnected;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler ArduinoConnected;
    }
}
