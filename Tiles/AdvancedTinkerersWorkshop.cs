using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace RIR.Tiles
{
    public class AdvancedTinkerersWorkshop : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileLavaDeath[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileFrameImportant[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Advanced Tinkerer's Workshop");
            dustType = mod.DustType("Sparkle");
            AddMapEntry(new Color(7, 68, 113), name);
            adjTiles = new int[] { TileID.TinkerersWorkbench };
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("AdvancedTinkerersWorkshop"));
        }
    }
}
