using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.Enums;

namespace ExtendedCrops.Tiles.Plants
{
	public class OShroomitePlant : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileNoFail[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.StyleAlch);
		}

		public override bool Drop(int i, int j)
		{
			Random random = new Random();
			int dust = random.Next(1, 10);
			int seeds = random.Next(2, 5);

			int stage = Main.tile[i, j].frameX / 18;
			if (stage == 0)
			{
				Item.NewItem(i * 16, j * 16, 0, 0, mod.ItemType<Items.Seeds.OShroomiteSeeds>(), 1);
			}
			if (stage == 1)
			{
				Item.NewItem(i * 16, j * 16, 0, 0, mod.ItemType<Items.Seeds.OShroomiteSeeds>(), 1);
			}
			if (stage == 2)
			{
				Item.NewItem(i * 16, j * 16, 0, 0, mod.ItemType<Items.Seeds.OShroomiteSeeds>(), seeds);
				Item.NewItem(i * 16, j * 16, 0, 0, mod.ItemType<Items.Dusts.OShroomiteDust>(), dust);
			}
			return false;
		}

		public override void RandomUpdate(int i, int j)
		{
			if (Main.tile[i, j].frameX == 0)
			{
				Main.tile[i, j].frameX += 18;
			}
			else if (Main.tile[i, j].frameX == 18)
			{
				Main.tile[i, j].frameX += 18;
			}
		}
	}
}