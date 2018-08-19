using System.IO;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;

namespace BettertakeaPowerTool
{
    public static class Config
    {
        public static int DommhammerjackhammerSettings = 0;

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
                Configuration.Get("Dommhammer/jackhammerSettings", ref DommhammerjackhammerSettings);
                return true;
            }
            return false;
        }

        //Creates a config file. This will only be called if the config file doesn't exist yet or it's invalid. 
        static void CreateConfig()
        {
            Configuration.Clear();
            Configuration.Put("Dommhammer/jackhammerSettings", DommhammerjackhammerSettings);
            Configuration.Put("Unobtainable", 0);
            Configuration.Put("50% Drop chance to get Pwnhammer/jackhammer or Dommhammer/jackhammer from Wall of Fleash", 1);
            Configuration.Put("Replace Pawnhammer/jackhammer and make them stronger and made with Hallow Bars", 2);
            Configuration.Save();
        }
    }
}