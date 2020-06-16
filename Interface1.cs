using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome_v1
{
    interface IVlcInterface
    {
        void SetListBox(ListBox listbox);
        void SetPoint(Point point);
        void SetFullScreen(bool fullscreen);
        void Play();
//        void getVolume();

//        delegate void VlcHandler(int volume);
//        event VlcHandler Notify;
    }
}
