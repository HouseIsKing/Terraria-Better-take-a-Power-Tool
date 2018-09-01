using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items
{
	public class RichMahoganyJackhammer : ModItem
	{
		public override void SetStaticDefaults()
		{
                DisplayName.SetDefault("Rich Mahogany Jackhammer");
		}
		public override void SetDefaults()
		{
                item.CloneDefaults(ItemID.RichMahoganyHammer);
                item.channel = true;
                item.noUseGraphic = true;
                item.noMelee = true;
                item.useStyle = 5;
                item.UseSound = SoundID.Item23;
                item.shoot = mod.ProjectileType("RichMahoganyJackhammer");
                item.shootSpeed = 40f;
		}
        public override string Texture
        {
            get { return "BettertakeaPowerTool/Items/RichMahoganyJackhammer" + Config.OldWoodJackhammersSprite + Config.GustoneVersionWoodJackhammersSprite; }
        }
        public override void AddRecipes()
		{
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.RichMahogany, 8);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(this);
                recipe.AddRecipe();
		}
	}
}
