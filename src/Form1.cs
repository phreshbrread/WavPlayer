using System;
using System.Media;
using System.Windows.Forms;

namespace WavPlayer
{
    public partial class Player : Form
    {
        string fileName;

        public Player()
        {
            InitializeComponent();
        }

        public void ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFile.RestoreDirectory = true;
            OpenFile.FileName = "";
            OpenFile.Title = "Open .wav file";
            OpenFile.Filter = "wav files (*.wav)|*.wav";
            OpenFile.ShowDialog();

            fileName = OpenFile.FileName;
            FilePath.Text = fileName;
        }

        public void PlayButton_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer sound = new SoundPlayer(fileName);
                sound.Play();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("File is corrupt or invalid");
                return;
            }
            catch (ArgumentException)
            {

            }
            
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer sound = new SoundPlayer(fileName);
                sound.Stop();
            }
            catch (ArgumentException)
            {
                
            }
        }
    }
}