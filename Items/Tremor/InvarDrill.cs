using Terraria.ID;

using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
	public class InvarDrill : ModItem

	{

		public override void SetStaticDefaults()
		{
			Mod tremor = ModLoader.GetMod("Tremor");
			if(tremor != null)
			{
				DisplayName.SetDefault("Invar Drill");
			}
		}
		public override void SetDefaults()

		{
			Mod tremor = ModLoader.GetMod("Tremor");
			if(tremor != null)
			{
				item.CloneDefaults(ModLoader.GetMod("Tremor").ItemType("InvarPickaxe"));
				item.channel = true;
				item.noUseGraphic = true;
				item.noMelee = true;
				item.useStyle = 5;
				item.knockBack = 0;

				item.UseSound = SoundID.Item23;
				item.shoot = mod.ProjectileType("InvarDrill");
				item.shootSpeed = 40f;
			}
		}

		public override void AddRecipes()

		{
			Mod tremor = ModLoader.GetMod("Tremor");
			if(tremor != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ModLoader.GetMod("Tremor").ItemType("InvarBar"), 12);
				recipe.AddRecipeGroup("Wood", 3);
				recipe.AddTile(TileID.Anvils);

				recipe.SetResult(this);

				recipe.AddRecipe();

			}
		}

	}

}