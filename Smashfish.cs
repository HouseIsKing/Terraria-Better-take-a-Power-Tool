using Terraria.ID;

using Terraria.ModLoader;



namespace BettertakeaPowerTool.Items

{

	public class Smashfish : ModItem

	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Smashfish");
		}
		public override void SetDefaults()

		{

			item.CloneDefaults(ItemID.Rockfish);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("Smashfish");
			item.shootSpeed = 40f;
		}


		public override void AddRecipes()

		{

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Rockfish);
			recipe.AddTile(TileID.DemonAltar);

			recipe.SetResult(this);

			recipe.AddRecipe();

			recipe = new ModRecipe(mod);

			recipe.AddIngredient(this);
			recipe.AddTile(TileID.DemonAltar);

			recipe.SetResult(ItemID.Rockfish);

			recipe.AddRecipe();

		}

	}

}
