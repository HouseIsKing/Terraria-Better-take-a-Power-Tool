using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items
{
	public class TungstenJackhammer : ModItem
	{
		public override void SetStaticDefaults()
		{
                DisplayName.SetDefault("Tungsten Jackhammer");
		}
		public override void SetDefaults()
		{
                item.CloneDefaults(ItemID.TungstenHammer);
                item.channel = true;
                item.noUseGraphic = true;
                item.noMelee = true;
                item.useStyle = 5;
                item.UseSound = SoundID.Item23;
                item.shoot = mod.ProjectileType("TungstenJackhammer");
                item.shootSpeed = 40f; 
		}
        public override string Texture
        {
            get { return "BettertakeaPowerTool/Items/TungstenJackhammer" + Config.OldMetalJackhammersSprite + Config.GustoneVersionMetalJackhammersSprite; }
        }
        public override void AddRecipes()
		{
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.TungstenBar, 10);
                recipe.AddRecipeGroup("Wood", 3);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(this);
                recipe.AddRecipe();
		}
	}
}
