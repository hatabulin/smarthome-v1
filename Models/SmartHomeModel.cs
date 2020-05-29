using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome_v1.Models
{
    class SmartHomeModel
    {
        public int vlc_devices_mask { get; set; }
        public byte current_device_status { get; set; }
        public byte sleep_mode_mask { get; set; }
        public byte hot_button_mask { get; set; }
        public byte smarthome_beep_setting { get; set; }
        public SmartHomeModel()
        {

        }
    }
}
