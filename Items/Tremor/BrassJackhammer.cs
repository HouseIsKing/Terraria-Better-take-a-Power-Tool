using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
    public class BrassJackhammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                DisplayName.SetDefault("Brass Jackhammer");
            }
        }
        public override void SetDefaults()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                item.CloneDefaults(tremor.ItemType("BrassHammer"));
                item.channel = true;
                item.noUseGraphic = true;
                item.noMelee = true;
                item.useStyle = 5;
                item.UseSound = SoundID.Item23;
                item.shoot = mod.ProjectileType("BrassJackhammer");
                item.shootSpeed = 40f;
            }
        }
        public override void AddRecipes()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(tremor.ItemType("BrassBar"), 10);
                recipe.AddIngredient(ItemID.Cog, 10);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}
