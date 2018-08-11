using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
	public class Doomjackhammer : ModItem
	{
		public override void SetStaticDefaults()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                DisplayName.SetDefault("Doomjackhammer");
            }
        }
        public override void SetDefaults()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                item.CloneDefaults(tremor.ItemType("Doomhammer"));
                item.channel = true;
                item.noUseGraphic = true;
                item.noMelee = true;
                item.useStyle = 5;
                item.UseSound = SoundID.Item23;
                item.shoot = mod.ProjectileType("Doomjackhammer");
                item.shootSpeed = 40f;
            }
        }
    }
}
