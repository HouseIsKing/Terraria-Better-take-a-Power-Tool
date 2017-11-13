using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace BettertakeaPowerTool.Items
{ 
	public class Jackhamshroom : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jackhamshroom");
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
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Hammush);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("Jackhamshroom");
			item.shootSpeed = 40f;
		}
	}
}
