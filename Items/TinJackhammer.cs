using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items
{
	public class TinJackhammer : ModItem
	{
		public override void SetStaticDefaults()
		{
                DisplayName.SetDefault("Tin Jackhammer");
		}
		public override void SetDefaults()
		{
                item.CloneDefaults(ItemID.TinHammer);
                item.channel = true;
                item.noUseGraphic = true;
                item.noMelee = true;
                item.useStyle = 5;
                item.UseSound = SoundID.Item23;
                item.shoot = mod.ProjectileType("TinJackhammer");
                item.shootSpeed = 40f;
		}
        public override string Texture
        {
            get { return "BettertakeaPowerTool/Items/TinJackhammer" + Config.OldMetalJackhammersSprite + Config.GustoneVersionMetalJackhammersSprite; }
        }
        public override void AddRecipes()
		{
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.TinBar, 10);
                recipe.AddRecipeGroup("Wood", 3);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(this);
                recipe.AddRecipe();
		}
	}
}
