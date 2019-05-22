using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace arcadiarpgmod.Items.Weapons
{
    public class Hatchet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Modifications:"
                + "\n(NONE)");
            DisplayName.SetDefault("Hatchet");
        }

        public override void SetDefaults()
        {
            item.damage = 30;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 15;
            item.useAnimation = 15;
            item.axe = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 5);
            recipe.AddIngredient(ItemID.SilverBar, 3);
            recipe.AddIngredient(ItemID.Wood, 4);
            recipe.AddTile(TileID.Anvils);
            recipe.needLava = true;
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
