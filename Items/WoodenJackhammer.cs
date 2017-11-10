using Terraria.ID;

using Terraria.ModLoader;



namespace BettertakeaPowerTool.Items

{

	public class WoodenJackhammer : ModItem

	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Jackhammer");
		}
		public override void SetDefaults()

		{

			item.CloneDefaults(ItemID.WoodenHammer);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("WoodenJackhammer");
			item.shootSpeed = 40f;
		}


		public override void AddRecipes()

		{

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 8);
			recipe.AddTile(TileID.WorkBenches);

			recipe.SetResult(this);

			recipe.AddRecipe();

		}

	}

}
