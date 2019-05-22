using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace arcadiarpgmod.Projectiles
{
    public class MagicHatchetPr : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("MagicHatchetPr");
        }
        public override void SetDefaults()
        {

            projectile.width = 25;
            projectile.height = 25;
            projectile.aiStyle = 3;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.magic = false;
            projectile.penetrate = 3;
            projectile.timeLeft = 35000;
            projectile.light = 0.5f;
            projectile.extraUpdates = 1;

        }
        public override void AI()
        {
            if (Main.rand.Next(6) == 0)
            {
                int dustnumber = Dust.NewDust(projectile.position, projectile.width, projectile.height, 15, 0f, 0f, 200, default(Color), 0.8f);
                Main.dust[dustnumber].velocity *= 0.3f;
            }
        }
    }
}