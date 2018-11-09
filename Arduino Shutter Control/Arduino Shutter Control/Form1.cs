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
using Newtonsoft.Json;

namespace Arduino_Shutter_Control
{
    public struct MotorData
    {
        public string MotorName;
        public int MotorNumber;
        public bool FwdLimit, RevLimit, FwdCommand, RevCommand;
    }

    public partial class Form1 : Form
    {
        //Class Variables

        string commPort = "";
        int NumberChannelsUsed;
        private ArduinoComms ArduinoControl = new ArduinoComms();
        private System.Windows.Forms.Timer readDataTimer = new System.Windows.Forms.Timer();
        public bool SerialMsgJustSent;
        public int MaxChannelsAvaialble = 5;
        private string ConfigFilePath = @"C:\Users\Public\Documents\ElectricalControls\ShutterControl";
        private ShutterConfiguration SystemConfig;// = new ShutterConfiguration(MaxChannelsAvaialble + 1);

        //Form
        public Form1()
        {
            InitializeComponent();

            CreateDirectory(ConfigFilePath);

            SystemConfig = SystemConfig = new ShutterConfiguration(MaxChannelsAvaialble + 1);

            //Read Config file
            if (ReadConfiguration(ConfigFilePath))
            {
                NumberChannelsUsed = SystemConfig.NumberChannelsConfigured;
            }
            else
            {
                NumberChannelsUsed = 0;
            }

            

            SetTimer(); //initialise timer

            updateChannelsPanelVisibility();

            ArduinoControl.ArduinoConnected += ArduinoControl_ArduinoConnected; //Event when connected to Arduino
            ArduinoControl.ArduinoDisconnected += ArduinoControl_ArduinoDisconnected; //Event when disconnected from Arduino

            textBox1.Text = "Please select a device from the list to connect";

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

        //Panels Visbility
        private void updateChannelsPanelVisibility()
        {
            switch (NumberChannelsUsed)
            {
                case 1:
                    panelCh1.Visible = true;
                    textBoxCh1FwdPosIs.Visible = true;
                    comboBoxCh1.Visible = true;
                    panelCh2.Visible = false;
                    textBoxCh2FwdPosIs.Visible = false;
                    comboBoxCh2.Visible = false;
                    panelCh3.Visible = false;
                    textBoxCh3FwdPosIs.Visible = false;
                    comboBoxCh3.Visible = false;
                    panelCh4.Visible = false;
                    textBoxCh4FwdPosIs.Visible = false;
                    comboBoxCh4.Visible = false;
                    panelCh5.Visible = false;
                    textBoxCh5FwdPosIs.Visible = false;
                    comboBoxCh5.Visible = false;

                    break;
                case 2:
                    panelCh1.Visible = true;
                    textBoxCh1FwdPosIs.Visible = true;
                    comboBoxCh1.Visible = true;
                    panelCh2.Visible = true;
                    textBoxCh2FwdPosIs.Visible = true;
                    comboBoxCh2.Visible = true;
                    panelCh3.Visible = false;
                    textBoxCh3FwdPosIs.Visible = false;
                    comboBoxCh3.Visible = false;
                    panelCh4.Visible = false;
                    textBoxCh4FwdPosIs.Visible = false;
                    comboBoxCh4.Visible = false;
                    panelCh5.Visible = false;
                    textBoxCh5FwdPosIs.Visible = false;
                    comboBoxCh5.Visible = false;
                    break;
                case 3:
                    panelCh1.Visible = true;
                    textBoxCh1FwdPosIs.Visible = true;
                    comboBoxCh1.Visible = true;
                    panelCh2.Visible = true;
                    textBoxCh2FwdPosIs.Visible = true;
                    comboBoxCh2.Visible = true;
                    panelCh3.Visible = true;
                    textBoxCh3FwdPosIs.Visible = true;
                    comboBoxCh3.Visible = true;
                    panelCh4.Visible = false;
                    textBoxCh4FwdPosIs.Visible = false;
                    comboBoxCh4.Visible = false;
                    panelCh5.Visible = false;
                    textBoxCh5FwdPosIs.Visible = false;
                    comboBoxCh5.Visible = false;
                    break;
                case 4:
                    panelCh1.Visible = true;
                    textBoxCh1FwdPosIs.Visible = true;
                    comboBoxCh1.Visible = true;
                    panelCh2.Visible = true;
                    textBoxCh2FwdPosIs.Visible = true;
                    comboBoxCh2.Visible = true;
                    panelCh3.Visible = true;
                    textBoxCh3FwdPosIs.Visible = true;
                    comboBoxCh3.Visible = true;
                    panelCh4.Visible = true;
                    textBoxCh4FwdPosIs.Visible = true;
                    comboBoxCh4.Visible = true;
                    panelCh5.Visible = false;
                    textBoxCh5FwdPosIs.Visible = false;
                    comboBoxCh5.Visible = false;
                    break;
                case 5:
                    panelCh1.Visible = true;
                    textBoxCh1FwdPosIs.Visible = true;
                    comboBoxCh1.Visible = true;
                    panelCh2.Visible = true;
                    textBoxCh2FwdPosIs.Visible = true;
                    comboBoxCh2.Visible = true;
                    panelCh3.Visible = true;
                    textBoxCh3FwdPosIs.Visible = true;
                    comboBoxCh3.Visible = true;
                    panelCh4.Visible = true;
                    textBoxCh4FwdPosIs.Visible = true;
                    comboBoxCh4.Visible = true;
                    panelCh5.Visible = true;
                    textBoxCh5FwdPosIs.Visible = true;
                    comboBoxCh5.Visible = true;
                    break;
                default:
                    panelCh1.Visible = false;
                    textBoxCh1FwdPosIs.Visible = false;
                    comboBoxCh1.Visible = false;
                    panelCh2.Visible = false;
                    textBoxCh2FwdPosIs.Visible = false;
                    comboBoxCh2.Visible = false;
                    panelCh3.Visible = false;
                    textBoxCh3FwdPosIs.Visible = false;
                    comboBoxCh3.Visible = false;
                    panelCh4.Visible = false;
                    textBoxCh4FwdPosIs.Visible = false;
                    comboBoxCh4.Visible = false;
                    panelCh5.Visible = false;
                    textBoxCh5FwdPosIs.Visible = false;
                    comboBoxCh5.Visible = false;
                    break;

            }
            updateSystemConfigData();
        }

        //Arduino Events for Animation
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
        
        
        //Timer Event
        void SetTimer()
        {
            readDataTimer.Interval = 200; // faster than this causes communication issues
            readDataTimer.Tick += OnTimerTick;
            readDataTimer.Enabled = true;
        }

        void OnTimerTick(object source, EventArgs e)
        {
            if (ArduinoControl.Connected & ArduinoControl.SendingMsg == false)
            {
                SerialMsgJustSent = true;
                ArduinoControl.GetMotorFeedbacks();

                //Update object visibility
                UpdateScreenAnimation();

            }
            ArduinoControl.SendingMsg = false;
        }


        //Buttons Animation
        void UpdateScreenAnimation()
        {
            var i=1;
            for (i = 1; i <= NumberChannelsUsed; i++)
            {
                try
                {
                    var panelChannelName = "panelCh" + i.ToString();
                    var panelFdbkName = "panelCh" + i.ToString() + "Fdbk";
                    var buttonName = "M" + i.ToString() + "FdbkIN";

                    var panel1 = Controls[panelChannelName];
                    var panel2 = panel1.Controls[panelFdbkName];

                    var buttonIN = panel2.Controls[buttonName];
                    buttonName = "M" + i.ToString() + "FdbkOUT";
                    var buttonOUT = panel2.Controls[buttonName];

                    panelFdbkName = "panelCh" + i.ToString() + "Cmd";
                    var panel3 = panel1.Controls[panelFdbkName];
                    buttonName = "buttonM" + i.ToString() + "CmdIN";
                    var buttonINCmd = panel3.Controls[buttonName];

                    buttonName = "buttonM" + i.ToString() + "CmdOUT";
                    var buttonOUTCmd = panel3.Controls[buttonName];

                    if (SystemConfig.FwdIsIN[i])
                    {
                        
                        //IN Feedback
                        if (ArduinoControl.MotorFeedback[i].FwdLimit)
                        {
                            buttonIN.BackColor = Color.Green;
                            buttonIN.ForeColor = Color.White;
                        }
                        else
                        {
                            buttonIN.BackColor = Color.Silver;
                            buttonIN.ForeColor = Color.Black;
                        }

                        //OUT Feedback
                        
                        if (ArduinoControl.MotorFeedback[i].RevLimit)
                        {
                            buttonOUT.BackColor = Color.Green;
                            buttonOUT.ForeColor = Color.White;
                        }
                        else
                        {
                            buttonOUT.BackColor = Color.Silver;
                            buttonOUT.ForeColor = Color.Black;
                        }

                        //IN CMD 
                        
                        if (ArduinoControl.MotorFeedback[i].FwdCommand)
                        {
                            buttonINCmd.BackColor = Color.Green;
                            buttonINCmd.ForeColor = Color.White;
                        }
                        else
                        {
                            buttonINCmd.BackColor = Color.Silver;
                            buttonINCmd.ForeColor = Color.Black;
                        }

                        //OUT CMD 
                        
                        if (ArduinoControl.MotorFeedback[i].RevCommand)
                        {
                            buttonOUTCmd.BackColor = Color.Green;
                            buttonOUTCmd.ForeColor = Color.White;
                        }
                        else
                        {
                            buttonOUTCmd.BackColor = Color.Silver;
                            buttonOUTCmd.ForeColor = Color.Black;
                        }
                    }
                    else
                    {
                        //IN Feedback
                        if (ArduinoControl.MotorFeedback[i].RevLimit)
                        {
                            buttonIN.BackColor = Color.Green;
                            buttonIN.ForeColor = Color.White;
                        }
                        else
                        {
                            buttonIN.BackColor = Color.Silver;
                            buttonIN.ForeColor = Color.Black;
                        }

                        //OUT Feedback

                        if (ArduinoControl.MotorFeedback[i].FwdLimit)
                        {
                            buttonOUT.BackColor = Color.Green;
                            buttonOUT.ForeColor = Color.White;
                        }
                        else
                        {
                            buttonOUT.BackColor = Color.Silver;
                            buttonOUT.ForeColor = Color.Black;
                        }

                        //IN CMD 

                        if (ArduinoControl.MotorFeedback[i].RevCommand)
                        {
                            buttonINCmd.BackColor = Color.Green;
                            buttonINCmd.ForeColor = Color.White;
                        }
                        else
                        {
                            buttonINCmd.BackColor = Color.Silver;
                            buttonINCmd.ForeColor = Color.Black;
                        }

                        //OUT CMD 

                        if (ArduinoControl.MotorFeedback[i].FwdCommand)
                        {
                            buttonOUTCmd.BackColor = Color.Green;
                            buttonOUTCmd.ForeColor = Color.White;
                        }
                        else
                        {
                            buttonOUTCmd.BackColor = Color.Silver;
                            buttonOUTCmd.ForeColor = Color.Black;
                        }
                    }
                }
                catch (Exception ex)
                { }
            }
        }

        //Create Saving Directory if it doesn't Exist

        private void CreateDirectory(string Path)
        {
            try
            {
                var file = new System.IO.FileInfo(Path);
                file.Directory.Create();
            }
            catch (Exception ex)
            { }
        }

        //Save and Read Configuration from file

        private bool SaveConfiguration(string ConfigFilePath)
        {
            try
            {

                string json = JsonConvert.SerializeObject(SystemConfig);

                System.IO.File.WriteAllText(ConfigFilePath + "ShutterControl.txt", json);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private bool updateSystemConfigData()
        {
            //Populate Gui
            // Number of channels 
            NumChanneslConfigured.Value = SystemConfig.NumberChannelsConfigured;

            //Channel Names
            var i = 1;
            for (i = 1; i <= NumberChannelsUsed; i++)
            {
                try
                {
                    var panelChannelName = "panelCh" + i.ToString();
                    var textBoxName = "M" + i.ToString() + "Name";

                    var panel = Controls[panelChannelName];
                    panel.Controls[textBoxName].Text = SystemConfig.ChannelName[i];

                    var panelSystem = "panelSystem";
                    var panelConfig = "panelConfig";
                    var comboBoxName = "comboBoxCh" + i.ToString();
                    panel = Controls[panelSystem];
                    var panel2 = panel.Controls[panelConfig];
                    if (SystemConfig.FwdIsIN[i])
                    {
                        panel2.Controls[comboBoxName].Text = "IN";
                    }
                    else
                    {
                        panel2.Controls[comboBoxName].Text = "OUT";
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return true;
        }

        private bool ReadConfiguration(string ConfigFilePath)
        {
            try
            {

                var ConfigString = System.IO.File.ReadAllText(ConfigFilePath + "ShutterControl.txt");
                SystemConfig = JsonConvert.DeserializeObject<ShutterConfiguration>(ConfigString);

                if (updateSystemConfigData())
                { 
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Disconnect port when closing form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            ArduinoControl.Disconnect();
        }

        //Button Event Handler
        private void buttonMCmdIN_Click(object sender, EventArgs e)
        {
            bool direction;
            var button = (Button)sender;
            var buttonName = button.Name;
            var channelString = buttonName.Substring("buttonM".Length, buttonName.IndexOf("Cmd") - "buttonM".Length);
            if (SystemConfig.FwdIsIN[Convert.ToInt32(channelString)])
            {
                direction = false;
            }
            else
            {
                direction = true;
            }
            SerialMsgJustSent = ArduinoControl.RunMotor(Convert.ToInt32(channelString), direction, SerialMsgJustSent);
        }

        private void buttonMCmdOUT_Click(object sender, EventArgs e)
        {
            bool direction;
            var button = (Button)sender;
            var buttonName = button.Name;
            var channelString = buttonName.Substring("buttonM".Length, buttonName.IndexOf("Cmd") - "buttonM".Length);
            if (SystemConfig.FwdIsIN[Convert.ToInt32(channelString)])
            {
                direction = true;
            }
            else
            {
                direction = false;
            }
            SerialMsgJustSent = ArduinoControl.RunMotor(Convert.ToInt32(channelString), direction, SerialMsgJustSent);
        }

        //Update Configuration Status Text Box

        private void TextBoxConfigurationStatusUpdate (bool result)
        {
            if (result)
            {
                TextBoxConfigStatus.Text = "Configuration Saved - " + System.DateTime.UtcNow.ToShortDateString() + " " + System.DateTime.UtcNow.ToShortTimeString();
            }
            else
            {
                TextBoxConfigStatus.Text = "Fail to save Config. - " + System.DateTime.UtcNow.ToShortDateString() + " " + System.DateTime.UtcNow.ToShortTimeString();
            }
        }

        //Numeric channels selector event hanlder
        private void NumChanneslConfigured_ValueChanged(object sender, EventArgs e)
        {
            NumberChannelsUsed = (int)NumChanneslConfigured.Value;
            SystemConfig.NumberChannelsConfigured = NumberChannelsUsed;
            updateChannelsPanelVisibility();
            TextBoxConfigurationStatusUpdate(SaveConfiguration(ConfigFilePath));
        }

        //ComboBox Event Handler
        private void comboBoxCh_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            var comboBoxName = comboBox.Name;
            var channelString = comboBoxName.Substring("comboBoxCh".Length);
            var value = comboBox.SelectedItem.ToString();
            if (value == "IN")
            {
                SystemConfig.FwdIsIN[Convert.ToInt32(channelString)] = true;
            }
            else
            {
                SystemConfig.FwdIsIN[Convert.ToInt32(channelString)] = false;
            }
            TextBoxConfigurationStatusUpdate(SaveConfiguration(ConfigFilePath));
        }

        private void MotorName_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            var textBoxName = textBox.Name;
            var channelString = textBoxName.Substring(1,textBoxName.IndexOf("Name")-1);
            SystemConfig.ChannelName[Convert.ToInt32(channelString)] = textBox.Text;
            TextBoxConfigurationStatusUpdate(SaveConfiguration(ConfigFilePath));
        }
    }
}
