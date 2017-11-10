using Terraria.ID;

using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
	public class NightTwilight : ModItem

	{

		public override void SetStaticDefaults()
		{
			Mod tremor = ModLoader.GetMod("Tremor");
			if(tremor != null)
			{
				DisplayName.SetDefault("Night Twilight");
			}
		}
		public override void SetDefaults()

		{
			Mod tremor = ModLoader.GetMod("Tremor");
			if(tremor != null)
			{
				item.CloneDefaults(ModLoader.GetMod("Tremor").ItemType("NightDusk"));
				item.channel = true;
				item.noUseGraphic = true;
				item.noMelee = true;
				item.useStyle = 5;
				item.knockBack = 0;

				item.UseSound = SoundID.Item23;
				item.shoot = mod.ProjectileType("NightTwilight");
				item.shootSpeed = 40f;
			}
		}

		public override void AddRecipes()

		{
			Mod tremor = ModLoader.GetMod("Tremor");
			if(tremor != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(mod.ItemType("MoltenDrill"));
				recipe.AddIngredient(mod.ItemType("BoneDrill"));
				recipe.AddIngredient(mod.ItemType("DrillofBloom"));
				recipe.AddIngredient(mod.ItemType("NightmareDrill"));
				recipe.AddTile(TileID.DemonAltar);

				recipe.SetResult(this);

				recipe.AddRecipe();

			}
		}

	}

}