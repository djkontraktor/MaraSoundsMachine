using SharpDX.Multimedia;
using SharpDX.XAudio2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MaraSoundsMachine.MainForm;

namespace MaraSoundsMachine
{
    public static class AudioHandler
    {
        // Global Variables
        public static XAudio2 yourAudiodevice = new XAudio2();
        public static MasteringVoice thisMasteringVoice = new MasteringVoice(yourAudiodevice);
        public static bool audioBufferBusy = false;
        public static List<SoundSource> soundSourcesList = new List<SoundSource>();

        #region Stream Handling
        public static void StartPlayWave(WaveName waveFile, float volume, float pan)
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

            var sourceVoice = new SourceVoice(yourAudiodevice, waveFormat, true);

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
        #endregion

        #region Path Handling
        public static string GetWaveFilePath(WaveName waveName)
        {
            string fileShortName = "";

            switch (waveName)
            {
                case WaveName.JjaroCreak0:
                    fileShortName = "4 Creak 0";
                    break;
                case WaveName.JjaroCreak1:
                    fileShortName = "4 Creak 1";
                    break;
                case WaveName.Loon0:
                    fileShortName = "29 Loon 0";
                    break;
                case WaveName.Loon1:
                    fileShortName = "29 Loon 1";
                    break;
                case WaveName.Loon2:
                    fileShortName = "29 Loon 2";
                    break;
                case WaveName.Water0:
                    fileShortName = "90 Water 0";
                    break;
                case WaveName.Water1:
                    fileShortName = "90 Water 1";
                    break;
                case WaveName.Water2:
                    fileShortName = "90 Water 2";
                    break;
                case WaveName.Sewage0:
                    fileShortName = "91 Sewage 0";
                    break;
                case WaveName.Sewage1:
                    fileShortName = "91 Sewage 1";
                    break;
                case WaveName.Sewage2:
                    fileShortName = "91 Sewage 2";
                    break;
                case WaveName.Lava0:
                    fileShortName = "92 Lava 0";
                    break;
                case WaveName.Lava1:
                    fileShortName = "92 Lava 1";
                    break;
                case WaveName.Lava2:
                    fileShortName = "92 Lava 2";
                    break;
                case WaveName.Goo0:
                    fileShortName = "93 Goo 0";
                    break;
                case WaveName.Goo1:
                    fileShortName = "93 Goo 1";
                    break;
                case WaveName.Goo2:
                    fileShortName = "93 Goo 2";
                    break;
                case WaveName.UnderStuff:
                    fileShortName = "94 Under Stuff";
                    break;
                case WaveName.Wind0:
                    fileShortName = "95 Wind 0";
                    break;
                case WaveName.Wind1:
                    fileShortName = "95 Wind 1";
                    break;
                case WaveName.Wind2:
                    fileShortName = "95 Wind 2";
                    break;
                case WaveName.Wind3:
                    fileShortName = "95 Wind 3";
                    break;
                case WaveName.Waterfall0:
                    fileShortName = "96 Waterfall 0";
                    break;
                case WaveName.Waterfall1:
                    fileShortName = "96 Waterfall 1";
                    break;
                case WaveName.Siren:
                    fileShortName = "97 Siren";
                    break;
                case WaveName.Fan:
                    fileShortName = "98 Fan";
                    break;
                case WaveName.SphtPlatform:
                    fileShortName = "100 Spht Platform";
                    break;
                case WaveName.AlienHarmonics0:
                    fileShortName = "101 Alien Harmonics 0";
                    break;
                case WaveName.AlienHarmonics1:
                    fileShortName = "101 Alien Harmonics 1";
                    break;
                case WaveName.HeavySphtPlatform:
                    fileShortName = "102 Heavy Spht Platform";
                    break;
                case WaveName.LightMachinery:
                    fileShortName = "103 Light Machinery";
                    break;
                case WaveName.HeavyMachinery:
                    fileShortName = "104 Heavy Machinery";
                    break;
                case WaveName.Transformer:
                    fileShortName = "105 Transformer";
                    break;
                case WaveName.SparkingTransformer0:
                    fileShortName = "106 Sparking Transformer 0";
                    break;
                case WaveName.SparkingTransformer1:
                    fileShortName = "106 Sparking Transformer 1";
                    break;
                case WaveName.SparkingTransformer2:
                    fileShortName = "106 Sparking Transformer 2";
                    break;
                case WaveName.WaterDrip0:
                    fileShortName = "107 Water Drip 0";
                    break;
                case WaveName.WaterDrip1:
                    fileShortName = "107 Water Drip 1";
                    break;
                case WaveName.WaterDrip2:
                    fileShortName = "107 Water Drip 2";
                    break;
                case WaveName.WaterDrip3:
                    fileShortName = "107 Water Drip 3";
                    break;
                case WaveName.MachineBinder:
                    fileShortName = "169 Machine Binder";
                    break;
                case WaveName.MachineBookpress:
                    fileShortName = "170 Machine Bookpress";
                    break;
                case WaveName.MachinePuncher:
                    fileShortName = "171 Machine Puncher";
                    break;
                case WaveName.Electric:
                    fileShortName = "172 Electric";
                    break;
                case WaveName.Alarm:
                    fileShortName = "173 Alarm";
                    break;
                case WaveName.NightWind0:
                    fileShortName = "174 Night Wind 0";
                    break;
                case WaveName.NightWind1:
                    fileShortName = "174 Night Wind 1";
                    break;
                case WaveName.NightWind2:
                    fileShortName = "174 Night Wind 2";
                    break;
                case WaveName.SurfaceExplosion0:
                    fileShortName = "175 Surface Explosion 0";
                    break;
                case WaveName.SurfaceExplosion1:
                    fileShortName = "175 Surface Explosion 1";
                    break;
                case WaveName.SurfaceExplosion2:
                    fileShortName = "175 Surface Explosion 2";
                    break;
                case WaveName.UndergroundExplosion:
                    fileShortName = "176 Underground Explosion";
                    break;
                case WaveName.PfhorPlatform:
                    fileShortName = "189 Pfhor Platform";
                    break;
                case WaveName.PfhorDoor:
                    fileShortName = "193 Pfhor Door";
                    break;
                case WaveName.AlienNoise1_0:
                    fileShortName = "201 Alien Noise 1 0";
                    break;
                case WaveName.AlienNoise1_1:
                    fileShortName = "201 Alien Noise 1 1";
                    break;
                case WaveName.AlienNoise2_0:
                    fileShortName = "202 Alien Noise 2 0";
                    break;
                case WaveName.AlienNoise2_1:
                    fileShortName = "202 Alien Noise 2 1";
                    break;
            }

            string filePath = string.Format("{0}Resources\\" + fileShortName + ".wav", Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));

            return filePath;
        }
        #endregion

        public class SoundSource
        {
            private SampleName thisSample = SampleName.JjaroCreak;
            public SampleName ThisSample
            {
                get { return thisSample; }
                set { thisSample = value; }
            }

            private bool enabled = false;
            public bool Enabled
            {
                get { return enabled; }
                set { enabled = value; }
            }

            private double volume = 100;
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

        #region Enums
        public enum WaveName
        {
            JjaroCreak0,
            JjaroCreak1,
            Loon0,
            Loon1,
            Loon2,
            Water0,
            Water1,
            Water2,
            Sewage0,
            Sewage1,
            Sewage2,
            Lava0,
            Lava1,
            Lava2,
            Goo0,
            Goo1,
            Goo2,
            UnderStuff,
            Wind0,
            Wind1,
            Wind2,
            Wind3,
            Waterfall0,
            Waterfall1,
            Siren,
            Fan,
            SphtPlatform,
            AlienHarmonics0,
            AlienHarmonics1,
            HeavySphtPlatform,
            LightMachinery,
            HeavyMachinery,
            Transformer,
            SparkingTransformer0,
            SparkingTransformer1,
            SparkingTransformer2,
            WaterDrip0,
            WaterDrip1,
            WaterDrip2,
            WaterDrip3,
            MachineBinder,
            MachineBookpress,
            MachinePuncher,
            Electric,
            Alarm,
            NightWind0,
            NightWind1,
            NightWind2,
            SurfaceExplosion0,
            SurfaceExplosion1,
            SurfaceExplosion2,
            UndergroundExplosion,
            PfhorPlatform,
            PfhorDoor,
            AlienNoise1_0,
            AlienNoise1_1,
            AlienNoise2_0,
            AlienNoise2_1
        }

        public enum SampleName
        {
            JjaroCreak,
            Loon,
            Water,
            Sewage,
            Lava,
            Goo,
            UnderStuff,
            Wind,
            Waterfall,
            Siren,
            Fan,
            SphtPlatform,
            AlienHarmonics,
            HeavySphtPlatform,
            LightMachinery,
            HeavyMachinery,
            Transformer,
            SparkingTransformer,
            WaterDrip,
            MachineBinder,
            MachineBookpress,
            MachinePuncher,
            Electric,
            Alarm,
            NightWind,
            SurfaceExplosion,
            UndergroundExplosion,
            PfhorPlatform,
            PfhorDoor,
            AlienNoise1,
            AlienNoise2
        }
        #endregion
    }
}
