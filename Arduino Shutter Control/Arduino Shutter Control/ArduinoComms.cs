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

        //Variable declaration
        public string CommPort { get; set; }

        static string readData;

        public bool Connected { get; set; }

        public bool SendingMsg { get; set; }

        private SerialPort port = new SerialPort();

        public MotorData[] MotorFeedback = new MotorData[10];

        //Methods
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
                Connected = false;
                return false;
            }
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            var secondNow = DateTime.UtcNow.Second;
            var minuteNow = DateTime.UtcNow.Minute;
            var timespan = 0;
            while ((timespan) < 10)
            {
                if (DateTime.UtcNow.Minute > minuteNow)
                {
                    timespan = DateTime.UtcNow.Second + 60 - secondNow;
                }
                else
                {
                    timespan = DateTime.UtcNow.Second - secondNow;
                }
                if (readData == "Connection Successful")
                {
                    Connected = true;
                    OnArduinoConnected(EventArgs.Empty); //raise event when connection is successful
                    return true;
                }
            }
            Connected = false;
            return false;

        }

        public bool Disconnect()
        {
            try
            {
                port.Write("Disconnect");
                port.Close();
                port.DataReceived -= new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
            catch (Exception ex)
            {
                return false;
            }
            Connected = false;
            OnArduinoDisconnected(EventArgs.Empty); //raise event when disconnection is successful
            return true;
        }

        //Serial event listener
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            var sp =  (SerialPort) sender;
            try
            {
                readData = sp.ReadTo("\r\n");
                if (readData.StartsWith("FB"))
                {
                    ParseFeedback();
                }
            }
            catch (Exception ex)
            { }
           
        }

        //Msg to Arduino to run motor
        public bool RunMotor(int MotorNumber, bool Direction, bool wait)  //Direction = false --> Fwd; Direction = true -->Rev
        {

            if (wait) // wait 20 ms after another message has just been sent to prevent data loss
            {
                var milliSecondNow = DateTime.UtcNow.Millisecond;
                var secondNow = DateTime.UtcNow.Second;
                var timespan = 0;
                while ((timespan) < 20)
                {
                    if (DateTime.UtcNow.Second > secondNow)
                    {
                        timespan = DateTime.UtcNow.Millisecond + 1000 - secondNow;
                    }
                    else
                    {
                        timespan = DateTime.UtcNow.Millisecond - milliSecondNow;
                    }
                }
            }
            SendingMsg = true;
            var msg = "M_" + MotorNumber.ToString() + "_" + Convert.ToInt16(Direction).ToString();
            port.Write(msg);
            return false;
        }

        //Arduino Read Data Motor Feedback
        public bool GetMotorFeedbacks()
        {
            try
            {
                port.Write("GetFeedback");
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        //
        private void ParseFeedback()
        {
            while (readData.Length > 0)
            {
                readData = readData.Remove(0, 2); //Remove FB characters
                var nextFBPos = readData.IndexOf("FB");
                if (nextFBPos < 0)
                {
                    nextFBPos = readData.Length;
                }
                var motorData = readData.Substring(0, nextFBPos);
                string[] motorDataSplit = motorData.Split('_');
                MotorFeedback[Convert.ToInt32(motorDataSplit[1])].MotorNumber = Convert.ToInt32(motorDataSplit[1]);
                MotorFeedback[Convert.ToInt32(motorDataSplit[1])].FwdLimit = Convert.ToBoolean(Convert.ToInt32(motorDataSplit[2]));
                MotorFeedback[Convert.ToInt32(motorDataSplit[1])].RevLimit = Convert.ToBoolean(Convert.ToInt32(motorDataSplit[3]));
                MotorFeedback[Convert.ToInt32(motorDataSplit[1])].FwdCommand = Convert.ToBoolean(Convert.ToInt32(motorDataSplit[4]));
                MotorFeedback[Convert.ToInt32(motorDataSplit[1])].RevCommand = Convert.ToBoolean(Convert.ToInt32(motorDataSplit[5]));
                readData = readData.Remove(0, motorData.Length);
            }
        }

//Events
protected virtual void OnArduinoConnected (EventArgs e)
        {
            EventHandler handler = ArduinoConnected;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnArduinoDisconnected(EventArgs e)
        {
            EventHandler handler = ArduinoDisconnected;
            if (handler != null)
            {
                handler(this, e);
            }
        }


        public event EventHandler ArduinoConnected;
        public event EventHandler ArduinoDisconnected;
    }
}
