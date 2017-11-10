using Terraria.ID;

using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
	public class DrillofBloom : ModItem

	{

		public override void SetStaticDefaults()
		{
			Mod tremor = ModLoader.GetMod("Tremor");
			if(tremor != null)
			{
				DisplayName.SetDefault("Drill of Bloom");
			}
		}
		public override void SetDefaults()

		{
			Mod tremor = ModLoader.GetMod("Tremor");
			if(tremor != null)
			{
				item.CloneDefaults(ModLoader.GetMod("Tremor").ItemType("PickaxeofBloom"));
				item.channel = true;
				item.noUseGraphic = true;
				item.noMelee = true;
				item.useStyle = 5;
				item.knockBack = 0;

				item.UseSound = SoundID.Item23;
				item.shoot = mod.ProjectileType("DrillofBloom");
				item.shootSpeed = 40f;
			}
		}

		public override void AddRecipes()

		{
			Mod tremor = ModLoader.GetMod("Tremor");
			if(tremor != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ModLoader.GetMod("Tremor").ItemType("PickaxeofBloom"));

				recipe.AddTile(TileID.DemonAltar);

				recipe.SetResult(this);

				recipe.AddRecipe();

				recipe = new ModRecipe(mod);

				recipe.AddIngredient(this);

				recipe.AddTile(TileID.DemonAltar);

				recipe.SetResult(ModLoader.GetMod("Tremor").ItemType("PickaxeofBloom"));

				recipe.AddRecipe();

			}
		}

	}

}