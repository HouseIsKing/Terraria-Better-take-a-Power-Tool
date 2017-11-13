using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
	public class FungusDrill : ModItem
	{
        private static Mod tremor = ModLoader.GetMod("Tremor");
        public override void SetStaticDefaults()
		{
			if(tremor != null)
			{
				DisplayName.SetDefault("Fungus Drill");
			}
		}
		public override void SetDefaults()
		{
			if(tremor != null)
			{
				item.CloneDefaults(tremor.ItemType("FungusPickaxe"));
				item.channel = true;
				item.noUseGraphic = true;
				item.noMelee = true;
				item.useStyle = 5;
				item.knockBack = 0;
				item.UseSound = SoundID.Item23;
				item.shoot = mod.ProjectileType("FungusDrill");
				item.shootSpeed = 40f;
			}
		}
		public override void AddRecipes()
		{
			if(tremor != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(tremor.ItemType("FungusElement"), 13);
				recipe.AddIngredient(ItemID.GlowingMushroom, 10);
				recipe.AddIngredient(mod.ItemType("GoldDrill"));
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(this);
				recipe.AddRecipe();
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(tremor.ItemType("FungusElement"), 13);
				recipe.AddIngredient(ItemID.GlowingMushroom, 10);
				recipe.AddIngredient(mod.ItemType("PlatinumDrill"));
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}
}