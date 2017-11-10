using Terraria.ID;

using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
	public class Magsaw : ModItem

	{

		public override void SetStaticDefaults()
		{
			Mod tremor = ModLoader.GetMod("Tremor");
			if(tremor != null)
			{
				DisplayName.SetDefault("Magsaw");
			}
		}
		public override void SetDefaults()

		{
			Mod tremor = ModLoader.GetMod("Tremor");
			if(tremor != null)
			{
				item.CloneDefaults(ModLoader.GetMod("Tremor").ItemType("Magmaxe"));
				item.damage = 45;

				item.channel = true;
				item.noUseGraphic = true;
				item.noMelee = true;
				item.useStyle = 5;
				item.UseSound = SoundID.Item23;
				item.shoot = mod.ProjectileType("Magsaw");
				item.shootSpeed = 40f;
				item.knockBack = 3.6f;
				item.useTime = 33;
				item.useAnimation = 27;
			}
		}

		public override void AddRecipes()

		{
			Mod tremor = ModLoader.GetMod("Tremor");
			if(tremor != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ModLoader.GetMod("Tremor").ItemType("MagmoniumBar"), 10);
				recipe.AddTile(TileID.MythrilAnvil);

				recipe.SetResult(this);

				recipe.AddRecipe();

			}
		}

	}

}