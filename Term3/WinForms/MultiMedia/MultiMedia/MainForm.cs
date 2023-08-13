using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MultiMedia
{
    public partial class MainForm : Form
    {
        SoundPlayer audio = new SoundPlayer();
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        
        public MainForm()
        {
            InitializeComponent();
            windowsMediaPlayer.uiMode = "none";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //pictureBox.ImageLocation = "C:/Users/rolux/OneDrive/Pictures/ocean-gd41664e8a_1920.jpg";
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                pictureBox.Image = img;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Audio|*.wav";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                audio = new SoundPlayer(ofd.FileName);
                audio.Play();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            audio.Stop();
            wmp.controls.stop();
        }

        private void btnSysSounds_Click(object sender, EventArgs e)
        {
            SystemSounds.Hand.Play();
        }

        private void btnPlayMP3_Click(object sender, EventArgs e)
        {
            wmp.URL = "TestingMusic.mp3";
            wmp.controls.play();
        }

        private void btnOpenVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdVideo = new OpenFileDialog();
            ofdVideo.Title = "Open Video";
            ofdVideo.Filter = "All Files |*.*| Video |*.mp4";
            ofdVideo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (ofdVideo.ShowDialog() == DialogResult.OK)
            {
                string videoPath = ofdVideo.FileName;
                windowsMediaPlayer.URL = videoPath;
            }
        }

        private void btnPlayVideo_Click(object sender, EventArgs e)
        {
            windowsMediaPlayer.Ctlcontrols.play();
        }

        private void btnPauseVideo_Click(object sender, EventArgs e)
        {
            windowsMediaPlayer.Ctlcontrols.pause();
        }

        private void btnStopVideo_Click(object sender, EventArgs e)
        {
            windowsMediaPlayer.Ctlcontrols.stop();
        }

        private void btnFrench_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr");
            //MessageBox.Show(FrenchVersion.MessageTextBox);
            btnOpen.Text = FrenchVersion.OpenPicture;
            btnPlay.Text = FrenchVersion.Play;
            btnStop.Text = FrenchVersion.Stop;
            btnSysSounds.Text = FrenchVersion.SystemSounds;
            btnPlayMP3.Text = FrenchVersion.PlayMP3;
            btnOpenVideo.Text = FrenchVersion.OpenVideo;
            btnPlayVideo.Text = FrenchVersion.Play;
            btnStopVideo.Text = FrenchVersion.Stop;
        }
    }
}
