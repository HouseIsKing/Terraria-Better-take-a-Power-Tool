using System.IO;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;

namespace BettertakeaPowerTool
{
    public static class Config
    {
        public static int DommhammerjackhammerSettings = 0;
        public static bool BuffLunarDrills = false;
        public static bool OldSpectreDrillSprite = false;
        public static bool OldBoneDrillSprite = false;
        public static bool OldCandyCaneDrillSprite = false;
        public static bool OldWarChainsawoftheNightSprite = false;
        public static bool OldBloodyMassacreSprite = false;
        public static bool OldShroomiteClawedDrillSprite = false;
        public static bool OldWoodJackhammersSprite = false;
        public static bool GustoneVersionWoodJackhammersSprite = false;
        public static bool OldMetalJackhammersSprite = false;
        public static bool GustoneVersionMetalJackhammersSprite = false;
        
        //The file will be stored in "Terraria/ModLoader/Mod Configs/Example Mod.json"
        static string ConfigPath = Path.Combine(Main.SavePath, "Mod Configs", "BettertakeaPowerTool.json");

        static Preferences Configuration = new Preferences(ConfigPath);

        public static void Load()
        {
            //Reading the config file
            bool success = ReadConfig();

            if (!success)
            {
                ErrorLogger.Log("Failed to read config file! Recreating config...");
                CreateConfig();
            }
        }

        //Returns "true" if the config file was found and successfully loaded.
        static bool ReadConfig()
        {
            if (Configuration.Load())
            {
                Configuration.Get("BuffLunarDrills", ref BuffLunarDrills);
                Configuration.Get("Dommhammer/jackhammerSettings", ref DommhammerjackhammerSettings);
                Configuration.Get("OldSpectreDrillSprite", ref OldSpectreDrillSprite);
                Configuration.Get("OldBoneDrillSprite", ref OldBoneDrillSprite);
                Configuration.Get("OldCandyCaneDrillSprite", ref OldCandyCaneDrillSprite);
                Configuration.Get("OldWarChainsawoftheNightSprite", ref OldWarChainsawoftheNightSprite);
                Configuration.Get("OldBloodyMassacreSprite", ref OldBloodyMassacreSprite);
                Configuration.Get("OldShroomiteClawedDrillSprite", ref OldShroomiteClawedDrillSprite);
                Configuration.Get("OldWoodJackhammersSprite", ref OldWoodJackhammersSprite);
                Configuration.Get("GustoneVersionWoodJackhammersSprite", ref GustoneVersionWoodJackhammersSprite);
                Configuration.Get("OldMetalJackhammersSprite", ref OldMetalJackhammersSprite);
                Configuration.Get("GustoneVersionMetalJackhammersSprite", ref GustoneVersionMetalJackhammersSprite);
                return true;
            }
            return false;
        }

        //Creates a config file. This will only be called if the config file doesn't exist yet or it's invalid. 
        static void CreateConfig()
        {
            Configuration.Clear();
            Configuration.Put("BuffLunarDrills", BuffLunarDrills);
            Configuration.Put("Dommhammer/jackhammerSettings", DommhammerjackhammerSettings);
            Configuration.Put("Unobtainable", 0);
            Configuration.Put("50% Drop chance to get Pwnhammer/jackhammer or Dommhammer/jackhammer from Wall of Fleash", 1);
            Configuration.Put("Replace Pawnhammer/jackhammer and make them stronger and made with Hallow Bars", 2);
            Configuration.Put("OldSpectreDrillSprite", OldSpectreDrillSprite);
            Configuration.Put("OldBoneDrillSprite", OldBoneDrillSprite);
            Configuration.Put("OldCandyCaneDrillSprite", OldCandyCaneDrillSprite);
            Configuration.Put("OldWarChainsawoftheNightSprite", OldWarChainsawoftheNightSprite);
            Configuration.Put("OldBloodyMassacreSprite", OldBloodyMassacreSprite);
            Configuration.Put("OldShroomiteClawedDrillSprite", OldShroomiteClawedDrillSprite);
            Configuration.Put("OldWoodJackhammersSprite", OldWoodJackhammersSprite);
            Configuration.Put("GustoneVersionWoodJackhammersSprite", GustoneVersionWoodJackhammersSprite);
            Configuration.Put("OldMetalJackhammersSprite", OldMetalJackhammersSprite);
            Configuration.Put("GustoneVersionMetalJackhammersSprite", GustoneVersionMetalJackhammersSprite);
            Configuration.Put("Old need to be false if GustoneVersion is true also in the opposite way", 0);
            Configuration.Save();
        }
    }
}