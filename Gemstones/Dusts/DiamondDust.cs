using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExtendedCrops.Items.Gemstones.Dusts
{
	public class DiamondDust : ModItem
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
      DisplayName.SetDefault("Diamond Dust");
      Tooltip.SetDefault("");
    }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 15);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(182);
			recipe.AddRecipe();
		}
	}
}
