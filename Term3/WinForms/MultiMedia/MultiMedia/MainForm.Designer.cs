
namespace MultiMedia
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSysSounds = new System.Windows.Forms.Button();
            this.btnPlayMP3 = new System.Windows.Forms.Button();
            this.windowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnOpenVideo = new System.Windows.Forms.Button();
            this.btnPlayVideo = new System.Windows.Forms.Button();
            this.btnPauseVideo = new System.Windows.Forms.Button();
            this.btnStopVideo = new System.Windows.Forms.Button();
            this.btnFrench = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpen.Location = new System.Drawing.Point(110, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(201, 100);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open Picture";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPlay.Location = new System.Drawing.Point(443, 37);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(124, 100);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStop.Location = new System.Drawing.Point(443, 158);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(124, 100);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSysSounds
            // 
            this.btnSysSounds.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSysSounds.Location = new System.Drawing.Point(443, 279);
            this.btnSysSounds.Name = "btnSysSounds";
            this.btnSysSounds.Size = new System.Drawing.Size(124, 100);
            this.btnSysSounds.TabIndex = 4;
            this.btnSysSounds.Text = "System Sounds";
            this.btnSysSounds.UseVisualStyleBackColor = true;
            this.btnSysSounds.Click += new System.EventHandler(this.btnSysSounds_Click);
            // 
            // btnPlayMP3
            // 
            this.btnPlayMP3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPlayMP3.Location = new System.Drawing.Point(443, 397);
            this.btnPlayMP3.Name = "btnPlayMP3";
            this.btnPlayMP3.Size = new System.Drawing.Size(124, 100);
            this.btnPlayMP3.TabIndex = 5;
            this.btnPlayMP3.Text = "Play MP3";
            this.btnPlayMP3.UseVisualStyleBackColor = true;
            this.btnPlayMP3.Click += new System.EventHandler(this.btnPlayMP3_Click);
            // 
            // windowsMediaPlayer
            // 
            this.windowsMediaPlayer.Enabled = true;
            this.windowsMediaPlayer.Location = new System.Drawing.Point(590, 44);
            this.windowsMediaPlayer.Name = "windowsMediaPlayer";
            this.windowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMediaPlayer.OcxState")));
            this.windowsMediaPlayer.Size = new System.Drawing.Size(472, 324);
            this.windowsMediaPlayer.TabIndex = 6;
            // 
            // btnOpenVideo
            // 
            this.btnOpenVideo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpenVideo.Location = new System.Drawing.Point(621, 374);
            this.btnOpenVideo.Name = "btnOpenVideo";
            this.btnOpenVideo.Size = new System.Drawing.Size(100, 50);
            this.btnOpenVideo.TabIndex = 7;
            this.btnOpenVideo.Text = "Open";
            this.btnOpenVideo.UseVisualStyleBackColor = true;
            this.btnOpenVideo.Click += new System.EventHandler(this.btnOpenVideo_Click);
            // 
            // btnPlayVideo
            // 
            this.btnPlayVideo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPlayVideo.Location = new System.Drawing.Point(726, 374);
            this.btnPlayVideo.Name = "btnPlayVideo";
            this.btnPlayVideo.Size = new System.Drawing.Size(100, 50);
            this.btnPlayVideo.TabIndex = 8;
            this.btnPlayVideo.Text = "Play";
            this.btnPlayVideo.UseVisualStyleBackColor = true;
            this.btnPlayVideo.Click += new System.EventHandler(this.btnPlayVideo_Click);
            // 
            // btnPauseVideo
            // 
            this.btnPauseVideo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPauseVideo.Location = new System.Drawing.Point(832, 374);
            this.btnPauseVideo.Name = "btnPauseVideo";
            this.btnPauseVideo.Size = new System.Drawing.Size(100, 50);
            this.btnPauseVideo.TabIndex = 9;
            this.btnPauseVideo.Text = "Pause";
            this.btnPauseVideo.UseVisualStyleBackColor = true;
            this.btnPauseVideo.Click += new System.EventHandler(this.btnPauseVideo_Click);
            // 
            // btnStopVideo
            // 
            this.btnStopVideo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStopVideo.Location = new System.Drawing.Point(940, 374);
            this.btnStopVideo.Name = "btnStopVideo";
            this.btnStopVideo.Size = new System.Drawing.Size(100, 50);
            this.btnStopVideo.TabIndex = 10;
            this.btnStopVideo.Text = "Stop";
            this.btnStopVideo.UseVisualStyleBackColor = true;
            this.btnStopVideo.Click += new System.EventHandler(this.btnStopVideo_Click);
            // 
            // btnFrench
            // 
            this.btnFrench.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFrench.Location = new System.Drawing.Point(726, 446);
            this.btnFrench.Name = "btnFrench";
            this.btnFrench.Size = new System.Drawing.Size(206, 81);
            this.btnFrench.TabIndex = 11;
            this.btnFrench.Text = "FrVersion";
            this.btnFrench.UseVisualStyleBackColor = true;
            this.btnFrench.Click += new System.EventHandler(this.btnFrench_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox.Location = new System.Drawing.Point(12, 127);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 400);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::MultiMedia.Properties.Resources.ocean_gd41664e8a_1920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.btnFrench);
            this.Controls.Add(this.btnStopVideo);
            this.Controls.Add(this.btnPauseVideo);
            this.Controls.Add(this.btnPlayVideo);
            this.Controls.Add(this.btnOpenVideo);
            this.Controls.Add(this.windowsMediaPlayer);
            this.Controls.Add(this.btnPlayMP3);
            this.Controls.Add(this.btnSysSounds);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnOpen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Multi Media";
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSysSounds;
        private System.Windows.Forms.Button btnPlayMP3;
        private AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer;
        private System.Windows.Forms.Button btnOpenVideo;
        private System.Windows.Forms.Button btnPlayVideo;
        private System.Windows.Forms.Button btnPauseVideo;
        private System.Windows.Forms.Button btnStopVideo;
        private System.Windows.Forms.Button btnFrench;
    }
}

