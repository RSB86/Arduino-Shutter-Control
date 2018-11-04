using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_Shutter_Control
{
    public class Actions
    {
        public static IEnumerable<ListViewItem> CheckForDevices()
        {
            var devicesList = new List<ListViewItem>();
            var device_searcher = new ManagementObjectSearcher("SELECT * FROM Win32_SerialPort");
            foreach (var serial_device in device_searcher.Get())
            {
                var newItem = new ListViewItem(
                    new string[] {serial_device.Properties["DeviceID"].Value.ToString(),
                    serial_device.Properties["Description"].Value.ToString(), serial_device.Properties["Status"].Value.ToString()});
                devicesList.Add(newItem);
            }

            return devicesList;
        }
    }
}
