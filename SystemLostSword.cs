using Terraria;
using Terraria.ModLoader;
using TERMOD.Content.Items.swords;

namespace TERMOD
{
    public class SystemLostSword : ModSystem
    {
        public override void PostWorldGen()
        {
            for (int i = 0; i < Main.maxChests; i++)
            {
                Chest chest = Main.chest[i];
                if (chest == null) continue;

                Tile tile = Main.tile[chest.x, chest.y];

                // Проверка, что это именно сундук подземелья (Dungeon Chest)
                if (tile.TileFrameX == 36 && tile.TileFrameY == 0)
                {
                    for (int slot = 0; slot < Chest.maxItems; slot++)
                    {
                        if (chest.item[slot].IsAir)
                        {
                            chest.item[slot].SetDefaults(ModContent.ItemType<LostSword>());
                            chest.item[slot].stack = 1;
                            break;
                        }
                    }
                }
            }
        }
    }
}