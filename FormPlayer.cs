using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartHome_v1
{
    
    public partial class FormPlayer : Form
    {
        ListBox listbox;
        int vlc_volume;
        Point point;
        bool fullscreen;
        Form1 mainForm = new Form1();

        public FormPlayer()
        {
            InitializeComponent();
        }

        private void FormPlayer_MouseClick(object sender, MouseEventArgs e)
        {

        }
// Getters
        public int getVolume()
        {
            return (this.vlc_volume);
        }
        public Boolean getMute()
        {
            return (axVLCPlugin21.audio.mute);
        }
        public Boolean getVlcState()
        {
            return (axVLCPlugin21.playlist.isPlaying);
        }

        public void toggleMute()
        {
            axVLCPlugin21.audio.toggleMute();
        }
//setters
        public void setListBox(ListBox listbox)
        {
            this.listbox = listbox;
        }
        public void setPoint(Point point)
        {
            this.point= point;
        }
        public void setFullScreen(bool fullscreen)
        {
            this.fullscreen= fullscreen;
        }

        public void setVolume(int vlc_volume)
        {
            this.vlc_volume = vlc_volume;
            axVLCPlugin21.audio.volume = vlc_volume;
        }

        private void FormPlayer_Shown(object sender, EventArgs e)
        {
            
        }

        private void FormPlayer_Activated(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        public void Stop()
        {
            axVLCPlugin21.playlist.stop();
            if (axVLCPlugin21.video.fullscreen) axVLCPlugin21.video.toggleFullscreen();
            axVLCPlugin21.Visible = false;
        }

        public void Play()
        {
            axVLCPlugin21.Visible = true;
            this.Location = point;
            //  axVLCPlugin21.FullscreenEnabled = true;
            if (fullscreen)
            {
                if (axVLCPlugin21.video.fullscreen) axVLCPlugin21.video.toggleFullscreen();
            } else
            {
                if (!axVLCPlugin21.video.fullscreen) axVLCPlugin21.video.toggleFullscreen();
            }

            axVLCPlugin21.playlist.stop();
            System.Threading.Thread.Sleep(10);
            axVLCPlugin21.playlist.items.clear();
            
            axVLCPlugin21.playlist.add(listbox.Items[listbox.SelectedIndex].ToString());
            if (!axVLCPlugin21.video.fullscreen) axVLCPlugin21.video.toggleFullscreen();
            axVLCPlugin21.playlist.play();
        }

        private void axVLCPlugin21_MediaPlayerMediaChanged(object sender, EventArgs e)
        {
            axVLCPlugin21.audio.volume = vlc_volume;
            //mainForm.WriteLog("VLC:MediaPlayerMediaChanged");
        }

        private void axVLCPlugin21_MediaPlayerVout(object sender, AxAXVLC.DVLCEvents_MediaPlayerVoutEvent e)
        {
            axVLCPlugin21.audio.volume = vlc_volume;
        }

        private void axVLCPlugin21_MediaPlayerEndReached(object sender, EventArgs e)
        {
            mainForm.WriteLog("VLC:MediaPlayerEndReached");
            axVLCPlugin21.playlist.stop();
            axVLCPlugin21.playlist.play();
        }

        private void FormPlayer_DoubleClick(object sender, EventArgs e)
        {
            Stop();
            Hide();
        }

        private void axVLCPlugin21_DblClick(object sender, EventArgs e)
        {
            Stop();
            Hide();
        }

        private void axVLCPlugin21_MediaPlayerEncounteredError(object sender, EventArgs e)
        {
            mainForm.WriteLog("VLC:MediaPlayerEncounteredError");
            axVLCPlugin21.playlist.stop();
            axVLCPlugin21.playlist.play();
        }
    }
}
