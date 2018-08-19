using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
    public class DommhammerjackhammerSettingsStats : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null && Config.DommhammerjackhammerSettings == 2 && item.type == ItemID.Pwnhammer)
            {
                item.damage = 53;
                item.hammer = 90;
                item.knockBack = 8;
                item.useTime = 30;
                item.useAnimation = 30;
            }
            if (tremor != null && Config.DommhammerjackhammerSettings == 2 && item.type == tremor.ItemType("Doomhammer"))
            {
                item.damage = 26;
                item.hammer = 80;
                item.knockBack = 7.5f;
                item.useTime = 14;
                item.useAnimation = 27;
            }
        }
    }
}
