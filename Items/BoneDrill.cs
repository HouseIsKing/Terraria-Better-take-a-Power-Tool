using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items
{
	public class BoneDrill : ModItem
	{
		public override void SetStaticDefaults()
		{//sets display name of the item
			DisplayName.SetDefault("Bone Drill");
		}
		public override void SetDefaults()
		{//set item defaults
			item.CloneDefaults(ItemID.BonePickaxe);
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.useStyle = 5;
			item.knockBack = 0;
			item.UseSound = SoundID.Item23;
			item.shoot = mod.ProjectileType("BoneDrill");
			item.shootSpeed = 40f;
		}
		public override void AddRecipes()
		{//adds recepie only if tremor mod exists
			Mod tremor = ModLoader.GetMod("Tremor");
			if(tremor != null)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.Bone, 80);
				recipe.AddTile(TileID.BoneWelder);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}

	}

}
