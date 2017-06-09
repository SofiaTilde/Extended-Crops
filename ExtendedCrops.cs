using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;
using Terraria.DataStructures;
using Terraria.GameContent.UI;

namespace ExtendedCrops
{
	public class ExtendedCrops : Mod
	{



		public ExtendedCrops()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true,
				AutoloadBackgrounds = true
			};
		}






		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " " + GetItem("Seeds"), new int[]
			{
				ItemType("Seeds"),
				ItemID.GrassSeeds, //ItemID.62,
				ItemID.JungleGrassSeeds, //ItemID.195,
				ItemID.MushroomGrassSeeds, //ItemID.194,
				ItemID.BlinkrootSeeds, //ItemID.309,
				ItemID.DaybloomSeeds, //ItemID.307,
				ItemID.DeathweedSeeds, //ItemID.310,
				ItemID.FireblossomSeeds, //ItemID.312,
				ItemID.MoonglowSeeds, //ItemID.308,
				ItemID.WaterleafSeeds, //ItemID.311,
				ItemID.ShiverthornSeeds, //ItemID.2357,
				ItemID.CorruptSeeds, //ItemID.59,
				ItemID.CrimsonSeeds, //ItemID.2171
				ItemID.HallowedSeeds
			});
			RecipeGroup.RegisterGroup("Clicker:Seeds", group);
		}

		/*public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(this);
			recipe.SetResult(ItemID.Wood, 999);
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.SetResult(ItemID.Silk, 999);
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.SetResult(ItemID.IronOre, 999);
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.SetResult(ItemID.GravitationPotion, 20);
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.SetResult(ItemID.GoldChest);
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.SetResult(ItemID.MusicBoxDungeon);
			recipe.AddRecipe();

			//RecipeHelper.TestRecipeEditor(this);
		}*/
	}


	/*public static class ClickerExtensions
	{
		public static int CountItem(this Player player, int type)
		{
			int count = 0;
			for (int i = 0; i < 58; i++)
			{
				if (type == player.inventory[i].type && player.inventory[i].stack > 0)
				{
					count += player.inventory[i].stack;
				}
			}
			return count;
		}
	}*/
}

