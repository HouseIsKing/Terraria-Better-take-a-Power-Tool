using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items
{
	public class PearlwoodJackhammer : ModItem
	{
		public override void SetStaticDefaults()
		{
                DisplayName.SetDefault("Pearlwood Jackhammer");
		}
		public override void SetDefaults()
		{
                item.CloneDefaults(ItemID.PearlwoodHammer);
                item.channel = true;
                item.noUseGraphic = true;
                item.noMelee = true;
                item.useStyle = 5;
                item.UseSound = SoundID.Item23;
                item.shoot = mod.ProjectileType("PearlwoodJackhammer");
                item.shootSpeed = 40f;
		}
        public override string Texture
        {
            get { return "BettertakeaPowerTool/Items/PearlwoodJackhammer" + Config.OldWoodJackhammersSprite + Config.GustoneVersionWoodJackhammersSprite; }
        }
        public override void AddRecipes()
		{
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.Pearlwood, 8);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(this);
                recipe.AddRecipe();
    	}
	}
}
