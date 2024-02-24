using SharpDX.Multimedia;
using SharpDX.XAudio2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using static MaraSoundsMachine.AudioHandler;

namespace MaraSoundsMachine
{
    public class SoundSource : StreamDef
    {
        private Enums.SampleName thisSample = Enums.SampleName.JjaroCreak;
        public Enums.SampleName ThisSample
        {
            get { return thisSample; }
            set { thisSample = value; }
        }

        private List<Enums.WaveName> waveList = new List<Enums.WaveName>();
        public List<Enums.WaveName> WaveList
        {
            get { return waveList; }
            set { waveList = value; }
        }

        private bool enabled = false;
        public bool Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        #region Base Fields
        private float base_volume = 1;
        public float Base_volume
        {
            get { return base_volume; }
            set { base_volume = value; }
        }

        private float base_pan = 0;
        public float Base_pan
        {
            get { return base_pan; }
            set { base_pan = value; }
        }

        private int base_period_ticks = 1;
        public int Base_period_ticks
        {
            get { return base_period_ticks; }
            set { base_period_ticks = value; }
        }

        private float base_pitch = 1;
        public float Base_pitch
        {
            get { return base_pitch; }
            set { base_pitch = value; }
        }
        #endregion

        #region Delta Fields
        private float delta_pan = 0;
        public float Delta_pan
        {
            get { return delta_pan; }
            set { delta_pan = value; }
        }

        private float delta_volume = 0;
        public float Delta_volume
        {
            get { return delta_volume; }
            set { delta_volume = value; }
        }

        private int delta_period_ticks = 0;
        public int Delta_period_ticks
        {
            get { return delta_period_ticks; }
            set { delta_period_ticks = value; }
        }

        private float delta_pitch = 0;
        public float Delta_pitch
        {
            get { return delta_pitch; }
            set { delta_pitch = value; }
        }
        #endregion

        #region Instantaneous Fields
        private float inst_pan = 0;
        public float Inst_pan
        {
            get { return inst_pan; }
            set { inst_pan = value; }
        }

        private float inst_volume = 0;
        public float Inst_volume
        {
            get { return inst_volume; }
            set { inst_volume = value; }
        }

        private int inst_period_ticks = 0;
        public int Inst_period_ticks
        {
            get { return inst_period_ticks; }
            set { inst_period_ticks = value; }
        }

        private float inst_pitch = 0;
        public float Inst_pitch
        {
            get { return inst_pitch; }
            set { inst_pitch = value; }
        }
        #endregion

        #region Methods
        public List<string> ListAllWavePaths()
        {
            List<string> wavePaths = new List<string>();

            foreach (Enums.WaveName waveName in WaveList)
            {
                wavePaths.Add(PathMgt.GetWaveFilePath(waveName));
            }

            return wavePaths;
        }

        public void LoadAllWavesToMemory()
        {
            AudioBufferBusy = true;

            List<string> wavePaths = new List<string>();
            WaveList = PathMgt.ListAllWaveNames(ThisSample);
            wavePaths = ListAllWavePaths();

            foreach (string wavePath in wavePaths)
            {
                SoundStreamList.Add(new SoundStream(File.OpenRead(wavePath)));

                WaveFormatList.Add(SoundStreamList.Last().Format);

                AudioBufferList.Add(new AudioBuffer
                {
                    Stream = SoundStreamList.Last().ToDataStream(),
                    AudioBytes = (int)SoundStreamList.Last().Length,
                    Flags = BufferFlags.EndOfStream
                });

                SoundStreamList.Last().Close();   
            }

            AudioBufferBusy = false;
        }

        public void Play()
        {
            IsPlaying = true;

            if (!PathMgt.IsSoundSampleRandom(ThisSample))
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    StartAmbient();

                }).Start();
            }
            else
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    StartRandom();

                }).Start();
            }
        }

        public void Stop()
        {
            IsPlaying = false;
        }

        private void StartAmbient()
        {
            Random randSeed = new Random();
            Random randWaveSeed = new Random();

            LoadAllWavesToMemory();

            #region Playback loop
            while (IsPlaying)
            {
                if (!AudioBufferBusy)
                {
                    AudioBufferBusy = true;

                    CalcFx();

                    int randomWaveIndex = randWaveSeed.Next(0, waveList.Count);

                    SourceVoice = new SourceVoice(yourAudiodevice, WaveFormatList[randomWaveIndex], true);

                    // Adds a sample callback to check that they are working on source voices
                    SourceVoice.BufferEnd += (context) => AudioBufferBusy = false;
                    SourceVoice.SubmitSourceBuffer(AudioBufferList[randomWaveIndex], SoundStreamList[randomWaveIndex].DecodedPacketsInfo);

                    SourceVoice.SetVolume(Inst_volume);

                    float panR = (Inst_pan < 0) ? (1 + Inst_pan) : 1;
                    float panL = (Inst_pan >= 0) ? (1 - Inst_pan) : 1;

                    float[] panXfm = { panL, panR };

                    SourceVoice.SetOutputMatrix(1, 2, panXfm);

                    float freqRatio = 1;

                    if (Inst_pitch > 1)
                    {
                        freqRatio = (float)Math.Pow(Inst_pitch, 10);
                    }
                    else
                    {
                        freqRatio = (float)Math.Pow(Inst_pitch, 0.5);
                    }

                    SourceVoice.SetFrequencyRatio(freqRatio);

                    SourceVoice.Start();

                    AudioBufferList[randomWaveIndex].Stream.Dispose();
                }

                System.Threading.Thread.Sleep(33);
            }
            #endregion
        }

        private void StartRandom()
        {
            Random randSeed = new Random();
            Random randWaveSeed = new Random();
            int randTickCounter = 0;

            LoadAllWavesToMemory();

            #region Playback loop
            while (IsPlaying)
            {
                if (!AudioBufferBusy && (randTickCounter >= Inst_period_ticks))
                {
                    AudioBufferBusy = true;

                    CalcFx();

                    int randomWaveIndex = randWaveSeed.Next(0, WaveList.Count);

                    SourceVoice = new SourceVoice(yourAudiodevice, WaveFormatList[randomWaveIndex], true);

                    // Adds a sample callback to check that they are working on source voices
                    SourceVoice.BufferEnd += (context) => AudioBufferBusy = false;
                    SourceVoice.SubmitSourceBuffer(AudioBufferList[randomWaveIndex], SoundStreamList[randomWaveIndex].DecodedPacketsInfo);

                    SourceVoice.SetVolume(Inst_volume);

                    float panR = (Inst_pan < 0) ? (1 + Inst_pan) : 1;
                    float panL = (Inst_pan >= 0) ? (1 - Inst_pan) : 1;

                    float[] panXfm = { panL, panR };

                    SourceVoice.SetOutputMatrix(1, 2, panXfm);

                    float freqRatio = 1;

                    if (Inst_pitch > 1)
                    {
                        freqRatio = (float)Math.Pow(Inst_pitch, 10);
                    }
                    else
                    {
                        freqRatio = (float)Math.Pow(Inst_pitch, 0.5);
                    }

                    SourceVoice.SetFrequencyRatio(freqRatio);

                    SourceVoice.Start();

                    AudioBufferList[randomWaveIndex].Stream.Dispose();

                    randTickCounter = 0;
                }

                System.Threading.Thread.Sleep(33);

                randTickCounter = (randTickCounter >= 999) ? 0 : (randTickCounter + 1);
            }
            #endregion
        }

        private void CalcFx()
        {
            Random randSeed = new Random();

            float randSignA = (randSeed.Next(2) == 0) ? -1 : 1;
            float randSignB = (randSeed.Next(2) == 0) ? -1 : 1;
            float randSignC = (randSeed.Next(2) == 0) ? -1 : 1;
            float randSignD = (randSeed.Next(2) == 0) ? -1 : 1;

            // Random magnitudes to add to base values
            float rand_Volume = ((float)randSeed.NextDouble() * Delta_volume) * randSignA;
            float rand_Pan = ((float)randSeed.NextDouble() * Delta_pan) * randSignB;
            int rand_Period_ticks = (int)(randSeed.Next(0, Delta_period_ticks) * randSignC);
            float rand_Pitch = ((float)randSeed.NextDouble() * Delta_pitch) * randSignD;

            if ((Base_volume + rand_Volume) >= 1)
            {
                Inst_volume = 1;
            }
            else
            {
                Inst_volume = Base_volume + rand_Volume;
            }

            if ((Base_pan + rand_Pan) >= 1)
            {
                Inst_pan = 1;
            }
            else if ((Base_pan + rand_Pan) <= -1)
            {
                Inst_pan = -1;
            }
            else
            {
                Inst_pan = Base_pan + rand_Pan;
            }

            Inst_period_ticks = Base_period_ticks + rand_Period_ticks;

            if ((Base_pitch + rand_Pitch) >= 5)
            {
                Inst_pitch = 5;
            }
            else if ((Base_pitch + rand_Pitch) <= 0.1)
            {
                Inst_pitch = (float)0.1;
            }
            else
            {
                Inst_pitch = Base_pitch + rand_Pitch;
            }

        }
        #endregion
    }
}
