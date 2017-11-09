using Terraria.ID;

using Terraria.ModLoader;



namespace BettertakeaPowerTool.Items

{

	public class GoldChainsaw : ModItem

	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gold Chainsaw");
		}
		public override void SetDefaults()

		{

			item.CloneDefaults(ItemID.GoldAxe);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.knockBack = 1.05f;

			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("GoldChainsaw");
			item.shootSpeed = 40f;
		}


		public override void AddRecipes()

		{

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 9);
			recipe.AddRecipeGroup("Wood", 3);
			recipe.AddTile(TileID.Anvils);

			recipe.SetResult(this);

			recipe.AddRecipe();

		}

	}

}
