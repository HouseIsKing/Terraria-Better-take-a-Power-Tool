using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
	public class CoralDrill : ModItem
	{
        private static Mod tremor = ModLoader.GetMod("Tremor");
        public override void SetStaticDefaults()
		{
			if(tremor != null)
			{
				DisplayName.SetDefault("Coral Drill");
			}
		}
		public override void SetDefaults()
		{
			if(tremor != null)
			{
				item.CloneDefaults(tremor.ItemType("CoralPickaxe"));
				item.channel = true;
				item.noUseGraphic = true;
				item.noMelee = true;
				item.useStyle = 5;
				item.knockBack = 0;
				item.UseSound = SoundID.Item23;
				item.shoot = mod.ProjectileType("CoralDrill");
				item.shootSpeed = 40f;
			}
		}
		public override void AddRecipes()
		{
			if(tremor != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.Coral, 9);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}
}