using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items
{
	public class MoltenJackhamsaw : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Molten Jackhamsaw");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.MoltenHamaxe);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("MoltenJackhamsaw");
			item.shootSpeed = 40f;
		}
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
