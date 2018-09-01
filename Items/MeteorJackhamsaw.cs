using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items
{
	public class MeteorJackhamsaw : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Meteor Jackhamsaw");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.MeteorHamaxe);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("MeteorJackhamsaw");
			item.shootSpeed = 40f;
		}
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MeteoriteBar, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
