using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items
{
	public class WarChainsawoftheNight : ModItem
	{
		public override void SetStaticDefaults()
		{
                DisplayName.SetDefault("War Chainsaw of the Night");
		}
		public override void SetDefaults()
		{
                item.CloneDefaults(ItemID.WarAxeoftheNight);
                item.channel = true;
                item.noUseGraphic = true;
                item.noMelee = true;
                item.useStyle = 5;
                item.knockBack = 1.9f;
                item.UseSound = SoundID.Item23;
                item.shoot = mod.ProjectileType("WarChainsawoftheNight");
                item.shootSpeed = 40f;
		}
        public override string Texture
        {
            get { return "BettertakeaPowerTool/Items/WarChainsawoftheNight" + Config.OldWarChainsawoftheNightSprite; }
        }
        public override void AddRecipes()
		{
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.DemoniteBar, 10);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(this);
                recipe.AddRecipe();
		}
	}
}
