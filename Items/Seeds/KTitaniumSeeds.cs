using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExtendedCrops.Items.Seeds
{
	public class KTitaniumSeeds : ModItem
	{
		public override void SetDefaults()
		{
			item.autoReuse = true;

			item.useTurn = true;
			item.useStyle = 1;
			item.useAnimation = 15;
			item.useTime = 10;
			item.maxStack = 99;
			item.consumable = true;
			item.placeStyle = 0;
			item.width = 12;
			item.height = 14;
			item.value = 80;
			item.createTile = mod.TileType<Tiles.Plants.KTitaniumPlant>();
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Titanium Seeds");
      Tooltip.SetDefault("");
    }


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1106, 10);
			recipe.AddTile(null, "JMythrilSeedProcessor");
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1106, 10);
			recipe.AddTile(null, "JOrichalcumSeedProcessor");
			recipe.SetResult(this);
			recipe.AddRecipe();





			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1106, 10);
			recipe.AddTile(null, "KAdamantiteSeedProcessor");
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1106, 10);
			recipe.AddTile(null, "KTitaniumSeedProcessor");
			recipe.SetResult(this);
			recipe.AddRecipe();





			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1106, 10);
			recipe.AddTile(null, "LHallowedSeedProcessor");
			recipe.SetResult(this);
			recipe.AddRecipe();





			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1106, 10);
			recipe.AddTile(null, "MChlorophyteSeedProcessor");
			recipe.SetResult(this);
			recipe.AddRecipe();





			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1106, 10);
			recipe.AddTile(null, "NSpectreSeedProcessor");
			recipe.SetResult(this);
			recipe.AddRecipe();





			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1106, 10);
			recipe.AddTile(null, "OShroomiteSeedProcessor");
			recipe.SetResult(this);
			recipe.AddRecipe();





			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1106, 10);
			recipe.AddTile(null, "PLuminiteSeedProcessor");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
