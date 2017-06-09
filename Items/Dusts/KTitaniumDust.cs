using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExtendedCrops.Items.Dusts
{
	public class KTitaniumDust : ModItem
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
      DisplayName.SetDefault("Titanium Dust");
      Tooltip.SetDefault("");
    }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(1106);
			recipe.AddRecipe();
		}
	}
}
