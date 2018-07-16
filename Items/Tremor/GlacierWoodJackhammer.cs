using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
	public class GlacierWoodJackhammer : ModItem
	{
		public override void SetStaticDefaults()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                DisplayName.SetDefault("Glacier Wood Jackhammer");
            }
		}
		public override void SetDefaults()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                item.CloneDefaults(tremor.ItemType("GlacierWoodHammer"));
                item.channel = true;
                item.noUseGraphic = true;
                item.noMelee = true;
                item.useStyle = 5;
                item.UseSound = SoundID.Item23;
                item.shoot = mod.ProjectileType("GlacierWoodJackhammer");
                item.shootSpeed = 40f;
            }
		}
        public override void AddRecipes()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(tremor.ItemType("GlacierWood"), 8);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}
