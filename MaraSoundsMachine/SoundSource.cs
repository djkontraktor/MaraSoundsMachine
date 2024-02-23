using SharpDX.XAudio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MaraSoundsMachine.AudioHandler;

namespace MaraSoundsMachine
{
    public class SoundSource
    {
        private Enums.SampleName thisSample = Enums.SampleName.JjaroCreak;
        public Enums.SampleName ThisSample
        {
            get { return thisSample; }
            set { thisSample = value; }
        }

        private SourceVoice thisVoice = null;
        public SourceVoice ThisVoice
        {
            get { return thisVoice; }
            set { thisVoice = value; }
        }

        private bool audioBufferBusy = false;
        public bool AudioBufferBusy
        {
            get { return audioBufferBusy; }
            set { audioBufferBusy = value; }
        }

        private bool isPlaying = false;
        public bool IsPlaying
        {
            get { return isPlaying; }
            set { isPlaying = value; }
        }

        private bool enabled = false;
        public bool Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        private double volume = 1;
        public double Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        private double pan = 0;
        public double Pan
        {
            get { return pan; }
            set { pan = value; }
        }

        private double baseFrequency = 1;
        public double BaseFrequency
        {
            get { return baseFrequency; }
            set { baseFrequency = value; }
        }

        private double deltaPan = 0;
        public double DeltaPan
        {
            get { return deltaPan; }
            set { deltaPan = value; }
        }

        private double deltaVolume = 0;
        public double DeltaVolume
        {
            get { return deltaVolume; }
            set { deltaVolume = value; }
        }

        private double deltaFrequency = 0;
        public double DeltaFrequency
        {
            get { return deltaFrequency; }
            set { deltaFrequency = value; }
        }
    }
}
