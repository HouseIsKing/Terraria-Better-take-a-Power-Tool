using Terraria.ID;

using Terraria.ModLoader;



namespace BettertakeaPowerTool.Items

{

	public class TinChainsaw : ModItem

	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tin Chainsaw");
		}
		public override void SetDefaults()

		{

			item.CloneDefaults(ItemID.TinAxe);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.knockBack = 0;

			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("TinChainsaw");
			item.shootSpeed = 40f;
		}


		public override void AddRecipes()

		{

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar, 9);
			recipe.AddRecipeGroup("Wood", 3);
			recipe.AddTile(TileID.Anvils);

			recipe.SetResult(this);

			recipe.AddRecipe();

		}

	}

}
