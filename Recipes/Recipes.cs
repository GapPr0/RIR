using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace RIR.Recipes
{

    public class Recipes : Mod
    {
        public override void AddRecipes()
        {
            //Items
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofLight, 15);
            recipe.AddIngredient(ItemID.RainbowRod);
            recipe.AddIngredient(ItemID.SoulofNight, 15);
            recipe.AddIngredient(ItemID.PinkGel, 10);
            recipe.AddTile(TileID.MythrilAnvil);

            recipe.SetResult(ItemID.RodofDiscord);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofNight, 5);
            recipe.AddIngredient(ItemID.ClayBlock, 10);
            recipe.AddIngredient(ItemID.GoldCoin, 5);
            recipe.AddTile(TileID.MythrilAnvil);

            recipe.SetResult(ItemID.MoneyTrough);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofLight, 5);
            recipe.AddIngredient(ItemID.Lens, 2);
            recipe.AddRecipeGroup("IronBar", 5);
            recipe.AddTile(TileID.MythrilAnvil);

            recipe.SetResult(ItemID.Binoculars);
            recipe.AddRecipe();

            //Accessories
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Lens, 2);
            recipe.AddIngredient(ItemID.Ectoplasm, 5);
            recipe.AddRecipeGroup("IronBar", 5);
            recipe.AddTile(ModContent.TileType<RIR.Tiles.AdvancedTinkerersWorkshop>());

            recipe.SetResult(ItemID.RifleScope);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofNight, 5);
            recipe.AddIngredient(ItemID.SoulofLight, 5);
            recipe.AddIngredient(ItemID.GoldBar, 10);
            recipe.AddTile(ModContent.TileType<RIR.Tiles.AdvancedTinkerersWorkshop>());

            recipe.SetResult(ItemID.LuckyCoin);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Glass, 10);
            recipe.AddIngredient(ItemID.GoldBar, 5);
            recipe.AddTile(ModContent.TileType<RIR.Tiles.AdvancedTinkerersWorkshop>());

            recipe.SetResult(ItemID.PocketMirror);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.HellstoneBrick, 10);
            recipe.AddIngredient(ItemID.StoneBlock, 5);
            recipe.AddTile(ModContent.TileType<RIR.Tiles.AdvancedTinkerersWorkshop>());

            recipe.SetResult(ItemID.MagmaStone);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofNight, 5);
            recipe.AddIngredient(ItemID.SoulofLight, 5);
            recipe.AddIngredient(ItemID.PlatinumBar, 10);
            recipe.AddTile(ModContent.TileType<RIR.Tiles.AdvancedTinkerersWorkshop>());

            recipe.SetResult(ItemID.DiscountCard);
            recipe.AddRecipe();

            //Pets and mounts
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Ectoplasm, 10);
            recipe.AddIngredient(ItemID.SoulofNight, 5);
            recipe.AddIngredient(ItemID.Bottle);
            recipe.AddTile(TileID.AlchemyTable);

            recipe.SetResult(ItemID.WispinaBottle);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.PixieDust, 10);
            recipe.AddIngredient(ItemID.SoulofLight, 5);
            recipe.AddIngredient(ItemID.UnicornHorn, 3);
            recipe.AddTile(TileID.AlchemyTable);

            recipe.SetResult(ItemID.BlessedApple);
            recipe.AddRecipe();
        }

        public override void AddRecipeGroups()
        {
            RecipeGroup groupC = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Language.GetTextValue("ItemName.CobaltBar"), new int[]
           {
                ItemID.CobaltBar,
                ItemID.PalladiumBar,
            });
            RecipeGroup.RegisterGroup("CobaltBar", groupC);
        }
    }
}
