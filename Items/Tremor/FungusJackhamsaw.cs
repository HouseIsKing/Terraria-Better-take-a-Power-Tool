using Terraria.ID;

using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
	public class FungusJackhamsaw : ModItem

	{

		public override void SetStaticDefaults()
		{
			Mod tremor = ModLoader.GetMod("Tremor");
			if(tremor != null)
			{
				DisplayName.SetDefault("Fungus Jackhamsaw");
			}
		}
		public override void SetDefaults()

		{
			Mod tremor = ModLoader.GetMod("Tremor");
			if(tremor != null)
			{
				item.CloneDefaults(ModLoader.GetMod("Tremor").ItemType("FungusHamaxe"));
				item.channel = true;
				item.noUseGraphic = true;
				item.noMelee = true;
				item.useStyle = 5;
				item.UseSound = SoundID.Item23;
				item.shoot = mod.ProjectileType("FungusJackhamsaw");
				item.shootSpeed = 40f;
			}
		}

		public override void AddRecipes()

		{
			Mod tremor = ModLoader.GetMod("Tremor");
			if(tremor != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ModLoader.GetMod("Tremor").ItemType("FungusElement"), 11);
				recipe.AddIngredient(ItemID.GlowingMushroom, 8);
				recipe.AddIngredient(mod.ItemType("GoldChainsaw"));
				recipe.AddIngredient(mod.ItemType("GoldJackhammer"));
				recipe.AddTile(TileID.Anvils);

				recipe.SetResult(this);

				recipe.AddRecipe();

				recipe = new ModRecipe(mod);
				recipe.AddIngredient(ModLoader.GetMod("Tremor").ItemType("FungusElement"), 11);
				recipe.AddIngredient(ItemID.GlowingMushroom, 8);
				recipe.AddIngredient(mod.ItemType("PlatinumChainsaw"));
				recipe.AddIngredient(mod.ItemType("PlatinumJackhammer"));
				recipe.AddTile(TileID.Anvils);

				recipe.SetResult(this);

				recipe.AddRecipe();

			}
		}

	}

}