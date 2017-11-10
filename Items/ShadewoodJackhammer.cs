using Terraria.ID;

using Terraria.ModLoader;



namespace BettertakeaPowerTool.Items

{

	public class ShadewoodJackhammer : ModItem

	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shadewood Jackhammer");
		}
		public override void SetDefaults()

		{

			item.CloneDefaults(ItemID.ShadewoodHammer);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("ShadewoodJackhammer");
			item.shootSpeed = 40f;
		}


		public override void AddRecipes()

		{

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Shadewood, 8);
			recipe.AddTile(TileID.WorkBenches);

			recipe.SetResult(this);

			recipe.AddRecipe();

		}

	}

}
