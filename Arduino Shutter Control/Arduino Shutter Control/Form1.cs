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
        public bool FwdLimit, RevLimit, FwdCommand, RevCommand, InPosition, OutPosition;
    }

    public partial class Form1 : Form
    {
        //Class Variables

        string commPort = "";
        int NumberChannelsUsed;
        private ArduinoComms ArduinoControl = new ArduinoComms();
        private System.Windows.Forms.Timer readDataTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer[] ChannelReturnTimer;
        public bool SerialMsgJustSent;
        public int MaxChannelsAvaialble = 5;
        private string ConfigFilePath = @"C:\Users\Public\Documents\ElectricalControls\ShutterControl";
        private ShutterConfiguration SystemConfig;

        //Form
        public Form1()
        {
            InitializeComponent();

            CreateDirectory(ConfigFilePath);

            SystemConfig = new ShutterConfiguration(MaxChannelsAvaialble + 1);

            //Read Config file
            if (ReadConfiguration(ConfigFilePath))
            {
                NumberChannelsUsed = SystemConfig.NumberChannelsConfigured;
            }
            else
            {
                NumberChannelsUsed = 0;
            }

            

            SetTimers(); //initialise timer

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
                    panelCh1Config.Visible = true;
                    panelCh2.Visible = false;
                    panelCh2Config.Visible = false;
                    panelCh3.Visible = false;
                    panelCh3Config.Visible = false;
                    panelCh4.Visible = false;
                    panelCh4Config.Visible = false;
                    panelCh5.Visible = false;
                    panelCh5Config.Visible = false;

                    break;
                case 2:
                    panelCh1.Visible = true;
                    panelCh1Config.Visible = true;
                    panelCh2.Visible = true;
                    panelCh2Config.Visible = true;
                    panelCh3.Visible = false;
                    panelCh3Config.Visible = false;
                    panelCh4.Visible = false;
                    panelCh4Config.Visible = false;
                    panelCh5.Visible = false;
                    panelCh5Config.Visible = false;
                    break;
                case 3:
                    panelCh1.Visible = true;
                    panelCh1Config.Visible = true;
                    panelCh2.Visible = true;
                    panelCh2Config.Visible = true;
                    panelCh3.Visible = true;
                    panelCh3Config.Visible = true;
                    panelCh4.Visible = false;
                    panelCh4Config.Visible = false;
                    panelCh5.Visible = false;
                    panelCh5Config.Visible = false;
                    break;
                case 4:
                    panelCh1.Visible = true;
                    panelCh1Config.Visible = true;
                    panelCh2.Visible = true;
                    panelCh2Config.Visible = true;
                    panelCh3.Visible = true;
                    panelCh3Config.Visible = true;
                    panelCh4.Visible = true;
                    panelCh4Config.Visible = true;
                    panelCh5.Visible = false;
                    panelCh5Config.Visible = false;
                    break;
                case 5:
                    panelCh1.Visible = true;
                    panelCh1Config.Visible = true;
                    panelCh2.Visible = true;
                    panelCh2Config.Visible = true;
                    panelCh3.Visible = true;
                    panelCh3Config.Visible = true;
                    panelCh4.Visible = true;
                    panelCh4Config.Visible = true;
                    panelCh5.Visible = true;
                    panelCh5Config.Visible = true;
                    break;
                default:
                    panelCh1.Visible = true;
                    panelCh1Config.Visible = false;
                    panelCh2.Visible = false;
                    panelCh2Config.Visible = false;
                    panelCh3.Visible = false;
                    panelCh3Config.Visible = false;
                    panelCh4.Visible = false;
                    panelCh4Config.Visible = false;
                    panelCh5.Visible = false;
                    panelCh5Config.Visible = false;
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
        void SetTimers()
        {
            readDataTimer.Interval = 200; 
            readDataTimer.Tick += OnTimerTick;
            readDataTimer.Enabled = true;
            
            //Return Timers    
            ChannelReturnTimer = new System.Windows.Forms.Timer[MaxChannelsAvaialble];
            for (var i=0;i<MaxChannelsAvaialble;i++)
            {
                ChannelReturnTimer[i] = new System.Windows.Forms.Timer();
                ChannelReturnTimer[i].Enabled = true;
                ChannelReturnTimer[i].Tick += OnReturnTimerTick;
                ChannelReturnTimer[i].Tag = i;
                try //Timer preset cannot be zero
                {
                    ChannelReturnTimer[i].Interval = (int)SystemConfig.TimerPreset[i];
                }
                catch (Exception ex)
                {
                    ChannelReturnTimer[i].Interval = 1;
                }
                ChannelReturnTimer[i].Stop();
            }
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

        void OnReturnTimerTick (object source, EventArgs e)
        {
            var timer = (System.Windows.Forms.Timer)source;

            if (!SystemConfig.TimerTriggerPosition[Convert.ToInt16(timer.Tag)])
            {
                ArduinoControl.RunMotor(Convert.ToInt16(timer.Tag), true, SerialMsgJustSent);
            }
            else
            {
                ArduinoControl.RunMotor(Convert.ToInt16(timer.Tag), false, SerialMsgJustSent);
            }
            ChannelReturnTimer[Convert.ToInt16(timer.Tag)].Stop();

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
                            ArduinoControl.MotorFeedback[i].InPosition = true;
                        }
                        else
                        {
                            buttonIN.BackColor = Color.Silver;
                            buttonIN.ForeColor = Color.Black;
                            ArduinoControl.MotorFeedback[i].InPosition = false;
                        }

                        //OUT Feedback
                        
                        if (ArduinoControl.MotorFeedback[i].RevLimit)
                        {
                            buttonOUT.BackColor = Color.Green;
                            buttonOUT.ForeColor = Color.White;
                            ArduinoControl.MotorFeedback[i].OutPosition = true;
                        }
                        else
                        {
                            buttonOUT.BackColor = Color.Silver;
                            buttonOUT.ForeColor = Color.Black;
                            ArduinoControl.MotorFeedback[i].OutPosition = false;
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
                            ArduinoControl.MotorFeedback[i].InPosition = true;
                        }
                        else
                        {
                            buttonIN.BackColor = Color.Silver;
                            buttonIN.ForeColor = Color.Black;
                            ArduinoControl.MotorFeedback[i].InPosition = false;
                        }

                        //OUT Feedback

                        if (ArduinoControl.MotorFeedback[i].FwdLimit)
                        {
                            buttonOUT.BackColor = Color.Green;
                            buttonOUT.ForeColor = Color.White;
                            ArduinoControl.MotorFeedback[i].OutPosition = true;
                        }
                        else
                        {
                            buttonOUT.BackColor = Color.Silver;
                            buttonOUT.ForeColor = Color.Black;
                            ArduinoControl.MotorFeedback[i].OutPosition = false;
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

                    if (SystemConfig.Enable_AutoRun_Timer[i]) // if auto return timer is enabled then check if we can start timer
                    {
                        if ((SystemConfig.TimerTriggerPosition[i] && ArduinoControl.MotorFeedback[i].InPosition) || (!SystemConfig.TimerTriggerPosition[i] && ArduinoControl.MotorFeedback[i].OutPosition)) // Start timer condition
                        {
                            if (!ChannelReturnTimer[i].Enabled) // Start the timer if it is not running
                            {
                                ChannelReturnTimer[i].Interval = (int)SystemConfig.TimerPreset[i]*1000;
                                ChannelReturnTimer[i].Start();
                            }
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

            //Channel Data
            var i = 1;
            for (i = 1; i <= NumberChannelsUsed; i++)
            {
                try
                {
                    // Channel Names
                    var panelChannelName = "panelCh" + i.ToString();
                    var textBoxName = "M" + i.ToString() + "Name";

                    //Channel Fwd Is IN/OUT
                    var panel = Controls[panelChannelName];
                    panel.Controls[textBoxName].Text = SystemConfig.ChannelName[i];

                    var panelSystem = "panelSystem";
                    var panelConfig = "panelConfig";
                    var panelChConfig = "panelCh" + i.ToString() + "Config";
                    var comboBoxName = "comboBoxCh" + i.ToString();
                    panel = Controls[panelSystem];
                    var panel2 = panel.Controls[panelConfig];
                    panel2 = panel2.Controls[panelChConfig];
                    if (SystemConfig.FwdIsIN[i])
                    {
                        panel2.Controls[comboBoxName].Text = "IN";
                    }
                    else
                    {
                        panel2.Controls[comboBoxName].Text = "OUT";
                    }

                    //Channel Timer Enabled
                    var checkBoxName = "checkBoxCh" + i.ToString() + "EnableTimer";
                    var checkBox = (CheckBox)panel2.Controls[checkBoxName];
                    if (SystemConfig.Enable_AutoRun_Timer[i])
                    {
                        checkBox.Checked = true;
                    }
                    else
                    {
                        checkBox.Checked = false;
                    }

                    //Channel Timer Preset

                    var numericInputName = "numericUpDownCh" + i.ToString() +"TimerPreset";
                    var numericInput = (NumericUpDown)panel2.Controls[numericInputName];
                    numericInput.Value = SystemConfig.TimerPreset[i];


                    // Trigger On
                    comboBoxName = "comboBoxCh" + i.ToString() + "ReturnPositionTrigger";
                    panel = Controls[panelSystem];
                    if (SystemConfig.TimerTriggerPosition[i])
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
                TextBoxConfigStatus.Text = "Last Saved - " + System.DateTime.UtcNow.ToShortDateString() + " " + System.DateTime.UtcNow.ToShortTimeString();
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

        //ComboBox FWD is IN Event Handler
        private void comboBoxChFwdIsIn_SelectedIndexChanged(object sender, EventArgs e)
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


        // Motor Name Changed Event Handler
        private void MotorName_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            var textBoxName = textBox.Name;
            var channelString = textBoxName.Substring(1,textBoxName.IndexOf("Name")-1);
            SystemConfig.ChannelName[Convert.ToInt32(channelString)] = textBox.Text;
            TextBoxConfigurationStatusUpdate(SaveConfiguration(ConfigFilePath));
        }


        //Enable Timer Checkbox Event Handler
        private void checkBoxChEnableTimer_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            var checkBoxName = checkBox.Name;
            var channelString = checkBoxName.Substring("checkBoxCh".Length,checkBoxName.IndexOf("EnableTimer")-"checkBoxCh".Length);
            SystemConfig.Enable_AutoRun_Timer[Convert.ToInt32(channelString)] = checkBox.Checked;
            TextBoxConfigurationStatusUpdate(SaveConfiguration(ConfigFilePath));
        }

        //Timer Preset Numeric Input Event Handler
        private void numericUpDownChTimerPreset_ValueChanged(object sender, EventArgs e)
        {
            var numericInput= (NumericUpDown)sender;
            var numericInputName = numericInput.Name;
            var channelString = numericInputName.Substring("numericUpDownCh".Length, numericInputName.IndexOf("TimerPreset") - "numericUpDownCh".Length); 
            SystemConfig.TimerPreset[Convert.ToInt32(channelString)] = numericInput.Value;
            TextBoxConfigurationStatusUpdate(SaveConfiguration(ConfigFilePath));
        }

        //Timer Trigger on In/OUT Event Handler
        private void comboBoxChReturnPositionTrigger_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            var comboBoxName = comboBox.Name;
            var channelString = comboBoxName.Substring("comboBoxCh".Length, comboBoxName.IndexOf("ReturnPositionTrigger") - "comboBoxCh".Length);
            var value = comboBox.SelectedItem.ToString();
            if (value == "IN")
            {
                SystemConfig.TimerTriggerPosition[Convert.ToInt32(channelString)] = true;
            }
            else
            {
                SystemConfig.TimerTriggerPosition[Convert.ToInt32(channelString)] = false;
            }
            TextBoxConfigurationStatusUpdate(SaveConfiguration(ConfigFilePath));
        }

        

    }
}
