using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExtendedCrops.Items.Dyes.Dusts
{
	public class VioletDyeDust : ModItem
	{
		public override void SetDefaults()
		{

			item.maxStack = 999;
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Violet Dye Dust");
      Tooltip.SetDefault("");
    }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(1017);
			recipe.AddRecipe();
		}
	}
}
