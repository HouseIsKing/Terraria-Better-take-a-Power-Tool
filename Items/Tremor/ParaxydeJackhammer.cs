using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
    public class ParaxydeJackhammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                DisplayName.SetDefault("Paraxyde Jackhammer");
            }
        }
        public override void SetDefaults()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                item.CloneDefaults(tremor.ItemType("ParaxydeHammer"));
                item.damage = 19;
                item.channel = true;
                item.noUseGraphic = true;
                item.noMelee = true;
                item.useStyle = 5;
                item.UseSound = SoundID.Item23;
                item.shoot = mod.ProjectileType("ParaxydeJackhammer");
                item.shootSpeed = 40f;
                item.knockBack = 2.8f;
                item.useTime = 9;
                item.useAnimation = 6;
            }
        }
        public override void AddRecipes()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(tremor.ItemType("ParaxydeShard"), 12);
                recipe.AddTile(tremor.TileType("AlchematorTile"));
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}
