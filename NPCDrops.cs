using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool
{
	public class NPCDrops : GlobalNPC
	{
        	public override void SetupShop(int type, Chest shop, ref int nextSlot)
		{
			if (type == NPCID.Truffle && NPC.downedMechBossAny)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("Jackhamshroom"));
				nextSlot++;
			}
		}
		public override bool PreNPCLoot(NPC npc)
		{
			if (npc.type == NPCID.UndeadMiner)
			{
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

			if (npc.type == NPCID.Golem)
			{
				if (Main.expertMode)
				{
				}
				else
				{
					int num26 = Main.rand.Next(8);
					if (num26 == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Stynger);
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.StyngerBolt, Main.rand.Next(60,100));
					}
					else if (num26 == 1)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PossessedHatchet);
					}
					else if (num26 == 2)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SunStone);
					}
					else if (num26 == 3)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.EyeoftheGolem);
					}
					else if (num26 == 4)
					{
						if (Main.rand.Next(2) == 0)
						{
							Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Drillsaw"));
						}
						else
						{
							Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Picksaw);
						}
					}
					else if (num26 == 5)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.HeatRay);
					}
					else if (num26 == 6)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.StaffofEarth);
					}
					else if (num26 == 7)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GolemFist);
					}
					NPCLoader.blockLoot.Add(ItemID.Stynger);
					NPCLoader.blockLoot.Add(ItemID.StyngerBolt);
					NPCLoader.blockLoot.Add(ItemID.PossessedHatchet);
					NPCLoader.blockLoot.Add(ItemID.SunStone);
					NPCLoader.blockLoot.Add(ItemID.EyeoftheGolem);
					NPCLoader.blockLoot.Add(ItemID.Picksaw);
					NPCLoader.blockLoot.Add(ItemID.HeatRay);
					NPCLoader.blockLoot.Add(ItemID.StaffofEarth);
					NPCLoader.blockLoot.Add(ItemID.GolemFist);
				}
			}

			if (npc.type == NPCID.WallofFlesh)
			{
				if (Main.expertMode)
				{
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
					NPCLoader.blockLoot.Add(ItemID.Pwnhammer);
				}
			}
			if (npc.type == NPCID.Plantera)
			{
				if (Main.expertMode)
				{
				}
				else
				{
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
			}

			Mod tremor = ModLoader.GetMod("Tremor");
			if(tremor != null)
			{
				if (npc.type == ModLoader.GetMod("Tremor").NPCType("TikiTotem"))
				{
					if (Main.expertMode)
					{
					}
					else
					{
						if (Main.rand.Next(3) == 0)
						{
							if (Main.rand.Next(2) == 0)
							{
								Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DrillofBloom"));
							}
							else
							{
								Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModLoader.GetMod("Tremor").ItemType("PickaxeofBloom"));
							}
						}
						NPCLoader.blockLoot.Add(ModLoader.GetMod("Tremor").ItemType("PickaxeofBloom"));
					}
				}
			}
			return true;
		}
	}
}