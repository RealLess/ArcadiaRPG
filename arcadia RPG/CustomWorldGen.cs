using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using System.Linq;
using System;

namespace arcadiarpgmod
{
    public class CustomWorldGen : ModWorld
    {

        private void GenIsland(Point topCentre, int size, int type)
        {
            for (int i = -size / 2; i < size / 2; ++i)
            {
                int repY = (size / 2) - (Math.Abs(i));
                int offset = repY / 5;
                repY += WorldGen.genRand.Next(4);
                for (int j = -offset; j < repY; ++j)
                {
                    WorldGen.PlaceTile(topCentre.X + i, topCentre.Y + j, TileID.Cloud);
                }
            }
        }
    }
}