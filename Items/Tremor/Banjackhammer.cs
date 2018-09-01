using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Items.Tremor
{
	public class Banjackhammer : ModItem
	{
		public override void SetStaticDefaults()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
			{
				DisplayName.SetDefault("Banjackhammer");
			}
		}
		public override void SetDefaults()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
			{
				item.CloneDefaults(tremor.ItemType("Banhammer"));
				item.channel = true;
				item.noUseGraphic = true;
				item.noMelee = true;
				item.useStyle = 5;
				item.UseSound = SoundID.Item23;
				item.shoot = mod.ProjectileType("Banjackhammer");
				item.shootSpeed = 40f;
			}
		}
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
            {
                tooltips[0].overrideColor = new Color(238, 194, 73);
            }
        }
    }
}