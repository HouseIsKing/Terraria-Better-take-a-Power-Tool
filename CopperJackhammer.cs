using Terraria.ID;

using Terraria.ModLoader;



namespace BettertakeaPowerTool.Items

{

	public class CopperJackhammer : ModItem

	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Copper Jackhammer");
		}
		public override void SetDefaults()

		{

			item.CloneDefaults(ItemID.CopperHammer);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("CopperJackhammer");
			item.shootSpeed = 40f;
		}


		public override void AddRecipes()

		{

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 10);

			recipe.AddRecipeGroup("Wood", 3);
			recipe.AddTile(TileID.Anvils);

			recipe.SetResult(this);

			recipe.AddRecipe();

		}

	}

}
