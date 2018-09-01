using Terraria.ID;
using Terraria.ModLoader;


namespace BettertakeaPowerTool.Items
{
    public class BorealWoodJackhammer : ModItem
    {
        public override void SetStaticDefaults()
        {
                DisplayName.SetDefault("Boreal Wood Jackhammer");
        }
        public override void SetDefaults()
        {
                item.CloneDefaults(ItemID.BorealWoodHammer);
                item.channel = true;
                item.noUseGraphic = true;
                item.noMelee = true;
                item.useStyle = 5;
                item.UseSound = SoundID.Item23;
                item.shoot = mod.ProjectileType("BorealWoodJackhammer");
                item.shootSpeed = 40f;
        }
        public override string Texture
        {
            get { return "BettertakeaPowerTool/Items/BorealWoodJackhammer" + Config.OldWoodJackhammersSprite + Config.GustoneVersionWoodJackhammersSprite; }
        }
        public override void AddRecipes()
        {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BorealWood, 8);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(this);
                recipe.AddRecipe();
        }
    }
}