using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace arcadiarpgmod.Items
{
    public class WindStone : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wind Stone");
            Tooltip.SetDefault("[c/B1F8FD:Contains the energy of wind]");
        }

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.maxStack = 10;
            item.value = 100;
            item.rare = 6;
        }
    }
}
