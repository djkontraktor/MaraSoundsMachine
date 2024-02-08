using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.Multimedia;
using SharpDX.XAudio2;

namespace MaraSoundsMachine
{
    public partial class MainForm : Form
    {

        static XAudio2 device = new XAudio2();
        static MasteringVoice thisMasteringVoice = new MasteringVoice(device);
        static bool audioBufferBusy = false;

        public MainForm()
        {
            InitializeComponent();
            ResizeTabControl();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainFormResized(object sender, EventArgs e)
        {
            ResizeTabControl();
        }

        private void StartPlayWave(WaveName waveFile, float volume, float pan)
        {
            audioBufferBusy = false;

            string filePath = GetWaveFilePath(waveFile);

            SoundStream stream = new SoundStream(File.OpenRead(filePath));

            WaveFormat waveFormat = stream.Format;

            audioBufferBusy = true;

            AudioBuffer buffer = new AudioBuffer
            {
                Stream = stream.ToDataStream(),
                AudioBytes = (int)stream.Length,
                Flags = BufferFlags.EndOfStream
            };

            stream.Close();

            var sourceVoice = new SourceVoice(device, waveFormat, true);        

            // Adds a sample callback to check that they are working on source voices
            sourceVoice.BufferEnd += (context) => audioBufferBusy = false;
            sourceVoice.SubmitSourceBuffer(buffer, stream.DecodedPacketsInfo);

            sourceVoice.SetVolume(volume);

            sourceVoice.Start();

            // Stop sound
            //sourceVoice.DestroyVoice();
            //sourceVoice.Dispose();
            //buffer.Stream.Dispose();
        }

        public static bool IsKeyPressed(ConsoleKey key)
        {
            return Console.KeyAvailable && Console.ReadKey(true).Key == key;
        }

        private void ResizeTabControl()
        {
            soundPanel_tabControl.Size = new Size(this.Size.Width - 50, this.Size.Height - 70);
        }

        private void testButtonClick(object sender, EventArgs e)
        {
            StartPlayWave(WaveName.Loon0, 1, 0);
        }

        private void addSoundSource_buttonClick(object sender, EventArgs e)
        {
            soundPanel_tabControl.TabPages.Add("Water");
        }

        private void removeSoundSource_buttonClick(object sender, EventArgs e)
        {
            if (soundPanel_tabControl.TabPages.Count > 1)
            {
                soundPanel_tabControl.TabPages.RemoveAt(soundPanel_tabControl.TabPages.Count - 1);
            }
        }

        private void panning_mouseRelease(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                panControl_trackBar.Value = 0;
            }
        }
    }
}
