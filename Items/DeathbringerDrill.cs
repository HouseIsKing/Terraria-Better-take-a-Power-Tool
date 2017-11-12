using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace BettertakeaPowerTool.Items
{
	public class DeathbringerDrill : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Deathbringer Drill");
			Tooltip.SetDefault("Able to mine Hellstone");
			Tooltip.AddTranslation(GameCulture.German, "Kann Höllenstein abbauen");
			Tooltip.AddTranslation(GameCulture.Italian, "In grado di estrarre la pietra infernale");
			Tooltip.AddTranslation(GameCulture.French, "Peut extraire de la pierre infernale");
			Tooltip.AddTranslation(GameCulture.Spanish, "Permite extraer piedra infernal");
			Tooltip.AddTranslation(GameCulture.Russian, "Позволяет добывать адский камень");
			Tooltip.AddTranslation(GameCulture.Chinese, "能够开采狱石");
			Tooltip.AddTranslation(GameCulture.Portuguese, "Permite a mineração de pedras infernais");
			Tooltip.AddTranslation(GameCulture.Polish, "Może wydobywać piekielny kamień");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.DeathbringerPickaxe);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.knockBack = 0;
			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("DeathbringerDrill");
			item.shootSpeed = 40f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimtaneBar, 12);
			recipe.AddIngredient(ItemID.TissueSample, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
