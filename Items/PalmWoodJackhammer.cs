using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items
{
	public class PalmWoodJackhammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Palm Wood Jackhammer");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.PalmWoodHammer);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("PalmWoodJackhammer");
			item.shootSpeed = 40f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PalmWood, 8);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
