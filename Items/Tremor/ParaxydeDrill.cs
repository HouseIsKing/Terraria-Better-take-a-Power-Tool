using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
    public class ParaxydeDrill : ModItem
    {
        public override void SetStaticDefaults()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                DisplayName.SetDefault("Paraxyde Drill");
            }
        }
        public override void SetDefaults()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                item.CloneDefaults(tremor.ItemType("ParaxydePickaxe"));
                item.damage = 37;
                item.channel = true;
                item.noUseGraphic = true;
                item.noMelee = true;
                item.useStyle = 5;
                item.knockBack = 1;
                item.UseSound = SoundID.Item23;
                item.shoot = mod.ProjectileType("ParaxydeDrill");
                item.shootSpeed = 40f;
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
