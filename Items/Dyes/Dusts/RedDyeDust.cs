using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExtendedCrops.Items.Dyes.Dusts
{
	public class RedDyeDust : ModItem
	{
		public override void SetDefaults()
		{

			item.maxStack = 999;
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Red Dye Dust");
      Tooltip.SetDefault("");
    }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(1007);
			recipe.AddRecipe();
		}
	}
}
