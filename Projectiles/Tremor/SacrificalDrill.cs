using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
	public class SacrificalDrill : ModItem
	{
        private static Mod tremor = ModLoader.GetMod("Tremor");
        public override void SetStaticDefaults()
		{
			if(tremor != null)
			{
				DisplayName.SetDefault("Sacrifical Drill");
			}
		}
		public override void SetDefaults()
		{
			if(tremor != null)
			{
				item.CloneDefaults(tremor.ItemType("SacrificalPickaxe"));
				item.channel = true;
				item.noUseGraphic = true;
				item.noMelee = true;
				item.useStyle = 5;
				item.knockBack = 0;
				item.UseSound = SoundID.Item23;
				item.shoot = mod.ProjectileType("SacrificalDrill");
				item.shootSpeed = 40f;
			}
		}
		public override void AddRecipes()
		{
			if(tremor != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(mod.ItemType("MoltenDrill"));
				recipe.AddIngredient(mod.ItemType("BoneDrill"));
				recipe.AddIngredient(mod.ItemType("DrillofBloom"));
				recipe.AddIngredient(mod.ItemType("DeathbringerDrill"));
				recipe.AddTile(TileID.DemonAltar);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}
}