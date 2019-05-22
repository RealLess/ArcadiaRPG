using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace arcadiarpgmod.NPCS
{
    public class UnderworldHeartBat : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hell EyeBat");
        }

        public override void SetDefaults()
        {
            npc.width = 20;
            npc.height = 20;
            npc.damage = 10;
            npc.defense = 10;
            npc.lifeMax = 70;
            npc.scale = 0.6f;
            npc.lavaImmune = true;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath13;
            npc.value = 60f;
            npc.knockBackResist = 0.5f;
            npc.aiStyle = 44;
            Main.npcFrameCount[npc.type] = 3;
            aiType = NPCID.Lavabat;
            animationType = NPCID.Harpy;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (Main.hardMode)
                return SpawnCondition.Underworld.Chance * 0.6f;
            return 0f;
        }

        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter -= 0.3f;
            npc.frameCounter %= Main.npcFrameCount[npc.type];
            int frame = (int)npc.frameCounter;
            npc.frame.Y = frame * frameHeight;
        }

        public override void NPCLoot()
        {
            if (Main.rand.Next(20) < 5)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("HellFruit"), 1);
            }
        }

        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 100);
        }
    }
}
