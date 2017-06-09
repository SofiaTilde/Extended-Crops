using Terraria.ID;
using Terraria.ModLoader;

namespace ExtendedCrops.Items.Processors
{
	public class SeedProcessor : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 28;
			item.height = 14;
			item.maxStack = 99;

			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("SeedProcessor");
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Seed Processor");
      Tooltip.SetDefault("Used to craft seeds");
    }


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(62, 5);  //Grass
			recipe.AddIngredient(195, 5); //Jungle
			recipe.AddIngredient(194, 5); //Mushroom
			recipe.AddIngredient(309, 5); //Blinkroot
			recipe.AddIngredient(307, 5); //Daybloom
			recipe.AddIngredient(310, 5); //Deathweed
			recipe.AddIngredient(312, 5); //Fireblossom
			recipe.AddIngredient(308, 5); //Moonglow
			recipe.AddIngredient(311, 5); //Waterleaf
			recipe.AddIngredient(2357, 5); //Shiverthorn
			recipe.AddIngredient(59, 5); //Corrupt
			recipe.AddIngredient(3, 10); //Stone
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(62, 5);  //Grass
			recipe.AddIngredient(195, 5); //Jungle
			recipe.AddIngredient(194, 5); //Mushroom
			recipe.AddIngredient(309, 5); //Blinkroot
			recipe.AddIngredient(307, 5); //Daybloom
			recipe.AddIngredient(310, 5); //Deathweed
			recipe.AddIngredient(312, 5); //Fireblossom
			recipe.AddIngredient(308, 5); //Moonglow
			recipe.AddIngredient(311, 5); //Waterleaf
			recipe.AddIngredient(2357, 5); //Shiverthorn
			recipe.AddIngredient(2171, 5); //Crimson
			recipe.AddIngredient(3, 10); //Stone
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
