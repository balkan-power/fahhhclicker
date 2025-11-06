using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Vorbis;

namespace FAHHHHHclicker
{
    public partial class Form1 : Form
    {
        int amount = 0;
        WaveOutEvent outputDevice;
        VorbisWaveReader backgroundMusic;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MusicLoop();
        }

        private void MusicLoop()
        {
            backgroundMusic = new VorbisWaveReader("C:\\Users\\dimit\\source\\repos\\FAHHHHHclicker\\FAHHHHHclicker\\clankertypebeat.ogg");
            var loop = new LoopStream(backgroundMusic); // custom helper to loop
            outputDevice = new WaveOutEvent();
            outputDevice.Init(loop);
            outputDevice.Play();
        }

        private void ClickyButton_Click(object sender, EventArgs e)
        {
            amount++;
            putsAmount.Text = amount.ToString();
            PlayFah();
        }

        private void PlayFah()
        {
            var audioFile = new VorbisWaveReader("C:\\Users\\dimit\\source\\repos\\FAHHHHHclicker\\FAHHHHHclicker\\fahhh.ogg");
            var outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);
            outputDevice.Play();
        }

        // helper class to loop audio
        public class LoopStream : WaveStream
    {
        private readonly WaveStream sourceStream;

        public LoopStream(WaveStream source)
        {
            this.sourceStream = source;
            this.EnableLooping = true;
        }

        public bool EnableLooping { get; set; }

        public override WaveFormat WaveFormat => sourceStream.WaveFormat;
        public override long Length => sourceStream.Length;
        public override long Position
        {
            get => sourceStream.Position;
            set => sourceStream.Position = value;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            int totalBytesRead = 0;

            while (totalBytesRead < count)
            {
                int bytesRead = sourceStream.Read(buffer, offset + totalBytesRead, count - totalBytesRead);
                if (bytesRead == 0)
                {
                    if (sourceStream.Position == 0 || !EnableLooping)
                        break;

                    sourceStream.Position = 0;
                }
                totalBytesRead += bytesRead;
            }

            return totalBytesRead;
        }
    }
    }
}
