using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
	public class Sporchainsaw : ModItem
	{
        public override void SetStaticDefaults()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
			{
				DisplayName.SetDefault("Sporchainsaw");
			}
		}
		public override void SetDefaults()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
			{
				item.CloneDefaults(tremor.ItemType("Sporaxe"));
				item.channel = true;
				item.noUseGraphic = true;
				item.noMelee = true;
				item.useStyle = 5;
				item.knockBack = 0;
				item.UseSound = SoundID.Item23;
				item.shoot = mod.ProjectileType("Sporchainsaw");
				item.shootSpeed = 40f;
			}
		}
		public override void AddRecipes()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(tremor.ItemType("JungleAlloy"), 1);
                recipe.AddIngredient(ItemID.Stinger, 4);
                recipe.AddIngredient(ItemID.Vine, 3);
                recipe.AddIngredient(ItemID.JungleSpores, 10);
                recipe.AddTile(tremor.TileType("GreatAnvilTile"));
                recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}
}