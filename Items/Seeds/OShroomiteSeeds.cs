using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExtendedCrops.Items.Seeds
{
	public class OShroomiteSeeds : ModItem
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
			item.createTile = mod.TileType<Tiles.Plants.OShroomitePlant>();
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Shroomite Seeds");
      Tooltip.SetDefault("");
    }


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1552, 5);
			recipe.AddTile(null, "NSpectreSeedProcessor");
			recipe.SetResult(this);
			recipe.AddRecipe();





			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1552, 5);
			recipe.AddTile(null, "OShroomiteSeedProcessor");
			recipe.SetResult(this);
			recipe.AddRecipe();





			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1552, 5);
			recipe.AddTile(null, "PLuminiteSeedProcessor");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
