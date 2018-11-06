using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO.Ports;
using System.Threading;

namespace Arduino_Shutter_Control
{
    public struct MotorData
    {
        public string MotorName;
        public int MotorNumber;
        public bool FwdLimit, RevLimit;
    }

    public partial class Form1 : Form
    {
        string commPort = "";
        int NumberChannelsUsed = 0;
        private ArduinoComms ArduinoControl = new ArduinoComms();
        private System.Windows.Forms.Timer readDataTimer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();

            SetTimer(); //initialise timer

            updateChannelsPanelVisibility();

            ArduinoControl.ArduinoConnected += ArduinoControl_ArduinoConnected; //Event when connected to Arduino
            ArduinoControl.ArduinoDisconnected += ArduinoControl_ArduinoDisconnected; //Event when disconnected from Arduino

            textBox1.Text = "Please select a device from the list and press connect";

            //disable connect and disconnect button when program starts 
            buttonConnect.Enabled = false;
            buttonDisconnect.Enabled = false;

            //Create ListView
            listViewSerialPorts.Sorting = SortOrder.Ascending;
            listViewSerialPorts.View = View.Details;
            listViewSerialPorts.Columns.Add(new ColumnHeader());
            listViewSerialPorts.Columns[0].Text = "Port";
            listViewSerialPorts.Columns[0].Width = 60;
            listViewSerialPorts.Columns.Add(new ColumnHeader());
            listViewSerialPorts.Columns[1].Text = "Description";
            listViewSerialPorts.Columns[1].Width = 210;
            listViewSerialPorts.Columns.Add(new ColumnHeader());
            listViewSerialPorts.Columns[2].Text = "Status";
            listViewSerialPorts.Columns[2].Width = 50;

            // Check for devices connected to serial port
            var items = Actions.CheckForDevices();
            //Add devices to the list
            foreach (var item in items)
            {
                listViewSerialPorts.Items.Add(item);
            }
        }

        private void NumChanneslConfigured_ValueChanged(object sender, EventArgs e)
        {
            NumberChannelsUsed = (int)NumChanneslConfigured.Value;
            updateChannelsPanelVisibility();
        }

        private void updateChannelsPanelVisibility()
        {
            switch (NumberChannelsUsed)
            {
                case 1:
                    panelCh1.Visible = true;
                    panelCh2.Visible = false;
                    panelCh3.Visible = false;
                    panelCh4.Visible = false;
                    panelCh5.Visible = false;
                    break;
                case 2:
                    panelCh1.Visible = true;
                    panelCh2.Visible = true;
                    panelCh3.Visible = false;
                    panelCh4.Visible = false;
                    panelCh5.Visible = false;
                    break;
                case 3:
                    panelCh1.Visible = true;
                    panelCh2.Visible = true;
                    panelCh3.Visible = true;
                    panelCh4.Visible = false;
                    panelCh5.Visible = false;
                    break;
                case 4:
                    panelCh1.Visible = true;
                    panelCh2.Visible = true;
                    panelCh3.Visible = true;
                    panelCh4.Visible = true;
                    panelCh5.Visible = false;
                    break;
                case 5:
                    panelCh1.Visible = true;
                    panelCh2.Visible = true;
                    panelCh3.Visible = true;
                    panelCh4.Visible = true;
                    panelCh5.Visible = true;
                    break;
                default:
                    panelCh1.Visible = false;
                    panelCh2.Visible = false;
                    panelCh3.Visible = false;
                    panelCh4.Visible = false;
                    panelCh5.Visible = false;
                    break;

            }
        }

        void ArduinoControl_ArduinoConnected (object sender, EventArgs e)
        {
            buttonConnect.Enabled = false;
            buttonDisconnect.Enabled = true;
        }

        void ArduinoControl_ArduinoDisconnected(object sender, EventArgs e)
        {
            buttonConnect.Enabled = true;
            buttonDisconnect.Enabled = false;
        }

        private void ListViewSerialPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewSerialPorts.SelectedItems[0].SubItems[0].Text != commPort)
                {
                    buttonConnect.Enabled = true;
                }
            }
            catch (Exception ex)
            { }
        }


        //Refresh the list of devices connected to comm ports
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            listViewSerialPorts.Items.Clear();
            var items = Actions.CheckForDevices();
            foreach (var item in items)
            {
                listViewSerialPorts.Items.Add(item);
            }
        }

        //Connect To Arduino
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Connecting...";
            commPort = listViewSerialPorts.SelectedItems[0].SubItems[0].Text;
            ArduinoControl.CommPort = commPort;
            if (ArduinoControl.Connect())
            {
                textBox1.Text = "Connection Successful";
                readDataTimer.Start();
            }
            else
            {
                textBox1.Text = "Failed to connect";
                readDataTimer.Stop();
            }
        }

        //Disconnect from Arduino
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (ArduinoControl.Disconnect())
            {
                textBox1.Text = "Connection closed successfully";
            }
            else
            {
                textBox1.Text = "Failed to close connection";
            }
            readDataTimer.Stop();
        }

        void SetTimer()
        {
            readDataTimer.Interval = 2000; // faster than this causes communication issues
            readDataTimer.Tick += OnTimerTick;
            readDataTimer.Enabled = true;
        }

        void OnTimerTick(object source, EventArgs e)
        {
            if (ArduinoControl.Connected)
            {
                ArduinoControl.GetMotorFeedbacks();

                //Update object visibility
                UpdateScreenAnimation();

            }
        }

        void UpdateScreenAnimation()
        {
            var i=1;
            for (i = 1; i <= NumberChannelsUsed; i++)
            {
                var panelChannelName = "panelCh" + i.ToString();
                var panelFdbkName = "panelCh" + i.ToString() + "Fdbk";
                var buttonName = "M" + i.ToString() + "FdbkIN";

                var panel1 = Controls[panelChannelName];
                var panel2 = panel1.Controls[panelFdbkName];
                var button = panel2.Controls[buttonName];

                if (ArduinoControl.MotorFeedback[i].FwdLimit)
                {
                    button.BackColor = Color.Green;
                    button.ForeColor = Color.White;
                }
                else
                {
                    button.BackColor = Color.Silver;
                    button.ForeColor = Color.Black;
                }

                buttonName = "M" + i.ToString() + "FdbkOUT";
                button = panel2.Controls[buttonName];
                if (ArduinoControl.MotorFeedback[i].RevLimit)
                {
                    button.BackColor = Color.Green;
                    button.ForeColor = Color.White;
                }
                else
                {
                    button.BackColor = Color.Silver;
                    button.ForeColor = Color.Black;
                }
            }
        }

        //Disconnect port when closing form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            ArduinoControl.Disconnect();
        }
    }
}
