using System.Collections.Generic;

using Terraria.ID;
using Terraria.ModLoader;
namespace BettertakeaPowerTool
{
	class BettertakeaPowerTool : Mod

	{
		public BettertakeaPowerTool()

		{

			Properties = new ModProperties()

			{

				Autoload = true,

				AutoloadGores = true,

				AutoloadSounds = true

			};

		}
		public override void Load()

		{

			var list = new List<short>(Extensions.LunarTools);

			list.ForEach(x =>

			ItemID.Sets.Deprecated[x] = false);

		}


		public override void AddRecipes()

		{

			Extensions.DestroyRecipes();

			Extensions.MakeSolarRecipes(this);

			Extensions.MakeNebulaRecipes(this);

			Extensions.MakeVortexRecipes(this);

			Extensions.MakeStardustRecipes(this);

		}


	}


	internal static class Extensions

	{

		public static short[] LunarTools =

		{


			ItemID.SolarFlareDrill,

			ItemID.NebulaDrill,

			ItemID.VortexDrill,

			ItemID.StardustDrill,
		};


		public const short LunarBar = 3467;

		public const short AncientManipulator = 412;


		public static void MakeRecipe(ModRecipe recipe, short fragmentType, int fragmentAmount, int barAmount)

		{

			recipe.AddIngredient(fragmentType, fragmentAmount);

			recipe.AddIngredient(LunarBar, barAmount);

			recipe.AddTile(AncientManipulator);

		}


		public static void DestroyRecipes()

		{

			foreach (var lunarTool in LunarTools)

			{

				var finder = new RecipeFinder();

				finder.SetResult(lunarTool);

				var recipes = finder.SearchRecipes();

				recipes.ForEach(x =>

				{

					var editor = new RecipeEditor(x);

					editor.DeleteRecipe();

				});

			}

		}


		public static void MakeSolarRecipes(Mod mod)

		{


			var recipe = new ModRecipe(mod);
			MakeRecipe(recipe, ItemID.FragmentSolar, 12, 10);

			recipe.SetResult(ItemID.SolarFlareDrill);

			recipe.AddRecipe();


		}


		public static void MakeNebulaRecipes(Mod mod)

		{

			var recipe = new ModRecipe(mod);
			MakeRecipe(recipe, ItemID.FragmentNebula, 12, 10);

			recipe.SetResult(ItemID.NebulaDrill);

			recipe.AddRecipe();


		}



		public static void MakeVortexRecipes(Mod mod)

		{

			var recipe = new ModRecipe(mod);

			MakeRecipe(recipe, ItemID.FragmentVortex, 12, 10);

			recipe.SetResult(ItemID.VortexDrill);

			recipe.AddRecipe();
		}
		public static void MakeStardustRecipes(Mod mod)

		{

		
			var recipe = new ModRecipe(mod);
			MakeRecipe(recipe, ItemID.FragmentStardust, 12, 10);

			recipe.SetResult(ItemID.StardustDrill);

			recipe.AddRecipe();


		}
	
	}

}