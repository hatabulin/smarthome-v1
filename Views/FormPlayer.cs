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
    
    public partial class FormPlayer : Form//, Interface1
    {
        private ListBox listbox;
        private int vlc_volume;
        private Point point;
        private bool fullscreen;
//        Form1 mainForm;

        public FormPlayer()
        {
  //          mainForm = main;
            InitializeComponent();
        }

        public int Volume
        {
            get { return this.vlc_volume; }
            set { }
        }

        public Boolean IsMute
        {
            get { return (axVLCPlugin21.audio.mute); }
        }
        public Boolean IsPlaying
        {
            get { return axVLCPlugin21.playlist.isPlaying; }
        }
        public ListBox SetListBox
        {
            set { this.listbox = value; }
        }

        public bool FullScreen
        {
            set { this.fullscreen = value; }
        }

        public void SetMute()
        {
            axVLCPlugin21.audio.toggleMute();
        }
        public void SetVolume(int vlc_volume)
        {
            this.vlc_volume = vlc_volume;
            axVLCPlugin21.audio.volume = vlc_volume;
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
            if (fullscreen)
            {
                if (axVLCPlugin21.video.fullscreen) axVLCPlugin21.video.toggleFullscreen();
            } else
            {
                if (!axVLCPlugin21.video.fullscreen) axVLCPlugin21.video.toggleFullscreen();
            }

            axVLCPlugin21.playlist.stop();
//            System.Threading.Thread.Sleep(10);
            axVLCPlugin21.playlist.items.clear();
            
            axVLCPlugin21.playlist.add(listbox.Items[listbox.SelectedIndex].ToString());
            if (!axVLCPlugin21.video.fullscreen) axVLCPlugin21.video.toggleFullscreen();
            axVLCPlugin21.playlist.play();
        }

        private void AxVLCPlugin21_MediaPlayerMediaChanged(object sender, EventArgs e)
        {
            axVLCPlugin21.audio.volume = vlc_volume;
            //mainForm.WriteLog("VLC:MediaPlayerMediaChanged");
        }

        private void AxVLCPlugin21_MediaPlayerVout(object sender, AxAXVLC.DVLCEvents_MediaPlayerVoutEvent e)
        {
            axVLCPlugin21.audio.volume = vlc_volume;
        }

        private void AxVLCPlugin21_MediaPlayerEndReached(object sender, EventArgs e)
        {
            //mainForm.WriteLog("VLC:MediaPlayerEndReached");
            axVLCPlugin21.playlist.stop();
            axVLCPlugin21.playlist.play();
        }

        private void FormPlayer_DoubleClick(object sender, EventArgs e)
        {
            Stop();
            Hide();
        }

        private void AxVLCPlugin21_DblClick(object sender, EventArgs e)
        {
            Stop();
            Hide();
        }

        private void AxVLCPlugin21_MediaPlayerEncounteredError(object sender, EventArgs e)
        {
            //mainForm.WriteLog("VLC:MediaPlayerEncounteredError");
            axVLCPlugin21.playlist.stop();
            axVLCPlugin21.playlist.play();
        }

        public void SetPoint(Point point)
        {
            this.point = point;
        }
    }
}
