using Terraria.ID;
using Terraria.ModLoader;

namespace RIR.Items
{
    public class AdvancedTinkerersWorkshop : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Advanced Tinkerer's Workshop");
            Tooltip.SetDefault("Allows you to create rare accessories");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 48;
            item.maxStack = 99;
            item.value = 125000;
            item.rare = 4;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.consumable = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.createTile = ModContent.TileType<RIR.Tiles.AdvancedTinkerersWorkshop>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("CobaltBar", 5);
            recipe.AddIngredient(ItemID.TinkerersWorkshop);
            recipe.AddIngredient(ItemID.Book, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
