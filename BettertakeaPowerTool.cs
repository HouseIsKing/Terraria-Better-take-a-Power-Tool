using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace BettertakeaPowerTool
{
	class BettertakeaPowerTool : Mod
	{
        public static string ConfigFileRelativePath
        {
            get { return "Mod Configs/BettertakeaPowerTool.json"; }
        }
        public static void ReloadConfigFromFile()
        {
            // Define implementation to reload your mod's config data from file
        }
        public static string GithubUserName { get { return "dennisw100"; } }
		public static string GithubProjectName { get { return "Terraria-Better-take-a-Power-Tool"; } }
		public BettertakeaPowerTool()
		{//sets propeties of the mod
			Properties = new ModProperties()
            {
                Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
        public override void Load()
		{
            Config.Load();
            List<short> list = new List<short>(Extensions.LunarTools);
			list.ForEach(x =>ItemID.Sets.Deprecated[x] = false);
		}
        public override void PostAddRecipes()
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null && Config.DommhammerjackhammerSettings == 2)
            {
                RecipeFinder finder = new RecipeFinder(); // make a new RecipeFinder
                finder.AddIngredient(ItemID.Pwnhammer); // add a new recipe group, in this case the vanilla one for iron or lead bars.
                finder.AddIngredient(tremor.ItemType("DarkBulb"), 15);
                finder.AddIngredient(ItemID.Bone, 100);
                finder.AddTile(TileID.MythrilAnvil); // add a required tile, any anvil
                finder.SetResult(tremor.ItemType("Squasher")); // set the result to be 10 chains
                Recipe exactRecipe = finder.FindExactRecipe(); // try to find the exact recipe matching our criteria

                bool isRecipeFound = exactRecipe != null; // if our recipe is not null, it means we found the exact recipe
                if (isRecipeFound) // since our recipe is found, we can continue
                {
                    RecipeEditor editor = new RecipeEditor(exactRecipe); // for our recipe, make a new RecipeEditor
                    editor.DeleteRecipe(); // delete the recipe
                }
            }
        }
        public override void AddRecipes()
		{//adds crafting recepies
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
			foreach (short lunarTool in LunarTools)
			{
				RecipeFinder finder = new RecipeFinder();
                finder.SetResult(lunarTool);
				List<Terraria.Recipe> recipes = finder.SearchRecipes();
				recipes.ForEach(x => { var editor = new RecipeEditor(x); editor.DeleteRecipe();});
			} 
        }
        public static void MakeSolarRecipes(Mod mod)
        {
            ModRecipe recipe = new ModRecipe(mod);
            MakeRecipe(recipe, ItemID.FragmentSolar, 12, 10);
            recipe.SetResult(ItemID.SolarFlareDrill);
            recipe.AddRecipe();
        }
		public static void MakeNebulaRecipes(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			MakeRecipe(recipe, ItemID.FragmentNebula, 12, 10);
			recipe.SetResult(ItemID.NebulaDrill);
			recipe.AddRecipe();
		}
        public static void MakeVortexRecipes(Mod mod)
        {
            ModRecipe recipe = new ModRecipe(mod);
            MakeRecipe(recipe, ItemID.FragmentVortex, 12, 10);
            recipe.SetResult(ItemID.VortexDrill);
            recipe.AddRecipe();
        }
		public static void MakeStardustRecipes(Mod mod)
		{
			ModRecipe recipe = new ModRecipe(mod);
			MakeRecipe(recipe, ItemID.FragmentStardust, 12, 10);
			recipe.SetResult(ItemID.StardustDrill);
			recipe.AddRecipe();
		}
	}
}