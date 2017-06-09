using Terraria.ID;
using Terraria.ModLoader;

namespace ExtendedCrops.Items.Processors
{
	public class CSilverSeedProcessor : ModItem
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
			item.createTile = mod.TileType("CSilverSeedProcessor");
		}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Silver Seed Processor");
      Tooltip.SetDefault("Used to craft seeds");
    }


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BIronSeedProcessor");
			recipe.AddIngredient(null, "CSilverDust", 10);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BLeadSeedProcessor");
			recipe.AddIngredient(null, "CSilverDust", 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
