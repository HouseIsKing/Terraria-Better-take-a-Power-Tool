using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace BettertakeaPowerTool.Items.Tremor
{
    public class JackSquasher : ModItem
    {
        public override void SetStaticDefaults()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                DisplayName.SetDefault("Jack Squasher");
                Tooltip.SetDefault("Strong enough to destroy Demon Altars");
                Tooltip.AddTranslation(GameCulture.German, "Stark genug, um Dämonenaltäre zu zerstören");
                Tooltip.AddTranslation(GameCulture.Italian, "Abbastanza forte per distruggere gli altari dei demoni");
                Tooltip.AddTranslation(GameCulture.French, "Assez puissant pour détruire les autels démoniaques");
                Tooltip.AddTranslation(GameCulture.Spanish, "Lo bastante sólido para destruir los altares demoníacos");
                Tooltip.AddTranslation(GameCulture.Russian, "Достаточно мощный, чтобы уничтожать алтари демонов");
                Tooltip.AddTranslation(GameCulture.Chinese, "强大到足以摧毁恶魔祭坛");
                Tooltip.AddTranslation(GameCulture.Portuguese, "Forte o suficiente para destruir Altares demoníacos");
                Tooltip.AddTranslation(GameCulture.Polish, "Potrafi niszczyć demoniczne ołtarze");
            }
        }
        public override void SetDefaults()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                item.CloneDefaults(tremor.ItemType("Squasher"));
                item.channel = true;
                item.noUseGraphic = true;
                item.noMelee = true;
                item.useStyle = 5;
                item.UseSound = SoundID.Item23;
                item.shoot = mod.ProjectileType("JackSquasher");
                item.shootSpeed = 40f;
            }
        }
        public override void AddRecipes()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                ModRecipe recipe = new ModRecipe(mod);
                if (Config.DommhammerjackhammerSettings == 2)
                {}
                else
                {
                    recipe.AddIngredient(mod.ItemType("Pwnjackhammer"));
                    recipe.AddIngredient(tremor.ItemType("DarkBulb"), 15);
                    recipe.AddIngredient(ItemID.Bone, 100);
                    recipe.AddTile(TileID.MythrilAnvil);
                    recipe.SetResult(this);
                    recipe.AddRecipe();
                }
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(mod.ItemType("Doomjackhammer"));
                recipe.AddIngredient(tremor.ItemType("DarkBulb"), 15);
                recipe.AddIngredient(ItemID.Bone, 100);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}