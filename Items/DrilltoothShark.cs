using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items
{
	public class DrilltoothShark : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Drilltooth Shark");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ReaverShark);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.knockBack = 0;
			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("DrilltoothShark");
			item.shootSpeed = 40f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ReaverShark, 1);
			recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(ItemID.ReaverShark, 1);
            recipe.AddRecipe();
		}
	}
}
