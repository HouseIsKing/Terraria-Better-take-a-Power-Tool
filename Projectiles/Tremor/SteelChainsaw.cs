using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
	public class SteelChainsaw : ModItem
	{
        private static Mod tremor = ModLoader.GetMod("Tremor");
        public override void SetStaticDefaults()
		{
			if(tremor != null)
			{
				DisplayName.SetDefault("Steel Chainsaw");
			}
		}
		public override void SetDefaults()
		{
			if(tremor != null)
			{
				item.CloneDefaults(tremor.ItemType("SteelAxe"));
				item.channel = true;
				item.noUseGraphic = true;
				item.noMelee = true;
				item.useStyle = 5;
				item.knockBack = 0;

				item.UseSound = SoundID.Item23;
				item.shoot = mod.ProjectileType("SteelChainsaw");
				item.shootSpeed = 40f;
			}
		}
		public override void AddRecipes()
		{
			if(tremor != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(tremor.ItemType("SteelBar"), 11);
				recipe.AddRecipeGroup("Wood", 3);
				recipe.AddTile(TileID.Anvils);
                recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}
}