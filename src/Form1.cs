using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace WavPlayer
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }

        public void ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFile.InitialDirectory = @"C:\";
            OpenFile.RestoreDirectory = true;
            OpenFile.FileName = "";
            OpenFile.Title = "Open .wav file";
            OpenFile.Filter = "wav files (*.wav)|*.wav";
            OpenFile.ShowDialog();

            string fileName = OpenFile.FileName;

            ChosenFileText.Text = fileName;
        }

        public void PlayButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer();
            sound.Play();
        }
    }
}