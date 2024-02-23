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
                    soundSource.Play();
                }
            }
        }

        public static void StopAudioPlayback()
        {
            uiPlaybackEnabled = false;

            foreach (SoundSource soundSource in soundSourcesList)
            {
                soundSource.Stop();
            }
        }
        #endregion
    }
}
