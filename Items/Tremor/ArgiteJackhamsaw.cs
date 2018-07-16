using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
	public class ArgiteJackhamsaw : ModItem
	{
		public override void SetStaticDefaults()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
			{
				DisplayName.SetDefault("Argite Jackhamsaw");
			}
		}
		public override void SetDefaults()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
			{
				item.CloneDefaults(tremor.ItemType("ArgiteHamaxe"));
				item.channel = true;
				item.noUseGraphic = true;
				item.noMelee = true;
				item.useStyle = 5;
				item.UseSound = SoundID.Item23;
				item.shoot = mod.ProjectileType("ArgiteJackhamsaw");
				item.shootSpeed = 40f;
			}
		}
		public override void AddRecipes()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(tremor.ItemType("ArgiteBar"), 12);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}
}