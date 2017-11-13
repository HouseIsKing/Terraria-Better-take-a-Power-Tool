using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
    public class ParaxydeChainsaw : ModItem
    {
        public override void SetStaticDefaults()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                DisplayName.SetDefault("Paraxyde Chainsaw");
            }
        }
        public override void SetDefaults()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                item.CloneDefaults(tremor.ItemType("ParaxydeAxe"));
                item.damage = 46;
                item.channel = true;
                item.noUseGraphic = true;
                item.noMelee = true;
                item.useStyle = 5;
                item.UseSound = SoundID.Item23;
                item.shoot = mod.ProjectileType("ParaxydeChainsaw");
                item.shootSpeed = 40f;
                item.knockBack = 2.6f;
                item.useTime = 17;
                item.useAnimation = 11;
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
