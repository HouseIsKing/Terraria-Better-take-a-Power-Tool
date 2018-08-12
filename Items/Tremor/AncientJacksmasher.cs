using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
	public class AncientJacksmasher : ModItem
	{
		public override void SetStaticDefaults()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
			{
				DisplayName.SetDefault("Ancient Jacksmasher");
			}
		}
		public override void SetDefaults()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
			{
				item.CloneDefaults(tremor.ItemType("AncientSmasher"));
				item.channel = true;
				item.noUseGraphic = true;
				item.noMelee = true;
				item.useStyle = 5;
				item.UseSound = SoundID.Item23;
				item.shoot = mod.ProjectileType("AncientJacksmasher");
				item.shootSpeed = 40f;
			}
		}
		public override void AddRecipes()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(tremor.ItemType("AncientTablet"), 16);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}
}