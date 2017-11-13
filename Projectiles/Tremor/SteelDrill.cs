using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles.Tremor
{
	public class SteelDrill : ModProjectile
	{
        public override void SetDefaults()
		{
            Mod tremor = ModLoader.GetMod("Tremor");
            if (tremor != null)
			{
				projectile.CloneDefaults(ProjectileID.CobaltDrill);
			}
		}
	}
}