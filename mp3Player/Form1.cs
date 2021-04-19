using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;

namespace mp3Player
{
    public partial class Form1 : Form
    {
        string dir = ConfigurationManager.AppSettings["dir"];
        string[] music = null;
        int currentMusic = 0;

        private bool isPause = true;
        IWavePlayer waveOutDevice = new WaveOut();
        AudioFileReader audioFileReader;
        
        TagLib.File file_TAG;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListBox();
            
            //микшер звука
            waveOutDevice.Volume = VolumeTrackBar.Value / 100f;

            timer1.Start();

            //скругление picture box
            IntPtr rgn = CreateEllipticRgn(0, 0, pictureBox1.Width, pictureBox1.Height);
            SetWindowRgn(pictureBox1.Handle, rgn, true);


        }


        //скругление picture box
        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateEllipticRgn(
                            int nLeftRect,
                            int nTopRect,
                            int nRightRect,
                            int nBottomRect);

        //скругление picture box
        [DllImport("user32.dll")]
        public static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            waveOutDevice.Stop();
        }

        private void openFolder_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dir = folderBrowserDialog1.SelectedPath;

                UpdateListBox();

                waveOutDevice.Stop();
                audioFileReader = new AudioFileReader(music[0]);
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();
                currentMusic = 0;

            }
        }
        
        private string[] cutOutNames(string[] music)
        {
            //вырезаем имена
            string[] temp = new string[music.Length];
            for (int i = 0; i < music.Length; i++)
            {
                temp[i] = music[i].Remove(0, music[i].LastIndexOf("\\") + 1);
            }
            return temp;
        }
        private void UpdateListBox()
        {
            try
            {
                //музыку на listbox
               if (Directory.GetFiles(dir, "*.mp3").Length > 1)
                {
                    music = Directory.GetFiles(dir, "*.mp3");
                    listBox1.DataSource = cutOutNames(music);

                    UpdateConfigDir();
                }
                else
                {
                    throw new Exception("Файл mp3 не найден");
                }
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                MessageBox.Show("Выберите папку с музыкой");
                dir = ".\\";
                music = Directory.GetFiles(dir, "*.mp3");
                listBox1.DataSource = cutOutNames(music);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateConfigDir()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["dir"].Value = dir;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void playPauseButton_Click(object sender, EventArgs e)
        {
            isPause = !isPause;
            if(isPause)
                waveOutDevice.Pause();
            else
                waveOutDevice.Play();

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            waveOutDevice?.Stop();
            audioFileReader.Position = 0;
            isPause = true;
        }

        private void VolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            waveOutDevice.Volume = VolumeTrackBar.Value/100f;
        }

        //track bar
        private void currentTimeTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            audioFileReader.CurrentTime = TimeSpan.FromSeconds(currentTimeTrackBar.Value);//изменить текущее время
            timer1.Start();
        }

        private void currentTimeTrackBar_Scroll(object sender, EventArgs e)
        {
            timeLabel.Text = String.Format("{0:d2}", currentTimeTrackBar.Value/60) + "." +
                String.Format("{0:d2}",currentTimeTrackBar.Value%60) + "/" +
                audioFileReader.TotalTime.ToString("mm\\:ss");
        }
        private void currentTimeTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            setTimeLabel();
            currentTimeTrackBar.Value = (int)audioFileReader.CurrentTime.TotalSeconds;
            if(currentTimeTrackBar.Value == currentTimeTrackBar.Maximum)
            {
                UpdateMusic(music[++currentMusic]);
            }
        }

        private void setTimeLabel()
        {
            timeLabel.Text = String.Format("{0:d2}",audioFileReader.CurrentTime.Minutes) + "." +
                String.Format("{0:d2}",audioFileReader.CurrentTime.Seconds) + "/" +
                audioFileReader.TotalTime.ToString("mm\\:ss");
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            currentMusic++;
            isPause = false;
            if(currentMusic > music.Length-1)
            {
                currentMusic = 0;
            }
            listBox1.SelectedIndex = currentMusic;

            string file = music[currentMusic];
            UpdateMusic(file);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            currentMusic--;
            isPause = false;
            if(currentMusic < 0)
            {
                currentMusic = music.Length-1;
            }
            listBox1.SelectedIndex = currentMusic;

            string file = music[currentMusic];
            UpdateMusic(file);
        }

        private void UpdateMusic(string file)
        {
            waveOutDevice.Stop();
            audioFileReader = new AudioFileReader(file);
            waveOutDevice.Init(audioFileReader);
            file_TAG = TagLib.File.Create(file);

            currentTimeTrackBar.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;

            titleLabel.Text = "Title: " + file_TAG.Tag.Title;
            albumLabel.Text = "Album: " + file_TAG.Tag.Album;

            UpdateImage();

            listBox1.SelectedIndex = currentMusic;

            waveOutDevice.Play();
        }
        
        private void UpdateImage()
        {
            if (file_TAG.Tag.Pictures.Length >= 1)
            {
                var bin = (byte[])(file_TAG.Tag.Pictures[0].Data.Data);
                pictureBox1.Image = Image.FromStream(new MemoryStream(bin));
            }
            else
            {
                pictureBox1.Image = Image.FromFile("no_image.jpg");
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMusic = listBox1.SelectedIndex;
            UpdateMusic(music[currentMusic]);
        }
    }
}
