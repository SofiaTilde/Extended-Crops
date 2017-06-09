using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExtendedCrops.Items.Dyes.Dusts
{
	public class YellowDyeDust : ModItem
	{
		public override void SetDefaults()
		{

			item.maxStack = 999;
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Yellow Dye Dust");
      Tooltip.SetDefault("");
    }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddTile(TileID.TinkeresWorkShops);
			recipe.SetResult(1009);
			recipe.AddRecipe();
		}
	}
}