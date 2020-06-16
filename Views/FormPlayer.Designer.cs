namespace SmartHome_v1
{
    partial class FormPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlayer));
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.SuspendLayout();
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Dock = System.Windows.Forms.DockStyle.Top;
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(0, 0);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(314, 271);
            this.axVLCPlugin21.TabIndex = 0;
            this.axVLCPlugin21.MediaPlayerEncounteredError += new System.EventHandler(this.AxVLCPlugin21_MediaPlayerEncounteredError);
            this.axVLCPlugin21.MediaPlayerEndReached += new System.EventHandler(this.AxVLCPlugin21_MediaPlayerEndReached);
            this.axVLCPlugin21.MediaPlayerMediaChanged += new System.EventHandler(this.AxVLCPlugin21_MediaPlayerMediaChanged);
            this.axVLCPlugin21.MediaPlayerVout += new AxAXVLC.DVLCEvents_MediaPlayerVoutEventHandler(this.AxVLCPlugin21_MediaPlayerVout);
            this.axVLCPlugin21.DblClick += new System.EventHandler(this.AxVLCPlugin21_DblClick);
            // 
            // FormPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 301);
            this.ControlBox = false;
            this.Controls.Add(this.axVLCPlugin21);
            this.Name = "FormPlayer";
            this.Text = "FormPlayer";
            this.DoubleClick += new System.EventHandler(this.FormPlayer_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
    }
}