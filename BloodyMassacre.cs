using Terraria.ID;

using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items

{

	public class BloodyMassacre : ModItem

	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bloody Massacre");
		}
		public override void SetDefaults()

		{

			item.CloneDefaults(ItemID.BloodLustCluster);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.knockBack = 2.05f;

			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("BloodyMassacre");
			item.shootSpeed = 40f;
		}


		public override void AddRecipes()

		{

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimtaneBar, 10);
			recipe.AddTile(TileID.Anvils);

			recipe.SetResult(this);

			recipe.AddRecipe();

		}

	}

}