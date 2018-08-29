using Terraria.ID;
using Terraria.ModLoader;

namespace BettertakeaPowerTool.Projectiles
{
	public class CandyCaneDrillOld : ModProjectile
	{
		public override void SetDefaults()
		{
            if (Config.OldCandyCaneDrillSprite)
            {
                projectile.CloneDefaults(ProjectileID.CobaltDrill);
            }
        }
	}
}