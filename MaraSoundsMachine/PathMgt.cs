using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaraSoundsMachine
{
    public class PathMgt
    {
        public static string GetWaveFilePath(Enums.WaveName waveName)
        {
            string fileShortName = "";

            switch (waveName)
            {
                case Enums.WaveName.JjaroCreak0:
                    fileShortName = "4 Creak 0";
                    break;
                case Enums.WaveName.JjaroCreak1:
                    fileShortName = "4 Creak 1";
                    break;
                case Enums.WaveName.Loon0:
                    fileShortName = "29 Loon 0";
                    break;
                case Enums.WaveName.Loon1:
                    fileShortName = "29 Loon 1";
                    break;
                case Enums.WaveName.Loon2:
                    fileShortName = "29 Loon 2";
                    break;
                case Enums.WaveName.Water0:
                    fileShortName = "90 Water 0";
                    break;
                case Enums.WaveName.Water1:
                    fileShortName = "90 Water 1";
                    break;
                case Enums.WaveName.Water2:
                    fileShortName = "90 Water 2";
                    break;
                case Enums.WaveName.Sewage0:
                    fileShortName = "91 Sewage 0";
                    break;
                case Enums.WaveName.Sewage1:
                    fileShortName = "91 Sewage 1";
                    break;
                case Enums.WaveName.Sewage2:
                    fileShortName = "91 Sewage 2";
                    break;
                case Enums.WaveName.Lava0:
                    fileShortName = "92 Lava 0";
                    break;
                case Enums.WaveName.Lava1:
                    fileShortName = "92 Lava 1";
                    break;
                case Enums.WaveName.Lava2:
                    fileShortName = "92 Lava 2";
                    break;
                case Enums.WaveName.Goo0:
                    fileShortName = "93 Goo 0";
                    break;
                case Enums.WaveName.Goo1:
                    fileShortName = "93 Goo 1";
                    break;
                case Enums.WaveName.Goo2:
                    fileShortName = "93 Goo 2";
                    break;
                case Enums.WaveName.UnderStuff:
                    fileShortName = "94 Under Stuff";
                    break;
                case Enums.WaveName.Wind0:
                    fileShortName = "95 Wind 0";
                    break;
                case Enums.WaveName.Wind1:
                    fileShortName = "95 Wind 1";
                    break;
                case Enums.WaveName.Wind2:
                    fileShortName = "95 Wind 2";
                    break;
                case Enums.WaveName.Wind3:
                    fileShortName = "95 Wind 3";
                    break;
                case Enums.WaveName.Waterfall0:
                    fileShortName = "96 Waterfall 0";
                    break;
                case Enums.WaveName.Waterfall1:
                    fileShortName = "96 Waterfall 1";
                    break;
                case Enums.WaveName.Siren:
                    fileShortName = "97 Siren";
                    break;
                case Enums.WaveName.Fan:
                    fileShortName = "98 Fan";
                    break;
                case Enums.WaveName.SphtPlatform:
                    fileShortName = "100 Spht Platform";
                    break;
                case Enums.WaveName.AlienHarmonics0:
                    fileShortName = "101 Alien Harmonics 0";
                    break;
                case Enums.WaveName.AlienHarmonics1:
                    fileShortName = "101 Alien Harmonics 1";
                    break;
                case Enums.WaveName.HeavySphtPlatform:
                    fileShortName = "102 Heavy Spht Platform";
                    break;
                case Enums.WaveName.LightMachinery:
                    fileShortName = "103 Light Machinery";
                    break;
                case Enums.WaveName.HeavyMachinery:
                    fileShortName = "104 Heavy Machinery";
                    break;
                case Enums.WaveName.Transformer:
                    fileShortName = "105 Transformer";
                    break;
                case Enums.WaveName.SparkingTransformer0:
                    fileShortName = "106 Sparking Transformer 0";
                    break;
                case Enums.WaveName.SparkingTransformer1:
                    fileShortName = "106 Sparking Transformer 1";
                    break;
                case Enums.WaveName.SparkingTransformer2:
                    fileShortName = "106 Sparking Transformer 2";
                    break;
                case Enums.WaveName.WaterDrip0:
                    fileShortName = "107 Water Drip 0";
                    break;
                case Enums.WaveName.WaterDrip1:
                    fileShortName = "107 Water Drip 1";
                    break;
                case Enums.WaveName.WaterDrip2:
                    fileShortName = "107 Water Drip 2";
                    break;
                case Enums.WaveName.WaterDrip3:
                    fileShortName = "107 Water Drip 3";
                    break;
                case Enums.WaveName.MachineBinder:
                    fileShortName = "169 Machine Binder";
                    break;
                case Enums.WaveName.MachineBookpress:
                    fileShortName = "170 Machine Bookpress";
                    break;
                case Enums.WaveName.MachinePuncher:
                    fileShortName = "171 Machine Puncher";
                    break;
                case Enums.WaveName.Electric:
                    fileShortName = "172 Electric";
                    break;
                case Enums.WaveName.Alarm:
                    fileShortName = "173 Alarm";
                    break;
                case Enums.WaveName.NightWind0:
                    fileShortName = "174 Night Wind 0";
                    break;
                case Enums.WaveName.NightWind1:
                    fileShortName = "174 Night Wind 1";
                    break;
                case Enums.WaveName.NightWind2:
                    fileShortName = "174 Night Wind 2";
                    break;
                case Enums.WaveName.SurfaceExplosion0:
                    fileShortName = "175 Surface Explosion 0";
                    break;
                case Enums.WaveName.SurfaceExplosion1:
                    fileShortName = "175 Surface Explosion 1";
                    break;
                case Enums.WaveName.SurfaceExplosion2:
                    fileShortName = "175 Surface Explosion 2";
                    break;
                case Enums.WaveName.UndergroundExplosion:
                    fileShortName = "176 Underground Explosion";
                    break;
                case Enums.WaveName.PfhorPlatform:
                    fileShortName = "189 Pfhor Platform";
                    break;
                case Enums.WaveName.PfhorDoor:
                    fileShortName = "193 Pfhor Door";
                    break;
                case Enums.WaveName.AlienNoise1_0:
                    fileShortName = "201 Alien Noise 1 0";
                    break;
                case Enums.WaveName.AlienNoise1_1:
                    fileShortName = "201 Alien Noise 1 1";
                    break;
                case Enums.WaveName.AlienNoise2_0:
                    fileShortName = "202 Alien Noise 2 0";
                    break;
                case Enums.WaveName.AlienNoise2_1:
                    fileShortName = "202 Alien Noise 2 1";
                    break;
            }

            string filePath = string.Format("{0}Resources\\" + fileShortName + ".wav", Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));

            return filePath;
        }

        public static List<Enums.WaveName> ListAllWaveNames(Enums.SampleName sampleName)
        {
            List<Enums.WaveName> waveList = new List<Enums.WaveName>();

            #region Wave Selector
            switch (sampleName)
            {
                case Enums.SampleName.JjaroCreak:
                    waveList.Add(Enums.WaveName.JjaroCreak0);
                    waveList.Add(Enums.WaveName.JjaroCreak1);
                    break;
                case Enums.SampleName.Loon:
                    waveList.Add(Enums.WaveName.Loon0);
                    waveList.Add(Enums.WaveName.Loon1);
                    waveList.Add(Enums.WaveName.Loon2);
                    break;
                case Enums.SampleName.Water:
                    waveList.Add(Enums.WaveName.Water0);
                    waveList.Add(Enums.WaveName.Water1);
                    waveList.Add(Enums.WaveName.Water2);
                    break;
                case Enums.SampleName.Sewage:
                    waveList.Add(Enums.WaveName.Sewage0);
                    waveList.Add(Enums.WaveName.Sewage1);
                    waveList.Add(Enums.WaveName.Sewage2);
                    break;
                case Enums.SampleName.Lava:
                    waveList.Add(Enums.WaveName.Lava0);
                    waveList.Add(Enums.WaveName.Lava1);
                    waveList.Add(Enums.WaveName.Lava2);
                    break;
                case Enums.SampleName.Goo:
                    waveList.Add(Enums.WaveName.Goo0);
                    waveList.Add(Enums.WaveName.Goo1);
                    waveList.Add(Enums.WaveName.Goo2);
                    break;
                case Enums.SampleName.UnderStuff:
                    waveList.Add(Enums.WaveName.UnderStuff);
                    break;
                case Enums.SampleName.Wind:
                    waveList.Add(Enums.WaveName.Wind0);
                    waveList.Add(Enums.WaveName.Wind1);
                    waveList.Add(Enums.WaveName.Wind2);
                    waveList.Add(Enums.WaveName.Wind3);
                    break;
                case Enums.SampleName.Waterfall:
                    waveList.Add(Enums.WaveName.Waterfall0);
                    waveList.Add(Enums.WaveName.Waterfall1);
                    break;
                case Enums.SampleName.Siren:
                    waveList.Add(Enums.WaveName.Siren);
                    break;
                case Enums.SampleName.Fan:
                    waveList.Add(Enums.WaveName.Fan);
                    break;
                case Enums.SampleName.SphtPlatform:
                    waveList.Add(Enums.WaveName.SphtPlatform);
                    break;
                case Enums.SampleName.AlienHarmonics:
                    waveList.Add(Enums.WaveName.AlienHarmonics0);
                    waveList.Add(Enums.WaveName.AlienHarmonics1);
                    break;
                case Enums.SampleName.HeavySphtPlatform:
                    waveList.Add(Enums.WaveName.HeavySphtPlatform);
                    break;
                case Enums.SampleName.LightMachinery:
                    waveList.Add(Enums.WaveName.LightMachinery);
                    break;
                case Enums.SampleName.HeavyMachinery:
                    waveList.Add(Enums.WaveName.HeavyMachinery);
                    break;
                case Enums.SampleName.Transformer:
                    waveList.Add(Enums.WaveName.Transformer);
                    break;
                case Enums.SampleName.SparkingTransformer:
                    waveList.Add(Enums.WaveName.SparkingTransformer0);
                    waveList.Add(Enums.WaveName.SparkingTransformer1);
                    waveList.Add(Enums.WaveName.SparkingTransformer2);
                    break;
                case Enums.SampleName.WaterDrip:
                    waveList.Add(Enums.WaveName.WaterDrip0);
                    waveList.Add(Enums.WaveName.WaterDrip1);
                    waveList.Add(Enums.WaveName.WaterDrip2);
                    waveList.Add(Enums.WaveName.WaterDrip3);
                    break;
                case Enums.SampleName.MachineBinder:
                    waveList.Add(Enums.WaveName.MachineBinder);
                    break;
                case Enums.SampleName.MachineBookpress:
                    waveList.Add(Enums.WaveName.MachineBookpress);
                    break;
                case Enums.SampleName.MachinePuncher:
                    waveList.Add(Enums.WaveName.MachinePuncher);
                    break;
                case Enums.SampleName.Electric:
                    waveList.Add(Enums.WaveName.Electric);
                    break;
                case Enums.SampleName.Alarm:
                    waveList.Add(Enums.WaveName.Alarm);
                    break;
                case Enums.SampleName.NightWind:
                    waveList.Add(Enums.WaveName.NightWind0);
                    waveList.Add(Enums.WaveName.NightWind1);
                    waveList.Add(Enums.WaveName.NightWind2);
                    break;
                case Enums.SampleName.SurfaceExplosion:
                    waveList.Add(Enums.WaveName.SurfaceExplosion0);
                    waveList.Add(Enums.WaveName.SurfaceExplosion1);
                    waveList.Add(Enums.WaveName.SurfaceExplosion2);
                    break;
                case Enums.SampleName.UndergroundExplosion:
                    waveList.Add(Enums.WaveName.UndergroundExplosion);
                    break;
                case Enums.SampleName.PfhorPlatform:
                    waveList.Add(Enums.WaveName.PfhorPlatform);
                    break;
                case Enums.SampleName.PfhorDoor:
                    waveList.Add(Enums.WaveName.PfhorDoor);
                    break;
                case Enums.SampleName.AlienNoise1:
                    waveList.Add(Enums.WaveName.AlienNoise1_0);
                    waveList.Add(Enums.WaveName.AlienNoise1_1);
                    break;
                case Enums.SampleName.AlienNoise2:
                    waveList.Add(Enums.WaveName.AlienNoise2_0);
                    waveList.Add(Enums.WaveName.AlienNoise2_1);
                    break;
            }
            #endregion

            return waveList;
        }

        public static string ReturnEnglishSampleName(Enums.SampleName sampleName)
        {
            string englishName = "";

            switch (sampleName)
            {
                case Enums.SampleName.JjaroCreak:
                    englishName = "Jjaro Ship Creak";
                    break;
                case Enums.SampleName.Loon:
                    englishName = "Loon";
                    break;
                case Enums.SampleName.Water:
                    englishName = "Water";
                    break;
                case Enums.SampleName.Sewage:
                    englishName = "Sewage";
                    break;
                case Enums.SampleName.Lava:
                    englishName = "Lava";
                    break;
                case Enums.SampleName.Goo:
                    englishName = "Goo";
                    break;
                case Enums.SampleName.UnderStuff:
                    englishName = "Under Media";
                    break;
                case Enums.SampleName.Wind:
                    englishName = "Wind";
                    break;
                case Enums.SampleName.Waterfall:
                    englishName = "Waterfall";
                    break;
                case Enums.SampleName.Siren:
                    englishName = "Siren";
                    break;
                case Enums.SampleName.Fan:
                    englishName = "Fan";
                    break;
                case Enums.SampleName.SphtPlatform:
                    englishName = "S\'pht Platform";
                    break;
                case Enums.SampleName.AlienHarmonics:
                    englishName = "Alien Harmonics";
                    break;
                case Enums.SampleName.HeavySphtPlatform:
                    englishName = "Heavy S\'pht Platform";
                    break;
                case Enums.SampleName.LightMachinery:
                    englishName = "Light Machinery";
                    break;
                case Enums.SampleName.HeavyMachinery:
                    englishName = "Heavy Machinery";
                    break;
                case Enums.SampleName.Transformer:
                    englishName = "Transformer";
                    break;
                case Enums.SampleName.SparkingTransformer:
                    englishName = "Sparking Transformer";
                    break;
                case Enums.SampleName.WaterDrip:
                    englishName = "Water Drip";
                    break;
                case Enums.SampleName.MachineBinder:
                    englishName = "Machine Binder";
                    break;
                case Enums.SampleName.MachineBookpress:
                    englishName = "Machine Bookpress";
                    break;
                case Enums.SampleName.MachinePuncher:
                    englishName = "Machine Puncher";
                    break;
                case Enums.SampleName.Electric:
                    englishName = "Electric";
                    break;
                case Enums.SampleName.Alarm:
                    englishName = "Alarm";
                    break;
                case Enums.SampleName.NightWind:
                    englishName = "Night Wind";
                    break;
                case Enums.SampleName.SurfaceExplosion:
                    englishName = "Surface Explosion";
                    break;
                case Enums.SampleName.UndergroundExplosion:
                    englishName = "Underground Explosion";
                    break;
                case Enums.SampleName.PfhorPlatform:
                    englishName = "Pfhor Platform";
                    break;
                case Enums.SampleName.PfhorDoor:
                    englishName = "Pfhor Door";
                    break;
                case Enums.SampleName.AlienNoise1:
                    englishName = "Alien Ship 1";
                    break;
                case Enums.SampleName.AlienNoise2:
                    englishName = "Alien Ship 2";
                    break;
            }
            return englishName;
        }

        public static bool IsSoundSampleRandom(Enums.SampleName sampleName)
        {
            bool isRandom = false;

            switch (sampleName)
            {
                case Enums.SampleName.JjaroCreak:
                case Enums.SampleName.Loon:
                case Enums.SampleName.WaterDrip:
                case Enums.SampleName.SurfaceExplosion:
                case Enums.SampleName.UndergroundExplosion:
                    isRandom = true;
                    break;
            }

            return isRandom;
        }

        public static Enums.WaveName ReturnRandomWaveName(Enums.SampleName sampleName)
        {
            Enums.WaveName randomWaveName = Enums.WaveName.JjaroCreak0;
            List<Enums.WaveName> waveSelectionList = ListAllWaveNames(sampleName);

            // Select an element from the list at random
            Random random = new Random();
            int randomIndex = random.Next(0, waveSelectionList.Count);
            randomWaveName = waveSelectionList[randomIndex];

            return randomWaveName;
        }

        public static Enums.SampleName ReturnSampleNameFromEnglishString(string englishName)
        {
            Enums.SampleName thisSampleName = Enums.SampleName.JjaroCreak;

            switch (englishName)
            {
                case "Jjaro Ship Creak":
                    thisSampleName = Enums.SampleName.JjaroCreak;
                    break;
                case "Loon":
                    thisSampleName = Enums.SampleName.Loon;
                    break;
                case "Water":
                    thisSampleName = Enums.SampleName.Water;
                    break;
                case "Sewage":
                    thisSampleName = Enums.SampleName.Sewage;
                    break;
                case "Lava":
                    thisSampleName = Enums.SampleName.Lava;
                    break;
                case "Goo":
                    thisSampleName = Enums.SampleName.Goo;
                    break;
                case "Under Media":
                    thisSampleName = Enums.SampleName.UnderStuff;
                    break;
                case "Wind":
                    thisSampleName = Enums.SampleName.Wind;
                    break;
                case "Waterfall":
                    thisSampleName = Enums.SampleName.Waterfall;
                    break;
                case "Siren":
                    thisSampleName = Enums.SampleName.Siren;
                    break;
                case "Fan":
                    thisSampleName = Enums.SampleName.Fan;
                    break;
                case "S\'pht Platform":
                    thisSampleName = Enums.SampleName.SphtPlatform;
                    break;
                case "Alien Harmonics":
                    thisSampleName = Enums.SampleName.AlienHarmonics;
                    break;
                case "Heavy S\'pht Platform":
                    thisSampleName = Enums.SampleName.HeavySphtPlatform;
                    break;
                case "Light Machinery":
                    thisSampleName = Enums.SampleName.LightMachinery;
                    break;
                case "Heavy Machinery":
                    thisSampleName = Enums.SampleName.HeavyMachinery;
                    break;
                case "Transformer":
                    thisSampleName = Enums.SampleName.Transformer;
                    break;
                case "Sparking Transformer":
                    thisSampleName = Enums.SampleName.SparkingTransformer;
                    break;
                case "Water Drip":
                    thisSampleName = Enums.SampleName.WaterDrip;
                    break;
                case "Machine Binder":
                    thisSampleName = Enums.SampleName.MachineBinder;
                    break;
                case "Machine Bookpress":
                    thisSampleName = Enums.SampleName.MachineBookpress;
                    break;
                case "Machine Puncher":
                    thisSampleName = Enums.SampleName.MachinePuncher;
                    break;
                case "Electric":
                    thisSampleName = Enums.SampleName.Electric;
                    break;
                case "Alarm":
                    thisSampleName = Enums.SampleName.Alarm;
                    break;
                case "Night Wind":
                    thisSampleName = Enums.SampleName.NightWind;
                    break;
                case "Surface Explosion":
                    thisSampleName = Enums.SampleName.SurfaceExplosion;
                    break;
                case "Underground Explosion":
                    thisSampleName = Enums.SampleName.UndergroundExplosion;
                    break;
                case "Pfhor Platform":
                    thisSampleName = Enums.SampleName.PfhorPlatform;
                    break;
                case "Pfhor Door":
                    thisSampleName = Enums.SampleName.PfhorDoor;
                    break;
                case "Alien Ship 1":
                    thisSampleName = Enums.SampleName.AlienNoise1;
                    break;
                case "Alien Ship 2":
                    thisSampleName = Enums.SampleName.AlienNoise2;
                    break;
            }

            return thisSampleName;
        }
    }
}
