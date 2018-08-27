using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
    public class NovaDrill : ModItem
    {
        public override void SetStaticDefaults()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                DisplayName.SetDefault("Nova Drill");
            }
        }
        public override void SetDefaults()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                item.CloneDefaults(ItemID.SolarFlareDrill);
                item.shoot = mod.ProjectileType("NovaDrill");
            }
        }
        public override void AddRecipes()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(tremor.ItemType("NovaFragment"), 12);
                recipe.AddIngredient(ItemID.LunarBar, 10);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}
