using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace BettertakeaPowerTool.Items
{
	public class CandyCaneDrill : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Candy Cane Drill");
			Tooltip.SetDefault("Can mine Meteorite");
			Tooltip.AddTranslation(GameCulture.German, "Kann Meteorite abbauen");
			Tooltip.AddTranslation(GameCulture.Italian, "Può estrarre meteorite");
			Tooltip.AddTranslation(GameCulture.French, "Peut extraire de la météorite");
			Tooltip.AddTranslation(GameCulture.Spanish, "Permite excavar meteoritos");
			Tooltip.AddTranslation(GameCulture.Russian, "Может добывать метеорит");
			Tooltip.AddTranslation(GameCulture.Chinese, "可开采陨石");
			Tooltip.AddTranslation(GameCulture.Portuguese, "Pode minerar meteoritos");
			Tooltip.AddTranslation(GameCulture.Polish, "Może wydobywać meteoryt");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.CnadyCanePickaxe);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.knockBack = 0;
			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("CandyCaneDrill");
			item.shootSpeed = 40f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CnadyCanePickaxe, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CnadyCanePickaxe, 1);
			recipe.AddRecipe();
		}
	}
}
