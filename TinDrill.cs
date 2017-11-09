using Terraria.ID;

using Terraria.ModLoader;



namespace BettertakeaPowerTool.Items

{

	public class TinDrill : ModItem

	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tin Drill");
		}
		public override void SetDefaults()

		{

			item.CloneDefaults(ItemID.TinPickaxe);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.knockBack = 0;

			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("TinDrill");
			item.shootSpeed = 40f;
		}


		public override void AddRecipes()

		{

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar, 12);

			recipe.AddRecipeGroup("Wood", 4);
			recipe.AddTile(TileID.Anvils);

			recipe.SetResult(this);

			recipe.AddRecipe();

		}

	}

}
