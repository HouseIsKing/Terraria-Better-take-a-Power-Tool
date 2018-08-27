using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items
{
	public class ShroomiteDiggingDrillclaw : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shroomite Clawed Drill");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ShroomiteDiggingClaw);
			item.damage = 40;
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.knockBack = 2;
            item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("ShroomiteDiggingDrillclaw");
			item.shootSpeed = 40f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShroomiteBar, 18);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
