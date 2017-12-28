using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items
{
	public class VortexJackhamsaw : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vortex Jackhamsaw");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.LunarHamaxeVortex);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("VortexJackhamsaw");
			item.shootSpeed = 40f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentVortex, 14);
			recipe.AddIngredient(ItemID.LunarBar, 12);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
