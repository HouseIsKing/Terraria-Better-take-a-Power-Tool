using Terraria.ID;

using Terraria.ModLoader;



namespace BettertakeaPowerTool.Items

{

	public class SpectreDrill : ModItem

	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spectre Drill");
		}
		public override void SetDefaults()

		{

			item.CloneDefaults(ItemID.SpectrePickaxe);
			item.damage = 27;

			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.knockBack = 1.25f;

			item.UseSound = SoundID.Item23;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("SpectreDrill");
			item.shootSpeed = 40f;
		}


		public override void AddRecipes()

		{

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpectreBar, 18);

			recipe.AddTile(TileID.MythrilAnvil);

			recipe.SetResult(this);

			recipe.AddRecipe();

		}

	}

}
