using Terraria.ID;

using Terraria.ModLoader;



namespace BettertakeaPowerTool.Items

{

	public class TheCrusher : ModItem

	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Crusher");
		}
		public override void SetDefaults()

		{

			item.CloneDefaults(ItemID.TheBreaker);
			item.damage = 18;

			item.useTime = 17;

			item.useAnimation = 33;
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;

			item.knockBack = 5.2f;

			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("TheCrusher");
			item.shootSpeed = 40f;
		}


		public override void AddRecipes()

		{

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 10);

			recipe.AddIngredient(ItemID.ShadowScale, 5);
			recipe.AddTile(TileID.Anvils);

			recipe.SetResult(this);

			recipe.AddRecipe();

		}

	}

}