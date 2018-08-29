using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
	public class BoneDrillOld : ModProjectile
	{
		public override void SetDefaults()
		{
            if (Config.OldBoneDrillSprite)
            {
                projectile.CloneDefaults(ProjectileID.CobaltDrill);
            }
        }
	}
}