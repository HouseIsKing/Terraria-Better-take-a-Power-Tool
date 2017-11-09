using Terraria.ID;

using Terraria.ModLoader;



namespace BettertakeaPowerTool.Items

{

	public class EbonwoodJackhammer : ModItem

	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ebonwood Jackhammer");
		}
		public override void SetDefaults()

		{

			item.CloneDefaults(ItemID.EbonwoodHammer);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("EbonwoodJackhammer");
			item.shootSpeed = 40f;
		}


		public override void AddRecipes()

		{

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ebonwood, 8);
			recipe.AddTile(TileID.WorkBenches);

			recipe.SetResult(this);

			recipe.AddRecipe();

		}

	}

}
