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

namespace Arduino_Shutter_Control
{
    public partial class Form1 : Form
    {
        string commPort = "";
        private ArduinoComms ArduinoControl = new ArduinoComms();

        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "Please select a device from the list and press connect";

            //disable connect button when program starts
            buttonConnect.Enabled = false;

            //Create ListView
            listViewSerialPorts.Sorting = SortOrder.Ascending;
            listViewSerialPorts.View = View.Details;
            listViewSerialPorts.Columns.Add(new ColumnHeader());
            listViewSerialPorts.Columns[0].Text = "Port";
            listViewSerialPorts.Columns[0].Width = 75;
            listViewSerialPorts.Columns.Add(new ColumnHeader());
            listViewSerialPorts.Columns[1].Text = "Description";
            listViewSerialPorts.Columns[1].Width = 200;
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


        private void ListViewSerialPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonConnect.Enabled = true;          
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

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            commPort = listViewSerialPorts.SelectedItems[0].SubItems[0].Text;
            ArduinoControl.CommPort = commPort;
            if (ArduinoControl.Connect())
            {
                textBox1.Text = "Connection Successful";
            }
            else
            {
                textBox1.Text = "Failed to connect";
            }
            //var port = new SerialPort(commPort, 57600, Parity.None, 8, StopBits.One);
            //try
            //{
            //    port.Close();
            //    port.Open();
            //    port.Write("Connect");
            //}
            //catch (Exception ex)
            //{
            //    textBox1.Text = "Connection Failed";
            //}
            //finally
            //{
            //    port.Close();
            //}
        }

        private void buttonM1Left_Click(object sender, EventArgs e)
        {
            ArduinoControl.M1Left();
        }

        private void buttonM1Right_Click(object sender, EventArgs e)
        {
            ArduinoControl.M1Right();
        }
    }
}
