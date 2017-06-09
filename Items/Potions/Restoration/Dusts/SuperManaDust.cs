using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExtendedCrops.Items.Potions.Restoration.Dusts
{
	public class SuperManaDust : ModItem
	{
		public override void SetDefaults()
		{

			item.maxStack = 999;
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Super Mana Dust");
      Tooltip.SetDefault("");
    }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 15);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(2209);
			recipe.AddRecipe();
		}
	}
}
