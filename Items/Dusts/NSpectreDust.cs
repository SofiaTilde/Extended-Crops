using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExtendedCrops.Items.Dusts
{
	public class NSpectreDust : ModItem
	{
		public override void SetDefaults()
		{

			item.maxStack = 999;
			/*item.width = 12;
			item.height = 14;
			item.value = 80;*/
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Spectre Dust");
      Tooltip.SetDefault("");
    }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 80);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(3261);
			recipe.AddRecipe();
		}
	}
}
