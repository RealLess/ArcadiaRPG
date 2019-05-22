using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace arcadiarpgmod
{
    // ModPlayer classes provide a way to attach data to Players and act on that data. ExamplePlayer has a lot of functionality related to 
    // several effects and items in ExampleMod. See SimpleModPlayer for a very simple example of how ModPlayer classes work.
    public class ModifiPlayer : ModPlayer
    {
        private const int saveVersion = 0;

        private const int maxHellFruits = 50;
        public int HellFruits;

        public bool ZoneExample;

        public override void ResetEffects()
        {
            player.statLifeMax2 += HellFruits * 2;
        }

        public override TagCompound Save()
        {
            // Read https://github.com/blushiemagic/tModLoader/wiki/Saving-and-loading-using-TagCompound to better understand Saving and Loading data.
            return new TagCompound {
				// {"somethingelse", somethingelse}, // To save more data, add additional lines
                {"HellFruits", HellFruits},
            };
        }

        public override void Load(TagCompound tag)
        {
            HellFruits = tag.GetInt("HellFruits");
        }

        public override void LoadLegacy(BinaryReader reader)
        {
            int loadVersion = reader.ReadInt32();
        }
    }
}