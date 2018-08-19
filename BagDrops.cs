using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool
{
	public class BagDrops : GlobalItem
	{
		public override bool PreOpenVanillaBag(string context, Player player, int arg)
        {
            if (context == "bossBag" && arg == ItemID.GolemBossBag)
            {//decides what golem boss bag will drop.
                int num26 = Main.rand.Next(8);
                switch(num26)
                {
                    case 0:
                        {
                            player.QuickSpawnItem(ItemID.Stynger);
                            player.QuickSpawnItem(ItemID.StyngerBolt, Main.rand.Next(60, 100));
                            break;
                        }
                    case 1:
                        {
                            player.QuickSpawnItem(ItemID.PossessedHatchet);
                            break;
                        }
                    case 2:
                        {
                            player.QuickSpawnItem(ItemID.SunStone);
                            break;
                        }
                    case 3:
                        {
                            player.QuickSpawnItem(ItemID.EyeoftheGolem);
                            break;
                        }
                    case 4:
                        {
                            if (Main.rand.Next(2) == 0)
                            {
                                player.QuickSpawnItem(mod.ItemType("Drillsaw"));
                            }
                            else
                            {
                                player.QuickSpawnItem(ItemID.Picksaw);
                            }
                            break;
                        }
                    case 5:
                        {
                            player.QuickSpawnItem(ItemID.HeatRay);
                            break;
                        }
                    case 6:
                        {
                            player.QuickSpawnItem(ItemID.StaffofEarth);
                            break;
                        }
                    case 7:
                        {
                            player.QuickSpawnItem(ItemID.GolemFist);
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
            if (context == "bossBag" && arg == ItemID.PlanteraBossBag) 
			{//Decides what plantera boss bag should drop.
				if (Main.rand.Next(20) == 0)
				{
					if (Main.rand.Next(2) == 0)
					{
						player.QuickSpawnItem(mod.ItemType("TheSaw"));
					}
					else
					{
						player.QuickSpawnItem(ItemID.TheAxe);
					}
				}
				NPCLoader.blockLoot.Add(ItemID.TheAxe);
			}
            Mod tremor = ModLoader.GetMod("Tremor");
            if (context == "bossBag" && arg == ItemID.WallOfFleshBossBag)
            {//decides what wall flash boss bag should drop.
                if (tremor != null && Config.DommhammerjackhammerSettings == 1)
                {
                    if (Main.rand.Next(2) == 0)
                    {
                        if (Main.rand.Next(2) == 0)
                        {
                            player.QuickSpawnItem(mod.ItemType("Pwnjackhammer"));
                        }
                        else
                        {
                            player.QuickSpawnItem(ItemID.Pwnhammer);
                        }
                    }
                    else
                    {
                        if (Main.rand.Next(2) == 0)
                        {
                            player.QuickSpawnItem(mod.ItemType("Doomjackhammer"));
                        }
                        else
                        {
                            player.QuickSpawnItem(tremor.ItemType("Doomhammer"));
                        }
                    }
                }
                else if (tremor != null && Config.DommhammerjackhammerSettings == 2)
                {
                    if (Main.rand.Next(2) == 0)
                    {
                        player.QuickSpawnItem(mod.ItemType("Doomjackhammer"));
                    }
                    else
                    {
                        player.QuickSpawnItem(tremor.ItemType("Doomhammer"));
                    }
                }
                else
                {
                    if (Main.rand.Next(2) == 0)
                    {
                        player.QuickSpawnItem(mod.ItemType("Pwnjackhammer"));
                    }
                    else
                    {
                        player.QuickSpawnItem(ItemID.Pwnhammer);
                    }
                }
                NPCLoader.blockLoot.Add(ItemID.Pwnhammer);
            }
            if (tremor != null)
            {
                if (context == "bossBag" && arg == tremor.ItemType("TikiTotemBag"))
                {
                    if (Main.rand.Next(3) == 0)
                    {
                        if (Main.rand.Next(2) == 0)
                        {
                            player.QuickSpawnItem(mod.ItemType("DrillofBloom"));
                        }
                        else
                        {
                            player.QuickSpawnItem(tremor.ItemType("PickaxeofBloom"));
                        }
                    }
                    NPCLoader.blockLoot.Add(tremor.ItemType("PickaxeofBloom"));
                }
                if (context == "bossBag" && arg == tremor.ItemType("TrinityBag1"))
                {
                    if (Main.rand.Next(3) == 0)
                    {
                        if (Main.rand.Next(2) == 0)
                        {
                            player.QuickSpawnItem(mod.ItemType("Banjackhammer"));
                        }
                        else
                        {
                            player.QuickSpawnItem(tremor.ItemType("Banhammer"));
                        }
                    }
                    NPCLoader.blockLoot.Add(tremor.ItemType("Banhammer"));
                }
                if (context == "bossBag" && arg == tremor.ItemType("TrinityBag2"))
                {
                    if (Main.rand.Next(3) == 0)
                    {
                        if (Main.rand.Next(2) == 0)
                        {
                            player.QuickSpawnItem(mod.ItemType("Banjackhammer"));
                        }
                        else
                        {
                            player.QuickSpawnItem(tremor.ItemType("Banhammer"));
                        }
                    }
                    NPCLoader.blockLoot.Add(tremor.ItemType("Banhammer"));
                }
                if (context == "bossBag" && arg == tremor.ItemType("TrinityBag3"))
                {
                    if (Main.rand.Next(3) == 0)
                    {
                        if (Main.rand.Next(2) == 0)
                        {
                            player.QuickSpawnItem(mod.ItemType("Banjackhammer"));
                        }
                        else
                        {
                            player.QuickSpawnItem(tremor.ItemType("Banhammer"));
                        }
                    }
                    NPCLoader.blockLoot.Add(tremor.ItemType("Banhammer"));
                }
            }
			return true;
		}
	}
}