using SharpDX.Multimedia;
using SharpDX.XAudio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MaraSoundsMachine
{
    public class StreamDef
    {
        private List<SoundStream> soundStreamList = new List<SoundStream>();
        public List<SoundStream> SoundStreamList
        {
            get { return soundStreamList; }
            set { soundStreamList = value; }
        }

        private List<WaveFormat> waveFormatList = new List<WaveFormat>();
        public List<WaveFormat> WaveFormatList
        {
            get { return waveFormatList; }
            set { waveFormatList = value; }
        }

        private List<AudioBuffer> audioBufferList = new List<AudioBuffer>();
        public List<AudioBuffer> AudioBufferList
        {
            get { return audioBufferList; }
            set { audioBufferList = value; }
        }

        private SourceVoice sourceVoice = null;
        public SourceVoice SourceVoice
        {
            get { return sourceVoice; }
            set { sourceVoice = value; }
        }

        private SoundStream soundStream = null;
        public SoundStream SoundStream
        {
            get { return soundStream; }
            set { soundStream = value; }
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
    }
}
