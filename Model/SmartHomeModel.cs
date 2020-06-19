using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome_v1.Models
{
    class SmartHomeModel
    {
        public int vlcDevicesMask { get; set; }
        public byte currentDeviceStatus { get; set; }
        public byte sleepModeMask { get; set; }
        public byte hotButtonMask { get; set; }
        public byte smartHomeBeepString { get; set; }
        public SmartHomeModel()
        {

        }
    }
}
