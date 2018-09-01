using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool
{
    public class NPCDrops : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {//adds "Jackhamshroom" Item to Truffle Shop.
            if (type == NPCID.Truffle && NPC.downedMechBossAny)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("Jackhamshroom"));
                nextSlot++;
            }
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null && type == tremor.NPCType("Chef"))
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("PizzaCutter"));
                nextSlot++;
            }
        }
        public override bool PreNPCLoot(NPC npc)
        {
            if (npc.type == NPCID.UndeadMiner)
            {//decides whether undeadminer will drop BoneDrill or BonePickaxe if he will even drop.
                if (Main.rand.Next(50) == 0)
                {
                    if (Main.rand.Next(2) == 0)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BoneDrill"));
                    }
                    else
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.BonePickaxe);
                    }
                }
                NPCLoader.blockLoot.Add(ItemID.BonePickaxe);
            }
            if (npc.type == NPCID.Golem && !Main.expertMode)
            {//decides what golem will drop if not in expert mode.
                int num26 = Main.rand.Next(8);
                switch (num26)
                {
                    case 0:
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Stynger);
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.StyngerBolt, Main.rand.Next(60, 100));
                            break;
                        }
                    case 1:
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PossessedHatchet);
                            break;
                        }
                    case 2:
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SunStone);
                            break;
                        }
                    case 3:
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.EyeoftheGolem);
                            break;
                        }
                    case 4:
                        {
                            if (Main.rand.Next(2) == 0)
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Drillsaw"));
                            }
                            else
                            {
                                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Picksaw);
                            }
                            break;
                        }
                    case 5:
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.HeatRay);
                            break;
                        }
                    case 6:
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.StaffofEarth);
                            break;
                        }
                    case 7:
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GolemFist);
                            break;
                        }
                    default:
                        break;
                }
                NPCLoader.blockLoot.Add(ItemID.PossessedHatchet);
                NPCLoader.blockLoot.Add(ItemID.Stynger);
                NPCLoader.blockLoot.Add(ItemID.StyngerBolt);
                NPCLoader.blockLoot.Add(ItemID.GolemFist);
                NPCLoader.blockLoot.Add(ItemID.StaffofEarth);
                NPCLoader.blockLoot.Add(ItemID.HeatRay);
                NPCLoader.blockLoot.Add(ItemID.Picksaw);
                NPCLoader.blockLoot.Add(ItemID.EyeoftheGolem);
                NPCLoader.blockLoot.Add(ItemID.SunStone);
            }
            if (npc.type == NPCID.Plantera && !Main.expertMode)
            {//Decides what plantera should drop if not in expert mode.
                if (Main.rand.Next(50) == 0)
                {
                    if (Main.rand.Next(2) == 0)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TheSaw"));
                    }
                    else
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.TheAxe);
                    }
                }
                NPCLoader.blockLoot.Add(ItemID.TheAxe);
            }
            Mod tremor = ModLoader.GetMod("Tremor");
            if (npc.type == NPCID.WallofFlesh && !Main.expertMode)
            {//decides what wall flash should drop if not on expert mode.
                if (tremor != null && Config.DommhammerjackhammerSettings == 1)
                {
                    if (Main.rand.Next(2) == 0)
                    {
                        if (Main.rand.Next(2) == 0)
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Pwnjackhammer"));
                        }
                        else
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Pwnhammer);
                        }
                    }
                    else
                    {
                        if (Main.rand.Next(2) == 0)
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Doomjackhammer"));
                        }
                        else
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, tremor.ItemType("Doomhammer"));
                        }
                    }
                }
                else if (tremor != null && Config.DommhammerjackhammerSettings == 2)
                {
                    if (Main.rand.Next(2) == 0)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Doomjackhammer"));
                    }
                    else
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, tremor.ItemType("Doomhammer"));
                    }
                }
                else
                {
                    if (Main.rand.Next(2) == 0)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Pwnjackhammer"));
                    }
                    else
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Pwnhammer);
                    }
                }
                NPCLoader.blockLoot.Add(ItemID.Pwnhammer);
            }
            if (tremor != null && npc.type == NPCID.UndeadViking)
            {
                if (Main.rand.Next(32) == 0)
                {
                    if (Main.rand.Next(2) == 0)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("NorthChainsaw"));
                    }
                    else
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, tremor.ItemType("NorthAxe"));
                    }
                }
                NPCLoader.blockLoot.Add(tremor.ItemType("NorthAxe"));
                if (Main.rand.Next(32) == 0)
                {
                    if (Main.rand.Next(2) == 0)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("NorthJackhammer"));
                    }
                    else
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, tremor.ItemType("NorthHammer"));
                    }
                }
                NPCLoader.blockLoot.Add(tremor.ItemType("NorthHammer"));
            }
            if (tremor != null && npc.type == tremor.NPCType("TikiTotem") && !Main.expertMode)
            {
                if (Main.rand.Next(3) == 0)
                {
                    if (Main.rand.Next(2) == 0)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DrillofBloom"));
                    }
                    else
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, tremor.ItemType("PickaxeofBloom"));
                    }
                }
                NPCLoader.blockLoot.Add(tremor.ItemType("PickaxeofBloom"));
            }
            if (tremor != null && npc.type == tremor.NPCType("SoulofHope") && !Main.expertMode)
            {
                if (Main.rand.Next(3) == 0)
                {
                    if (Main.rand.Next(2) == 0)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Banjackhammer"));
                    }
                    else
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, tremor.ItemType("Banhammer"));
                    }
                }
                NPCLoader.blockLoot.Add(tremor.ItemType("Banhammer"));
            }
            return true;
        }
    }
}