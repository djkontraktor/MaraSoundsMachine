using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX;
using SharpDX.DirectSound;
using SharpDX.Multimedia;

namespace MaraSoundsMachine
{
    public partial class MainForm : Form
    {
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

        private void PlayWave(Wave sample, bool looping)
        {
            DirectSound directSound = new DirectSound();

            // Set Cooperative Level to PRIORITY (priority level can call the SetFormat and Compact methods)
            directSound.SetCooperativeLevel(this.Handle, CooperativeLevel.Priority);
            
            WaveFormat waveFormat = new WaveFormat();

            SoundBufferDescription primaryBufferDescription = new SoundBufferDescription();

            primaryBufferDescription.BufferBytes = waveFormat.ConvertLatencyToByteSize(60000);

            // Default WaveFormat Stereo 44100 kHz 16 bit
            primaryBufferDescription.Format = waveFormat;

            primaryBufferDescription.Flags = BufferFlags.GetCurrentPosition2 |
                BufferFlags.ControlPositionNotify |
                BufferFlags.GlobalFocus |
                BufferFlags.ControlVolume |
                BufferFlags.StickyFocus;

            primaryBufferDescription.AlgorithmFor3D = Guid.Empty;

            SecondarySoundBuffer primarySoundBuffer = new SecondarySoundBuffer(directSound, primaryBufferDescription);

            BufferCapabilities capabilities = primarySoundBuffer.Capabilities;

            DataStream dataPart2;

            DataStream dataPart1 = primarySoundBuffer.Lock(0, capabilities.BufferBytes, LockFlags.EntireBuffer, out dataPart2);

            int numberOfSamples = capabilities.BufferBytes / waveFormat.BlockAlign;

            for (int i = 0; i < numberOfSamples; i++)
            {
                short value = (short)sample.WaveStream.ReadByte();
                dataPart1.Write(value);
                dataPart1.Write(value);
            }

            primarySoundBuffer.Unlock(dataPart1, dataPart2);

            PlayFlags isLooping = (looping) ? PlayFlags.Looping : PlayFlags.None;

            primarySoundBuffer.Play(0, isLooping);
        }

        private void ResizeTabControl()
        {
            soundPanel_tabControl.Size = new Size(this.Size.Width - 50, this.Size.Height - 70);
        }

        private void testButtonClick(object sender, EventArgs e)
        {
            Wave testSample = new Wave(WaveName.Loon0);
            PlayWave(testSample, true);
        }
    }
}
