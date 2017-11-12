using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace BettertakeaPowerTool.Items
{
	public class Drillsaw : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Drillsaw");
			Tooltip.SetDefault("Capable of mining Lihzahrd Bricks\n'Not to be confused with a Drax'");
			Tooltip.AddTranslation(GameCulture.German, "Du kannst Lihzahrdziegel abbauen\n‚Nicht zu verwechseln mit einer Drax‘");
			Tooltip.AddTranslation(GameCulture.Italian, "Consente di estrarre mattoni rettiliani\nDa non confondere con il Perforascia");
			Tooltip.AddTranslation(GameCulture.French, "Peut extraire des briques de Lihzhard\nÀ ne pas confondre avec une forche");
			Tooltip.AddTranslation(GameCulture.Spanish, "Capaz de extraer ladrillos de lihzahrd\nNo se debe confundir con un taladro hacha");
			Tooltip.AddTranslation(GameCulture.Russian, "Может добывать кирпичи ящеров\nHе путать c Mолотобур");
			Tooltip.AddTranslation(GameCulture.Chinese, "可开采丛林蜥蜴砖\n“不要”");
			Tooltip.AddTranslation(GameCulture.Portuguese, "Capaz de minerar tijolos lagharto\n'Não confundir com uma Drax'");
			Tooltip.AddTranslation(GameCulture.Polish, "Może kopać jaszczuhrze cegły\n„Nie mylić z Świdrolof“");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Picksaw);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("Drillsaw");
			item.shootSpeed = 40f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Picksaw, 1);
			recipe.AddTile(TileID.LihzahrdAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this);
			recipe.AddTile(TileID.LihzahrdAltar);
			recipe.SetResult(ItemID.Picksaw, 1);
			recipe.AddRecipe();
		}
	}
}
