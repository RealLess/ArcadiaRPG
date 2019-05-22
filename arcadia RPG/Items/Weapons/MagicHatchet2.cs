using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace arcadiarpgmod.Items.Weapons
{
    public class MagicHatchet2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Modifications:"
                + "\nStone of the Wind:" 
                + "\n- 35 Wind Damage"
                + "\nFlame Stone:"
                + "\n- 10 Fire Damage");
            DisplayName.SetDefault("[Modified] Hatchet");
        }

        public override void SetDefaults()
        {
            item.damage = 55;
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

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            for (int i = 0; i < 1000; ++i)
            {
                if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == item.shoot)
                {
                    return false;
                }
            }

            if (player.altFunctionUse == 2)
            {
                item.shoot = mod.ProjectileType("MagicHatchetPr2");
                item.shootSpeed = 8f;
                player.altFunctionUse = 1;
                item.damage = 35;
            }
            else
            {
                item.damage = 55;
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
                item.shoot = 0;
            }
            return base.CanUseItem(player);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Hatchet"));
            recipe.AddIngredient(mod.ItemType("WindStone"));
            recipe.AddIngredient(mod.ItemType("FlameStone"));
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(mod.ItemType("MagicHatchet"));
            recipe2.AddIngredient(mod.ItemType("FlameStone"));
            recipe2.AddTile(TileID.Anvils);
            recipe2.SetResult(this);
            recipe2.AddRecipe();
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            // Add Onfire buff to the NPC for 1 second
            // 60 frames = 1 second
            target.AddBuff(BuffID.OnFire, 120);
        }
    }
}
