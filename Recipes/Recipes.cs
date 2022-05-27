using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RIR.Recipes {

    public class Recipes : Mod
    {
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SoulofLight, 15);
			recipe.AddIngredient(ItemID.RainbowRod);
			recipe.AddIngredient(ItemID.SoulofNight, 15);
			recipe.AddIngredient(ItemID.PinkGel, 10);
			recipe.AddTile(ModContent.TileType<RIR.Tiles.AdvancedTinkerersWorkshop>());

			recipe.SetResult(ItemID.RodofDiscord);

			recipe.AddRecipe();

			recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Lens, 2);
			recipe.AddIngredient(ItemID.Ectoplasm, 5);
			recipe.AddRecipeGroup("AnyIron", 5);
			recipe.AddTile(ModContent.TileType<RIR.Tiles.AdvancedTinkerersWorkshop>());

			recipe.SetResult(ItemID.RifleScope);

			recipe.AddRecipe();

			recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("AnyIron", 5);
			recipe.AddIngredient(ItemID.EndlessMusketPouch);
			recipe.AddIngredient(ItemID.EndlessQuiver);
			recipe.AddTile(ModContent.TileType<RIR.Tiles.AdvancedTinkerersWorkshop>());

			recipe.SetResult(ItemID.AmmoBox);

			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SoulofNight, 5);
			recipe.AddIngredient(ItemID.ClayBlock, 10);
			recipe.AddIngredient(ItemID.GoldCoin, 5);
			recipe.AddTile(ModContent.TileType<RIR.Tiles.AdvancedTinkerersWorkshop>());

			recipe.SetResult(ItemID.MoneyTrough);

			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SoulofNight, 5);
			recipe.AddIngredient(ItemID.SoulofLight, 5);
			recipe.AddIngredient(ItemID.GoldBar, 10);
			recipe.AddTile(ModContent.TileType<RIR.Tiles.AdvancedTinkerersWorkshop>());

			recipe.SetResult(ItemID.LuckyCoin);

			recipe.AddRecipe();
        }

		public override void AddRecipeGroups()
        {      

            RecipeGroup groupC = new RecipeGroup(() => Lang.misc[37] + "Any сobalt", new int[]
           {
                ItemID.CobaltBar,
                ItemID.PalladiumBar,
            });
            RecipeGroup.RegisterGroup("AnyCobalt", groupC);

			RecipeGroup groupI = new RecipeGroup(() => Lang.misc[37] + "Any iron", new int[]
           {
                ItemID.IronBar,
                ItemID.LeadBar,
            });
            RecipeGroup.RegisterGroup("AnyIron", groupI);
        }
    }
}
