using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaraSoundsMachine
{
    public class Wave
    {

        public Wave(WaveName waveName)
        {
            WaveStream = LoadWaveFile(waveName);
        }

        private System.IO.UnmanagedMemoryStream waveStream;
        public System.IO.UnmanagedMemoryStream WaveStream
        {
            get
            {
                return waveStream;
            }
            set
            {
                value = waveStream;
            }
        }

        private System.IO.UnmanagedMemoryStream LoadWaveFile(WaveName waveName)
        {
            System.IO.UnmanagedMemoryStream stream = Properties.Resources._100_Spht_Platform;

            switch (waveName)
            {
                case WaveName.Silence:
                    break;
                case WaveName.JjaroCreak0:
                    stream = Properties.Resources._4_Creak_0;
                    break;
                case WaveName.JjaroCreak1:
                    stream = Properties.Resources._4_Creak_1;
                    break;
                case WaveName.Loon0:
                    stream = Properties.Resources._29_Loon_0;
                    break;
                case WaveName.Loon1:
                    stream = Properties.Resources._29_Loon_1;
                    break;
                case WaveName.Loon2:
                    stream = Properties.Resources._29_Loon_2;
                    break;
                case WaveName.Water0:
                    stream = Properties.Resources._90_Water_0;
                    break;
                case WaveName.Water1:
                    stream = Properties.Resources._90_Water_1;
                    break;
                case WaveName.Water2:
                    stream = Properties.Resources._90_Water_2;
                    break;
                case WaveName.Sewage0:
                    stream = Properties.Resources._91_Sewage_0;
                    break;
                case WaveName.Sewage1:
                    stream = Properties.Resources._91_Sewage_1;
                    break;
                case WaveName.Sewage2:
                    stream = Properties.Resources._91_Sewage_2;
                    break;
                case WaveName.Lava0:
                    stream = Properties.Resources._92_Lava_0;
                    break;
                case WaveName.Lava1:
                    stream = Properties.Resources._92_Lava_1;
                    break;
                case WaveName.Lava2:
                    stream = Properties.Resources._92_Lava_2;
                    break;
                case WaveName.Goo0:
                    stream = Properties.Resources._93_Goo_0;
                    break;
                case WaveName.Goo1:
                    stream = Properties.Resources._93_Goo_1;
                    break;
                case WaveName.Goo2:
                    stream = Properties.Resources._93_Goo_2;
                    break;
                case WaveName.UnderStuff:
                    stream = Properties.Resources._94_Under_Stuff;
                    break;
                case WaveName.Wind0:
                    stream = Properties.Resources._95_Wind_0;
                    break;
                case WaveName.Wind1:
                    stream = Properties.Resources._95_Wind_1;
                    break;
                case WaveName.Wind2:
                    stream = Properties.Resources._95_Wind_2;
                    break;
                case WaveName.Wind3:
                    stream = Properties.Resources._95_Wind_3;
                    break;
                case WaveName.Waterfall0:
                    stream = Properties.Resources._96_Waterfall_0;
                    break;
                case WaveName.Waterfall1:
                    stream = Properties.Resources._96_Waterfall_1;
                    break;
                case WaveName.Siren:
                    stream = Properties.Resources._97_Siren;
                    break;
                case WaveName.Fan:
                    stream = Properties.Resources._98_Fan;
                    break;
                case WaveName.SphtPlatform:
                    stream = Properties.Resources._100_Spht_Platform;
                    break;
                case WaveName.AlienHarmonics0:
                    stream = Properties.Resources._101_Alien_Harmonics_0;
                    break;
                case WaveName.AlienHarmonics1:
                    stream = Properties.Resources._101_Alien_Harmonics_1;
                    break;
                case WaveName.HeavySphtPlatform:
                    stream = Properties.Resources._102_Heavy_Spht_Platform;
                    break;
                case WaveName.LightMachinery:
                    stream = Properties.Resources._103_Light_Machinery;
                    break;
                case WaveName.HeavyMachinery:
                    stream = Properties.Resources._104_Heavy_Machinery;
                    break;
                case WaveName.Transformer:
                    stream = Properties.Resources._105_Transformer;
                    break;
                case WaveName.SparkingTransformer0:
                    stream = Properties.Resources._106_Sparking_Transformer_0;
                    break;
                case WaveName.SparkingTransformer1:
                    stream = Properties.Resources._106_Sparking_Transformer_1;
                    break;
                case WaveName.SparkingTransformer2:
                    stream = Properties.Resources._106_Sparking_Transformer_2;
                    break;
                case WaveName.WaterDrip0:
                    stream = Properties.Resources._107_Water_Drip_0;
                    break;
                case WaveName.WaterDrip1:
                    stream = Properties.Resources._107_Water_Drip_1;
                    break;
                case WaveName.WaterDrip2:
                    stream = Properties.Resources._107_Water_Drip_2;
                    break;
                case WaveName.WaterDrip3:
                    stream = Properties.Resources._107_Water_Drip_3;
                    break;
                case WaveName.MachineBinder:
                    stream = Properties.Resources._169_Machine_Binder;
                    break;
                case WaveName.MachineBookpress:
                    stream = Properties.Resources._170_Machine_Bookpress;
                    break;
                case WaveName.MachinePuncher:
                    stream = Properties.Resources._171_Machine_Puncher;
                    break;
                case WaveName.Electric:
                    stream = Properties.Resources._172_Electric;
                    break;
                case WaveName.Alarm:
                    stream = Properties.Resources._173_Alarm;
                    break;
                case WaveName.NightWind0:
                    stream = Properties.Resources._174_Night_Wind_0;
                    break;
                case WaveName.NightWind1:
                    stream = Properties.Resources._174_Night_Wind_1;
                    break;
                case WaveName.NightWind2:
                    stream = Properties.Resources._174_Night_Wind_2;
                    break;
                case WaveName.SurfaceExplosion0:
                    stream = Properties.Resources._175_Surface_Explosion_0;
                    break;
                case WaveName.SurfaceExplosion1:
                    stream = Properties.Resources._175_Surface_Explosion_1;
                    break;
                case WaveName.SurfaceExplosion2:
                    stream = Properties.Resources._175_Surface_Explosion_2;
                    break;
                case WaveName.UndergroundExplosion:
                    stream = Properties.Resources._176_Underground_Explosion;
                    break;
                case WaveName.PfhorPlatform:
                    stream = Properties.Resources._189_Pfhor_Platform;
                    break;
                case WaveName.PfhorDoor:
                    stream = Properties.Resources._193_Pfhor_Door;
                    break;
                case WaveName.AlienNoise1_0:
                    stream = Properties.Resources._201_Alien_Noise_1_0;
                    break;
                case WaveName.AlienNoise1_1:
                    stream = Properties.Resources._201_Alien_Noise_1_1;
                    break;
                case WaveName.AlienNoise2_0:
                    stream = Properties.Resources._202_Alien_Noise_2_0;
                    break;
                case WaveName.AlienNoise2_1:
                    stream = Properties.Resources._202_Alien_Noise_2_1;
                    break;
            }

            return stream;
        }
    }

    public enum WaveName
    {
        Silence,
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
}
