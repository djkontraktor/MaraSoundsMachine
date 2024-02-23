using SharpDX.Multimedia;
using SharpDX.XAudio2;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static MaraSoundsMachine.AudioHandler;
using static MaraSoundsMachine.MainForm;

namespace MaraSoundsMachine
{
    public static class AudioHandler
    {
        // Global Variables
        public static XAudio2 yourAudiodevice = new XAudio2();
        public static MasteringVoice thisMasteringVoice = new MasteringVoice(yourAudiodevice);
        public static List<SoundSource> soundSourcesList = new List<SoundSource>();
        public static bool uiPlaybackEnabled = false;

        #region Start/Stop Playback
        public static void StartAudioPlayback()
        {
            uiPlaybackEnabled = true;

            foreach (SoundSource soundSource in soundSourcesList)
            {
                if (soundSource.Enabled && uiPlaybackEnabled)
                {
                    AudioHandler.StartPlaySoundSource(soundSource);
                }
            }
        }

        public static void StopAudioPlayback()
        {
            uiPlaybackEnabled = false;

            foreach (SoundSource soundSource in soundSourcesList)
            {
                soundSource.IsPlaying = false;
                soundSource.ThisVoice.Stop();
                soundSource.ThisVoice.DestroyVoice();
                soundSource.ThisVoice.Dispose();
            }
        }
        #endregion

        #region Playback Handling
        public static void StartPlaySoundSource(SoundSource soundSource)
        {
            double p_volume = soundSource.Volume;
            double p_pan = soundSource.Pan;
            double p_pitch = soundSource.BaseFrequency;

            soundSource.IsPlaying = true;

            Random randSeed = new Random();

            double signA = (randSeed.Next(2) == 0) ? -1 : 1;
            double signB = (randSeed.Next(2) == 0) ? -1 : 1;
            double signC = (randSeed.Next(2) == 0) ? -1 : 1;

            double randVolume = (randSeed.NextDouble() * soundSource.DeltaVolume) * signA;
            double randPan = (randSeed.NextDouble() * soundSource.DeltaPan) * signB;
            double randPitch = (randSeed.NextDouble() * soundSource.DeltaFrequency) * signC;

            p_volume = soundSource.Volume + randVolume;
            p_pan = soundSource.Pan + randPan;
            p_pitch = soundSource.BaseFrequency + randPitch; 

            if (!PathMgt.IsSoundSampleRandom(soundSource.ThisSample))
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    StartAmbientSoundSource(soundSource, (float)p_volume, (float)p_pan, (float)p_pitch);

                }).Start();                       
            }
            else
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    StartRandomSoundSource(soundSource, (float)p_volume, (float)p_pan, (float)p_pitch);

                }).Start();
            }
        }   

        public static void StartAmbientSoundSource(SoundSource soundSource, float volume, float pan, float pitch)
        {
            Random randSeed = new Random();
            Random randWaveSeed = new Random();

            // Load wav files into memory first
            List<string> wavePaths = new List<string>();
            List<Enums.WaveName> waveList = PathMgt.ListAllWaveNames(soundSource.ThisSample);
            List<SoundStream> soundStreamList = new List<SoundStream>();
            List<WaveFormat> waveFormatList = new List<WaveFormat>();
            List<AudioBuffer> audioBufferList = new List<AudioBuffer>();

            foreach (Enums.WaveName waveName in waveList)
            {
                wavePaths.Add(PathMgt.GetWaveFilePath(waveName));
            }

            foreach (string wavePath in wavePaths)
            {
                soundStreamList.Add(new SoundStream(File.OpenRead(wavePath)));

                waveFormatList.Add(soundStreamList.Last().Format);

                audioBufferList.Add(new AudioBuffer
                {
                    Stream = soundStreamList.Last().ToDataStream(),
                    AudioBytes = (int)soundStreamList.Last().Length,
                    Flags = BufferFlags.EndOfStream
                });

                soundStreamList.Last().Close();
            }

            while (soundSource.IsPlaying)
            {
                if (!soundSource.AudioBufferBusy)
                {
                    soundSource.AudioBufferBusy = true;

                    int randomWaveIndex = randWaveSeed.Next(0, waveList.Count);

                    soundSource.ThisVoice = new SourceVoice(yourAudiodevice, waveFormatList[randomWaveIndex], true);

                    // Adds a sample callback to check that they are working on source voices
                    soundSource.ThisVoice.BufferEnd += (context) => soundSource.AudioBufferBusy = false;
                    soundSource.ThisVoice.SubmitSourceBuffer(audioBufferList[randomWaveIndex], soundStreamList[randomWaveIndex].DecodedPacketsInfo);

                    soundSource.ThisVoice.SetVolume(volume);

                    soundSource.ThisVoice.Start();

                    audioBufferList[randomWaveIndex].Stream.Dispose();
                }

                System.Threading.Thread.Sleep(33);
            }

        }

        public static void StartRandomSoundSource(SoundSource soundSource, float volume, float pan, float pitch)
        {
            Random randSeed = new Random();
            Random randWaveSeed = new Random();

            // Load wav files into memory first
            List<string> wavePaths = new List<string>();
            List<Enums.WaveName> waveList = PathMgt.ListAllWaveNames(soundSource.ThisSample);
            List<SoundStream> soundStreamList = new List<SoundStream>();
            List<WaveFormat> waveFormatList = new List<WaveFormat>();
            List<AudioBuffer> audioBufferList = new List<AudioBuffer>();

            foreach (Enums.WaveName waveName in waveList)
            {
                wavePaths.Add(PathMgt.GetWaveFilePath(waveName));
            }

            foreach (string wavePath in wavePaths)
            {
                soundStreamList.Add(new SoundStream(File.OpenRead(wavePath)));

                waveFormatList.Add(soundStreamList.Last().Format);

                audioBufferList.Add(new AudioBuffer
                {
                    Stream = soundStreamList.Last().ToDataStream(),
                    AudioBytes = (int)soundStreamList.Last().Length,
                    Flags = BufferFlags.EndOfStream
                });

                soundStreamList.Last().Close();
            }

            while (soundSource.IsPlaying)
            {

                if (!soundSource.AudioBufferBusy && (randSeed.Next(100) < (soundSource.BaseFrequency + soundSource.DeltaFrequency)))
                {
                    soundSource.AudioBufferBusy = true;

                    int randomWaveIndex = randWaveSeed.Next(0, waveList.Count);

                    soundSource.ThisVoice = new SourceVoice(yourAudiodevice, waveFormatList[randomWaveIndex], true);

                    // Adds a sample callback to check that they are working on source voices
                    soundSource.ThisVoice.BufferEnd += (context) => soundSource.AudioBufferBusy = false;
                    soundSource.ThisVoice.SubmitSourceBuffer(audioBufferList[randomWaveIndex], soundStreamList[randomWaveIndex].DecodedPacketsInfo);

                    soundSource.ThisVoice.SetVolume(volume);

                    soundSource.ThisVoice.Start();

                    audioBufferList[randomWaveIndex].Stream.Dispose();
                }

                System.Threading.Thread.Sleep(33);
            }
        }
        #endregion
    }
}
