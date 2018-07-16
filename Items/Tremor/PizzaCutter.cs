using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
	public class PizzaCutter : ModItem
	{
        public override void SetStaticDefaults()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
			{
				DisplayName.SetDefault("Pizza Cutter");
			}
		}
		public override void SetDefaults()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
			{
				item.CloneDefaults(tremor.ItemType("ButcherAxe"));
				item.channel = true;
				item.noUseGraphic = true;
				item.noMelee = true;
				item.useStyle = 5;
				item.knockBack = 0;
				item.UseSound = SoundID.Item23;
				item.shoot = mod.ProjectileType("PizzaCutter");
				item.shootSpeed = 40f;
			}
		}
	}
}