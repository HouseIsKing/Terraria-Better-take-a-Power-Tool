using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items
{
	public class TheSaw : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Saw");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.TheAxe);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("TheSaw");
			item.shootSpeed = 40f;
		}
	}
}
